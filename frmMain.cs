using Acquaint.Integrators.Api.Demo.Models;
using Acquaint.Integrators.Api.Demo.Utilities;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Acquaint.Integrators.Api.Tests
{
    public partial class frmMain : Form
    {
        private string? baseUrl = string.Empty;
        private readonly HttpClient _httpClient = new HttpClient();
        private string jwtToken = string.Empty;
        private List<Category> categories;
        private Subcategory? selectedAPI;

        public frmMain()
        {
            InitializeComponent();
            categories = Helper.BuildApiList();
            initialFeilds();
        }

        private void initialFeilds()
        {
            txtAuthRequestBody.ReadOnly = true;
            baseUrl = GetValueFromRegistry("BaseUrl");
            txtSitePrefix.Text = GetValueFromRegistry("SitePrefix");
            txtAPIKey.Text = GetValueFromRegistry("APIKey");
            if (!string.IsNullOrEmpty(baseUrl))
            {
                comboBoxUrls.SelectedItem = baseUrl;
            }
            else
            {
                comboBoxUrls.SelectedIndex = 0;
            }
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
            PopulateTreeView(categories, treeViewApis);
        }

        private async void treeViewApis_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!.Parent != null)
            {
                Subcategory? selectedSubcategory = e.Node.Tag as Subcategory;
                if (selectedSubcategory != null)
                {
                    txtApiResponse.Text = string.Empty;
                    selectedAPI = selectedSubcategory;
                    txtSelectedAPIUrl.Text = selectedSubcategory.Url;
                    txtAPIRequestBody.Text = selectedSubcategory.RequestBody;
                    if (selectedAPI.MethodType == ApiMethodType.GET)
                    {
                        await executeApis();
                    }                   
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

        private void PopulateTreeView(List<Category> categories, TreeView treeView)
        {
            foreach (var category in categories)
            {
                TreeNode categoryNode = new TreeNode(category.Name);

                foreach (var subcategory in category.Subcategories!)
                {
                    TreeNode subcategoryNode = new TreeNode(subcategory.Name);
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

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var formattedJson = JToken.Parse(jsonResponse).ToString(Formatting.Indented);
                    txtApiResponse.Text = formattedJson;
                }
                else
                {
                    MessageBox.Show("API Call Failed: " + response.StatusCode);
                }
                progressBarLoading.Visible = false;
            }
            catch (Exception ex)
            {
                progressBarLoading.Visible = false;
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

                var httpContent = new StringContent(txtAPIRequestBody.Text, Encoding.UTF8, "application/json");

                switch (selectedAPI?.MethodType)
                {
                    case ApiMethodType.GET:
                        response = await _httpClient.GetAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}");
                        break;
                    case ApiMethodType.POST:
                        response = await _httpClient.PostAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}", httpContent);
                        break;
                    case ApiMethodType.PUT:
                        response = await _httpClient.PutAsync($"{baseUrl}/{txtSelectedAPIUrl.Text}", httpContent);
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
                    HttpResponseMessage response = await _httpClient.PostAsync($"{baseUrl}/v1/Auth", httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
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
                SetValueToRegistry("BaseUrl", baseUrl);
            }
        }

        private void SetValueToRegistry(string key, string value)
        {
            jwtToken = string.Empty;
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey($"Software\\Acquaint.Integrators.Api", true);

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
        private string GetValueFromRegistry(string key)
        {
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey($"Software\\Acquaint.Integrators.Api", true);

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
                SetValueToRegistry("APIKey", txtAPIKey.Text);
            }
            setInitialAuthRequest(txtSitePrefix.Text, txtAPIKey.Text);
        }

        private void txtSitePrefix_Leave(object sender, EventArgs e)
        {
            setInitialAuthRequest(txtSitePrefix.Text, string.Empty);
            if (txtSitePrefix.Text != string.Empty)
            {
                SetValueToRegistry("SitePrefix", txtSitePrefix.Text);
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
    }
}
