using Acquaint.Integrators.Api.Demo.Models;

namespace Acquaint.Integrators.Api.Demo.Utilities
{
    public class Helper
    {
        public static List<Category> BuildApiList()
        {
            return
            [
                new Category
                {
                    Name = "Contacts",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/Contacts/{id}", Name = "Get Contact by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Name = "Get List of Contacts",
                            Url = "/v1/Contacts/list",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"firstNames\": \"\",\r\n    \"lastName\": \"\",\r\n    \"companyName\": \"\",\r\n    \"email\": \"\",\r\n    \"telephone\": \"\",\r\n    \"mobile\": \"\",\r\n    \"altReference\": \"\",\r\n    \"type\": 0,\r\n    \"status\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                        new Subcategory{
                            Name = "Update Contact",
                            Url = "/v1/Contacts/{id}",
                            MethodType = ApiMethodType.PUT,
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Vendor",
                            Url = "/v1/Contacts/Vendor",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Landlord",
                            Url = "/v1/Contacts/Landlord",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Solicitor",
                            Url = "/v1/Contacts/Solicitor",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Sales Applicant",
                            Url = "/v1/Contacts/SalesApplicant",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Lettings Applicant",
                            Url = "/v1/Contacts/LettingsApplicant",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": false,\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Contact Sources",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/ContactSources/{id}", Name = "Get Contact Source by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactSources/list", 
                            Name = "Get List of Contact Sources", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
                    }
                },
                new Category
                {
                    Name = "Contact Statuses",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ContactStatuses/{id}", Name = "Get Contact Statuss by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactStatuses/list", 
                            Name = "Get List of Contact Statuses", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                    }
                },
                 new Category
                {
                    Name = "Contact Titles",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/ContactTitles/{id}", Name = "Get Contact Title by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactTitles/list", 
                            Name = "Get List of Contact Titles", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
                    }
                },
                new Category
                {
                    Name = "Contact Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ContactTypes/{id}", Name = "Get Contact Types by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/ContactTypes/list", 
                            Name= "Get List of Contact Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
                    }
                },
                new Category
                {
                    Name = "Management Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ManagementTypes/{id}", Name = "Get Management Type by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/ManagementTypes/list", 
                            Name = "Get List of Management Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
                    }
                },
                new Category
                {
                    Name = "Notes",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Notes/{id}", Name = "Get Note by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Notes/list",
                            Name = "Get  List of Notes",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,    \r\n    \"minUpdatedDate\": \"1900-01-01 \",\r\n    \"maxUpdatedDate\": \"1900-01-01 \",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes/{id}",
                            Name = "Update Note",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes",
                            Name = "Create Note",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Properties",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/Properties/{id}", Name = "Get Property by Id", MethodType= ApiMethodType.GET },
                        new Subcategory {
                            Name = "Get List of Properties",
                            Url ="/v1/Properties/list",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" \",\r\n    \"altReference\": \"\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 0,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 0,\r\n    \"maxPrice\": 0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Propertie Areas",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/PropertyAreas/{id}", Name = "Get Property Area by Id", MethodType= ApiMethodType.GET },
                        new Subcategory
                        {
                            Url = "/v1/PropertyAreas/list",
                            Name = "Get List of Property Areas",
                            MethodType= ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                       
                    }
                },
                new Category
                {
                    Name = "Property Offers",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/PropertyOffers/{id}", Name = "Get Property Offer by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url = "/v1/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers/{id}",
                            Name = "Update Property Offer",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers",
                            Name = "Create Property Offer",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Property Requirements",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/PropertyRequirements/{contactId}", Name= "Get Property Requirements by Contact Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Name = "Update Property Requirements by Contact Id",
                            Url = "/v1/PropertyRequirements/{contactId}",
                            MethodType= ApiMethodType.PUT,
                            RequestBody=$"{{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {{\r\n    \"isStudent\": false\r\n  }}\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Tax Bands",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/PropertyTaxBands/{id}", Name = "Get Property Tax Band by Id", MethodType = ApiMethodType.GET },
                        new Subcategory { 
                            Url = "/v1/PropertyTaxBands/list", 
                            Name = "Get List of Property Tax Bands", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                       
                    }
                },
                new Category
                {
                    Name = "Property Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/Propertytypes/{id}", Name = "Get Property Type by Id", MethodType= ApiMethodType.GET },
                        new Subcategory { 
                            Url = "/v1/Propertytypes/list", 
                            Name = "Get List of Property Types", 
                            MethodType= ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
                    }
                },
                new Category
                {
                    Name = "Sites",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Sites/{id}", Name = "Get Site by Id", MethodType= ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/Sites/list", 
                            Name = "Get List of Sites", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Tasks",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Tasks/{id}", Name = "Get Task by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"assignedUserId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minCompletedDate\": \"1900-01-01\",\r\n    \"maxCompletedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks/{id}",
                            Name = "Update Task",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks",
                            Name = "Create Task",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
                        },
                    }
                },

                new Category
                {
                    Name = "Task Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/TaskTypes/{id}", Name = "Get Task Type by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/TaskTypes/list", 
                            Name = "Get List of Task Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }                       
                    }
                },
                new Category
                {
                    Name = "Tenancies",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Tenancies/{id}", Name = "Get Tenancy by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"managementTypeId\": 0,\r\n    \"status\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minStartDate\": \"1900-01-01\",\r\n    \"maxStartDate\": \"1900-01-01\",\r\n    \"minEndDate\": \"1900-01-01\",\r\n    \"maxEndDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Users",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Users/{id}", Name = "Get User by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/Users/list", 
                            Name = "Get List of Users", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"siteId\": 0,\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                         
                    }
                 }
            ];
        }
    }
}
