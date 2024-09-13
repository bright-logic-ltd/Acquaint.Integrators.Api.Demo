using Acquaint.Integrators.Api.Tests.Models;
using Acquaint.Integrators.Api.Tests.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Acquaint.Integrators.Api.Tests
{
    public partial class frmMain : Form
    {
        private const string baseUrl = "https://localhost:44324";

        private readonly HttpClient _httpClient = new HttpClient();
        private string jwtToken = string.Empty;
        private List<Category> categories;
        private Subcategory? selectedAPI;

        public frmMain()
        {
            InitializeComponent();
            textBoxBaseUrl.Text = baseUrl;
            setInitialAuthRequest();
            _httpClient = new HttpClient();
            categories = Helper.BuildApiList();
            PopulateTreeView(categories, treeViewApis);
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
        private void setInitialAuthRequest()
        {
            var requestBody = new
            {
                SitePrefix = "BL60",
                ApiKey = "b1ab922f-4267-4fc3-ab67-ffe18e996b71"
            };
            txtAuthRequestBody.Text = requestBody.SerializeObjectToJson().FormatStringObjectToJson();
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            await executeApis();
        }

        private async Task executeApis()
        {
            progressBarLoading.Visible = true;
            buttonRun.Enabled = false;
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
                buttonRun.Enabled = true;
            }
            catch (Exception ex)
            {
                progressBarLoading.Visible = false;
                buttonRun.Enabled = true;
                MessageBox.Show("An error occurred: " + ex.Message);
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
                        response = await _httpClient.GetAsync($"{textBoxBaseUrl.Text}/{txtSelectedAPIUrl.Text}");
                        break;
                    case ApiMethodType.POST:
                        response = await _httpClient.PostAsync($"{textBoxBaseUrl.Text}/{txtSelectedAPIUrl.Text}", httpContent);
                        break;
                    case ApiMethodType.PUT:
                        response = await _httpClient.PutAsync($"{textBoxBaseUrl.Text}/{txtSelectedAPIUrl.Text}", httpContent);
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
                    HttpResponseMessage response = await _httpClient.PostAsync($"{textBoxBaseUrl.Text}/Auth", httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        dynamic jsonResponse = JsonConvert.DeserializeObject(result)!;
                        jwtToken = jsonResponse.token;
                    }
                    else
                    {
                        MessageBox.Show("Login Failed: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    progressBarLoading.Visible = false;
                    buttonRun.Enabled = true;
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
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
    }
}
