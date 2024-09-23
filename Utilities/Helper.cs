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
                        new Subcategory{ Url = "/v1/ContactTypes/list", Name= "Get All Contact Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/ContactTypes/1", Name = "Get Contact Types By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactStatuses/list", Name = "Get All Contact Statuses", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactTitles/list", Name = "Get All Contact Titles", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactTitles/1", Name = "Get Contact Title By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactSources/list", Name = "Get All Contact Sources", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactSources/1", Name = "Get Contact Source By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/Contacts/1", Name = "Get Contact By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Name = "Get List of Contacts",
                            Url = "/v1/Contacts/list",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"firstNames\": \"\",\r\n    \"lastName\": \"\",\r\n    \"companyName\": \"\",\r\n    \"email\": \"\",\r\n    \"telephone\": \"\",\r\n    \"mobile\": \"\",\r\n    \"altReference\": \"\",\r\n    \"type\": 1,\r\n    \"status\": 1,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"2017-02-06T11:36:11\",\r\n    \"maxUpdatedDate\": \"2023-02-06T11:36:11\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Update Contact",
                            Url = "/v1/Contacts/1",
                            MethodType = ApiMethodType.PUT,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Vendor",
                            Url = "/v1/Contacts/Vendor",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Landlord",
                            Url = "/v1/Contacts/Landlord",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Solicitor",
                            Url = "/v1/Contacts/Solicitor",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Sales Applicant",
                            Url = "/v1/Contacts/SalesApplicant",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Create Lettings Applicant",
                            Url = "/v1/Contacts/LettingsApplicant",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": true,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Notes",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Notes/1", Name = "Get Note By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Notes/list",
                            Name = "Get  List of Notes",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 390,\r\n    \"propertyId\": null,    \r\n    \"minUpdatedDate\": null,\r\n    \"maxUpdatedDate\": \"2024-10-15T00:00:00\"   \r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes/1",
                            Name = "Update Note",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n        \"contactId\": 390,\r\n        \"propertyId\": 222,\r\n        \"subject\": \"Phond And Asked For The 2 Dorchester Bungalows\",\r\n        \"body\": \"Test...\"\r\n    }}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes",
                            Name = "Create Note",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Properties",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/PropertyTaxBands/list", Name = "Get All Property Tax Bands", MethodType = ApiMethodType.GET },
                        new Subcategory { Url = "/v1/PropertyTaxBands/2", Name = "Get Property Tax Band By Id", MethodType = ApiMethodType.GET },
                        new Subcategory { Url = "/v1/Propertytypes/list", Name = "Get All Property Types", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/Propertytypes/1", Name = "Get Property Type By Id", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/PropertyAreas/list", Name = "Get All Property Areas", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/PropertyAreas/1", Name = "Get Property Area By Id", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/Properties/1", Name = "Get Property By Id", MethodType= ApiMethodType.GET },
                        new Subcategory {
                            Name = "Get List Of Properties",
                            Url ="/v1/Properties/list",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" oX10\",\r\n    \"altReference\": \"B231\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 3,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 110.0,\r\n    \"maxPrice\": 222220.0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"2022-04-03T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-04-03T00:00:00\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Offers",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/PropertyOffers/2", Name = "Get Property Offer By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url = "/v1/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 2327,\r\n    \"propertyId\": 101,\r\n    \"minUpdatedDate\": \"2004-03-15T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-03-15T00:00:00\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers/1",
                            Name = "Update Property Offer",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers",
                            Name = "Create Property Offer",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Sites",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Sites/0", Name = "Get Site By Id", MethodType= ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/Sites/list", Name = "Get All Sites", MethodType = ApiMethodType.GET },
                    }
                },
                new Category
                {
                    Name = "Tasks",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/TaskTypes/list", Name = "Get All Task Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/TaskTypes/1", Name = "Get Task Type By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/Tasks/1", Name = "Get Task By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": null,\r\n    \"propertyId\": 1103,\r\n    \"assignedUserId\": 1,\r\n    \"minUpdatedDate\": null,\r\n    \"maxUpdatedDate\": \"2024-10-15T00:00:00\",\r\n    \"minCompletedDate\": null,\r\n    \"maxCompletedDate\": null\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks/67128",
                            Name = "Update Task",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks",
                            Name = "Create Task",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Tenancies",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ManagementTypes/list", Name = "Get All Management Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/ManagementTypes/1", Name = "Get Management Type By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/Tenancies/1", Name = "Get Tenancy By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/v1/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"contactId\": 1,\r\n    \"propertyId\": 1,\r\n    \"managementTypeId\": 1,\r\n    \"status\": 9,\r\n    \"minUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"maxUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"minStartDate\": \"2015-04-30T00:00:00\",\r\n    \"maxStartDate\": \"2015-04-30T00:00:00\",\r\n    \"minEndDate\": \"2023-04-29T00:00:00\",\r\n    \"maxEndDate\": \"2023-04-29T00:00:00\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Users",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Users/list", Name = "Get All Users", MethodType = ApiMethodType.GET },
                    }
                 }
            ];
        }
    }
}
