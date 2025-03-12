using Acquaint.Integrators.Api.Demo.Models;
using Acquaint.Integrators.Api.Demo.Utilities;
using BrightLogicCore.Files;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Acquaint.Integrators.Api.Tests
{
    public partial class frmMain : Form
    {
        private string selectedFilePath;
        private string? baseUrl = string.Empty;
        private HttpClient _httpClient;
        private string jwtToken = string.Empty;
        private List<Category> categories;
        private Subcategory? selectedAPI;
        private MimeTypeMapping _mimeTypeMapper;
        private const int MaxWidth = 546;
        private const int MaxHeight = 754;

        public frmMain()
        {
            selectedFilePath = string.Empty;
            InitializeComponent();
            categories = Helper.BuildApiList();
            initialFeilds();
            _mimeTypeMapper = new MimeTypeMapping();
            _httpClient = new HttpClient();
        }

        private void initialFeilds()
        {
            txtAuthRequestBody.ReadOnly = true;
            baseUrl = getValueFromRegistry("BaseUrl");
            txtSitePrefix.Text = getValueFromRegistry("SitePrefix");
            txtAPIKey.Text = getValueFromRegistry("APIKey");
            if (!string.IsNullOrEmpty(baseUrl))
            {
                comboBoxUrls.SelectedItem = baseUrl;
            }
            else
            {
                comboBoxUrls.SelectedIndex = 0;
            }
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
            populateTreeView(categories, treeViewApis);
        }

        private void treeViewApis_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!.Parent != null)
            {
                var selectedSubcategory = e.Node.Tag as Subcategory;
                if (selectedSubcategory != null)
                {
                    txtApiResponse.Text = string.Empty;
                    selectedAPI = selectedSubcategory;
                    txtSelectedAPIUrl.Text = selectedSubcategory.Url;
                    labelHttpMethod.Text = $"(Http {selectedSubcategory.MethodType.ToString()})";
                    txtAPIRequestBody.Text = selectedSubcategory.RequestBody;

                    if (selectedSubcategory.isUploadFile)
                    {
                        buttonSelect.Enabled = true;
                    }
                    else
                    {
                        buttonSelect.Enabled = false;
                    }

                    resetControls();
                }
            }
        }

        private void treeViewApis_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode node in treeViewApis.Nodes)
            {
                if (node.IsExpanded && node != e.Node)
                {
                    node.Collapse();
                }
            }
        }

        private void populateTreeView(List<Category> categories, TreeView treeView)
        {
            foreach (var category in categories)
            {
                var categoryNode = new TreeNode(category.Name);

                foreach (var subcategory in category.Subcategories!)
                {
                    var subcategoryNode = new TreeNode(subcategory.Name);
                    subcategoryNode.Tag = subcategory;
                    categoryNode.Nodes.Add(subcategoryNode);
                }

                treeView.Nodes.Add(categoryNode);
            }
        }
        private void setInitialAuthRequest(string sitePrefix, string apiKey)
        {
            var requestBody = new
            {
                SitePrefix = sitePrefix,
                ApiKey = apiKey,
            };
            txtAuthRequestBody.Text = requestBody.SerializeObjectToJson().FormatStringObjectToJson();
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            await executeApis();
        }

        private async Task executeApis()
        {
            validateFields();
            progressBarLoading.Visible = true;
            txtApiResponse.Text = string.Empty;
            await authLogin();
            if (string.IsNullOrEmpty(jwtToken))
            {
                MessageBox.Show("You need to log in first!");
                return;
            }
            try
            {
                var response = await executeApiMethods();

                txtApiResponse.Visible = false;
                pictureBox.Visible = false;
                webViewPdf.Visible = false;
                if (response.IsSuccessStatusCode)
                {
                    string contentType = response.Content.Headers.ContentType?.MediaType!;
                    if (contentType != null && contentType.StartsWith("image/"))
                    {
                        pictureBox.Visible = true;
                        await displayImageFromApiAsync(response);
                    }
                    else if (contentType != null && contentType!.Contains("application/pdf"))
                    {
                        try
                        {
                            if (!response.IsSuccessStatusCode)
                            {
                                MessageBox.Show($"Failed to fetch PDF: {response.ReasonPhrase}");
                                return;
                            }

                            // Read PDF content as bytes
                            var pdfBytes = await response.Content.ReadAsByteArrayAsync();

                            // Create a temporary file to store the PDF
                            var tempPdfPath = Path.Combine(Path.GetTempPath(), "tempfile.pdf");
                            await File.WriteAllBytesAsync(tempPdfPath, pdfBytes);

                            webViewPdf.Visible = true;
                            webViewPdf.Source = new Uri(tempPdfPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error displaying PDF: " + ex.Message);
                        }
                    }
                    else
                    {
                        txtApiResponse.Visible = true;
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(jsonResponse))
                        {
                            var formattedJson = JToken.Parse(jsonResponse).ToString(Formatting.Indented);
                            txtApiResponse.Text = formattedJson;
                        }
                        else if (selectedAPI!.MethodType == ApiMethodType.Delete)
                        {
                            MessageBox.Show($"Successfully deleted.");
                        }
                    }
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Please make sure that ID is valid, {response.ReasonPhrase}");
                    }
                    else
                    {
                        MessageBox.Show($"API Call Failed: {response.StatusCode}");
                    }
                }
                progressBarLoading.Visible = false;
            }
            catch (Exception ex)
            {
                progressBarLoading.Visible = false;
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private async Task displayImageFromApiAsync(HttpResponseMessage response)
        {
            try
            {
                var imageBytes = await response.Content.ReadAsByteArrayAsync();
                using (var ms = new MemoryStream(imageBytes))
                {
                    using (var originalImage = Image.FromStream(ms))
                    {
                        // Determine the proper size
                        var newSize = CalculateImageSize(originalImage, MaxWidth, MaxHeight);

                        // Resize PictureBox to match the calculated size
                        pictureBox.Width = newSize.Width;
                        pictureBox.Height = newSize.Height;

                        // Display image in correct size
                        pictureBox.Image = new Bitmap(originalImage);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private Size CalculateImageSize(Image originalImage, int maxWidth, int maxHeight)
        {
            if (originalImage.Width <= maxWidth && originalImage.Height <= maxHeight)
            {
                // Small image: Keep its original size
                return new Size(originalImage.Width, originalImage.Height);
            }

            // Large image: Resize proportionally
            var ratioX = (float)maxWidth / originalImage.Width;
            var ratioY = (float)maxHeight / originalImage.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(originalImage.Width * ratio);
            var newHeight = (int)(originalImage.Height * ratio);

            return new Size(newWidth, newHeight);
        }

        private void validateFields()
        {
            if (string.IsNullOrEmpty(baseUrl))
            {
                MessageBox.Show("Please select the base url.");
                return;
            }
            if (string.IsNullOrEmpty(txtSitePrefix.Text))
            {
                MessageBox.Show("Please enter site prefix.");
                return;
            }
            if (string.IsNullOrEmpty(txtAPIKey.Text))
            {
                MessageBox.Show("Please enter API key.");
                return;
            }
        }

        private async Task<HttpResponseMessage> executeApiMethods()
        {
            try
            {
                var response = new HttpResponseMessage();
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);

                var queryString = string.Empty;
                if (!string.IsNullOrEmpty(txtAPIRequestBody.Text))
                {
                    queryString = txtAPIRequestBody.Text.ToQueryString();
                }

                var httpContent = new StringContent(txtAPIRequestBody.Text, Encoding.UTF8, "application/json");

                switch (selectedAPI?.MethodType)
                {
                    case ApiMethodType.Get:
                        response = await _httpClient.GetAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}{queryString}");
                        break;
                    case ApiMethodType.Post:
                        if (selectedAPI.isUploadFile)
                        {
                            await uploadFileAsync();
                        }
                        else
                        {
                            response = await _httpClient.PostAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}", httpContent);
                        }
                        break;
                    case ApiMethodType.Put:
                        if (selectedAPI.isUploadFile)
                        {
                            await uploadFileAsync();
                        }
                        else
                        {
                            response = await _httpClient.PutAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}", httpContent);
                        }
                        break;
                    case ApiMethodType.Delete:
                        response = await _httpClient.DeleteAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}{queryString}");
                        break;
                    default:
                        // Code to execute if no cases match
                        break;
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task authLogin()
        {
            if (string.IsNullOrEmpty(jwtToken))
            {
                var httpContent = new StringContent(txtAuthRequestBody.Text, Encoding.UTF8, "application/json");

                try
                {
                    var response = await _httpClient.PostAsync($"{baseUrl}/v1/Auth", httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        dynamic jsonResponse = JsonConvert.DeserializeObject(result)!;
                        jwtToken = jsonResponse.token;
                    }
                    else
                    {
                        progressBarLoading.Visible = false;
                        MessageBox.Show("Login Failed: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    progressBarLoading.Visible = false;
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBoxUrls_SelectedValueChanged(object sender, EventArgs e)
        {
            baseUrl = comboBoxUrls.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(baseUrl))
            {
                setValueToRegistry("BaseUrl", baseUrl);
            }
        }

        private void setValueToRegistry(string key, string value)
        {
            jwtToken = string.Empty;
            var regKey = Registry.CurrentUser.OpenSubKey($"Software\\Acquaint.Integrators.Api", true);

            if (regKey == null)
            {
                regKey = Registry.CurrentUser.CreateSubKey("Software\\Acquaint.Integrators.Api");
            }

            if (regKey != null)
            {
                regKey.SetValue(key, value, RegistryValueKind.String);
                regKey.Close();
            }
            else
            {
                MessageBox.Show("Error accessing Registry.");
            }
        }
        private string getValueFromRegistry(string key)
        {
            var regKey = Registry.CurrentUser.OpenSubKey($"Software\\Acquaint.Integrators.Api", true);

            if (regKey != null)
            {
                return (string)regKey.GetValue(key)!;
            }
            return string.Empty;
        }

        private void txtAPIKey_Leave(object sender, EventArgs e)
        {
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
            if (txtAPIKey.Text != string.Empty)
            {
                setValueToRegistry("APIKey", txtAPIKey.Text);
            }
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
        }

        private void txtSitePrefix_Leave(object sender, EventArgs e)
        {
            setInitialAuthRequest(txtSitePrefix.Text, string.Empty);
            if (txtSitePrefix.Text != string.Empty)
            {
                setValueToRegistry("SitePrefix", txtSitePrefix.Text);
            }
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
        }

        private async void txtSelectedAPIUrl_Enter(object sender, EventArgs e)
        {
            await executeApis();
        }

        private async void txtSelectedAPIUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await executeApis();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = $"Supported Files ({selectedAPI!.SupportedFileTypes}) | {selectedAPI!.SupportedFileTypes}";
                openFileDialog.FilterIndex = 1;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    var extension = Path.GetExtension(selectedFilePath).ToLower();

                    pictureBox.Visible = false;
                    webViewPdf.Visible = false;
                    txtApiResponse.Visible = false;

                    if (extension == ".pdf")
                    {
                        pictureBox.Image = null;
                        webViewPdf.Visible = true;
                        txtApiResponse.Text = Path.GetFileName(selectedFilePath);
                        webViewPdf.Source = new Uri(selectedFilePath);
                    }
                    else
                    {
                        try
                        {
                            // Load image safely without locking the file
                            pictureBox.Visible = true;
                            loadImageWithScaling(selectedFilePath);

                            txtApiResponse.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error displaying image: {ex.Message}");
                            resetControls();
                        }
                    }
                }
            }
        }

        private void loadImageWithScaling(string selectedFilePath)
        {
            try
            {
                using (var stream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var originalImage = Image.FromStream(stream))
                    {
                        // Check if resizing is needed
                        if (originalImage.Width <= MaxWidth && originalImage.Height <= MaxHeight)
                        {
                            loadImageOriginalResolution(selectedFilePath);
                        }
                        else
                        {
                            // Resize only if the image is too large
                            pictureBox.Image = resizeImageIfNeeded(originalImage, MaxWidth, MaxHeight);
                            // Use Zoom mode to fit the PictureBox nicely
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private Image resizeImageIfNeeded(Image originalImage, int maxWidth, int maxHeight)
        {
            // Display small images at their original size (avoid scaling up)
            if (originalImage.Width <= maxWidth && originalImage.Height <= maxHeight)
            {
                return new Bitmap(originalImage); // Keep original size for smaller images
            }

            // Calculate scaling factor for large images
            var ratioX = (float)maxWidth / originalImage.Width;
            var ratioY = (float)maxHeight / originalImage.Height;
            var ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            var resizedImage = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private void loadImageOriginalResolution(string selectedFilePath)
        {
            try
            {
                using (var stream = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(stream);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private async Task uploadFileAsync()
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a valid file first.");
                return;
            }

            var extension = Path.GetExtension(selectedFilePath).ToLower();
            var mimeType = _mimeTypeMapper.GetMimeType(extension);

            if (mimeType == null)
            {
                MessageBox.Show("Unsupported file format.");
                return;
            }

            try
            {
                var fileBytes = await File.ReadAllBytesAsync(selectedFilePath);
                using (var byteContent = new ByteArrayContent(fileBytes))
                {
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mimeType);

                    var response = new HttpResponseMessage();
                    if (selectedAPI!.MethodType == ApiMethodType.Put)
                    {
                        response = await _httpClient.PutAsync(
                            $"{baseUrl}/{txtSelectedAPIUrl.Text}",
                            byteContent
                        );
                    }
                    else
                    {
                        response = await _httpClient.PostAsync(
                            $"{baseUrl}/{txtSelectedAPIUrl.Text}",
                            byteContent
                        );
                    }

                    var responseMessage = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Image uploaded successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Upload failed: {responseMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}");
            }
            finally
            {
                resetControls();
            }
        }

        private void resetControls()
        {
            txtApiResponse.Text = "";
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            if (webViewPdf != null && webViewPdf.CoreWebView2 != null)
            {
                webViewPdf.CoreWebView2.Navigate("about:blank");
            }
        }
    }
}
