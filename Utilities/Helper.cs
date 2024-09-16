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
                        new Subcategory{ Url = "/ContactTypes/list", Name= "Get All Contact Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/ContactTypes/1045", Name = "Get Contact Types By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/ContactStatuses/list", Name = "Get All Contact Statuses", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/ContactTitles/list", Name = "Get All Contact Titles", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/ContactTitles/1", Name = "Get Contact Title By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/ContactSources/list", Name = "Get All Contact Sources", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/ContactSources/1", Name = "Get Contact Source By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/Contacts/1", Name = "Get Contact By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Name = "Get List of Contacts",
                            Url = "/Contacts/list",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"firstNames\": \"\",\r\n    \"lastName\": \"\",\r\n    \"companyName\": \"\",\r\n    \"email\": \"test23083@brightlogic.co.uk\",\r\n    \"telephone\": \"\",\r\n    \"mobile\": \"\",\r\n    \"altReference\": \"\",\r\n    \"type\": 1,\r\n    \"status\": 1,\r\n    \"minUpdatedDate\": \"2017-02-06T11:36:11\",\r\n    \"maxUpdatedDate\": \"2023-02-06T11:36:11\"\r\n}}"
                        },
                        new Subcategory{
                            Name = "Update Contact",
                            Url = "/Contacts/1",
                            MethodType = ApiMethodType.PUT,
                            RequestBody=$"{{\r\n    \"firstNames\": \"Alexander\",\r\n    \"lastName\": \"Johnson\",\r\n    \"company\": \"Web Estate Agents\",\r\n    \"address\": {{\r\n        \"propertyName\": \"\",\r\n        \"street\": \"\",\r\n        \"locality\": \"\",\r\n        \"town\": \"Mirfield\",\r\n        \"region\": \"West Yorkshire\",\r\n        \"postcode\": \"\",\r\n        \"countryCode\": 826,\r\n        \"isHomeAddress\": true\r\n    }},\r\n    \"telephone\": \"0141 277 1068\",\r\n    \"telephoneAlt\": \"07622879897\",\r\n    \"mobile\": \"07708 055005\",\r\n    \"email\": \"test@brightlogic.co.uk\",\r\n    \"emailAlt\": \"test25966@brightlogic.co.uk\",\r\n    \"typeId\": 3,\r\n    \"statusId\": 1007,\r\n    \"sourceId\": 1026,\r\n    \"titleId\": 1002,\r\n    \"altReference\": \"\"\r\n}}"
                        },
                            new Subcategory{
                            Name = "Create Contact",
                            Url = "/Contacts",
                            MethodType = ApiMethodType.POST,
                            RequestBody=$"{{\r\n    \"firstNames\": \"Scott\",\r\n    \"lastName\": \"Smith\",\r\n    \"company\": \"A. Peters & CO.\",\r\n    \"address\": {{\r\n        \"propertyName\": \"\",\r\n        \"street\": \"\",\r\n        \"locality\": \"\",\r\n        \"town\": \"Mirfield\",\r\n        \"region\": \"West Yorkshire\",\r\n        \"postcode\": \"\",\r\n        \"countryCode\": 826,\r\n        \"isHomeAddress\": true\r\n    }},\r\n    \"telephone\": \"0141 277 1068\",\r\n    \"telephoneAlt\": \"07622879897\",\r\n    \"mobile\": \"07708 055005\",\r\n    \"email\": \"test@brightlogic.co.uk\",\r\n    \"emailAlt\": \"test25966@brightlogic.co.uk\",\r\n    \"typeId\": 12,\r\n    \"statusId\": 2,\r\n    \"titleId\": 10,\r\n    \"sourceId\": 1,\r\n    \"altReference\": \"\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Properties",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/PropertyTaxBands/list", Name = "Get All Property Tax Bands", MethodType = ApiMethodType.GET },
                        new Subcategory { Url = "/PropertyTaxBands/2", Name = "Get Property Tax Band By Id", MethodType = ApiMethodType.GET },
                        new Subcategory { Url = "/Propertytypes/list", Name = "Get All Property Types", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/Propertytypes/1", Name = "Get Property Type By Id", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/PropertyAreas/list", Name = "Get All Property Areas", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/PropertyAreas/1", Name = "Get Property Area By Id", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/Properties/1", Name = "Get Property By Id", MethodType= ApiMethodType.GET },
                        new Subcategory {
                            Name = "Get List Of Properties",
                            Url ="/Properties/list",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" oX10\",\r\n    \"altReference\": \"B231\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 3,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 110.0,\r\n    \"maxPrice\": 222220.0,\r\n    \"bedrooms\": 0,\r\n    \"minUpdatedDate\": \"2022-04-03T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-04-03T00:00:00\"\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Offers",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/PropertyOffers/2", Name = "Get Property Offer By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url = "/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 2327,\r\n    \"propertyId\": 101,\r\n    \"minUpdatedDate\": \"2004-03-15T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-03-15T00:00:00\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/PropertyOffers/1",
                            Name = "Update Property Offer",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/PropertyOffers",
                            Name = "Create Property Offer",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Tasks",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/TaskTypes/list", Name = "Get All Task Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/TaskTypes/1", Name = "Get Task Type By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/Tasks/1", Name = "Get Task By Id", MethodType = ApiMethodType.GET },
                            new Subcategory{
                            Url ="/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 10,\r\n    \"minUpdatedDate\": \"2004-03-15T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-10-15T00:00:00\"\r\n}}"
                        },
                        new Subcategory{
                            Url ="/Tasks/67128",
                            Name = "Update Task",
                            MethodType = ApiMethodType.PUT,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
                        },
                        new Subcategory{
                            Url ="/Tasks",
                            Name = "Create Task",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Tenancies",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/ManagementTypes/list", Name = "Get All Management Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/ManagementTypes/1", Name = "Get Management Type By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/Tenancies/1000", Name = "Get Tenancy By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{
                            Url ="/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.POST,
                            RequestBody = $"{{\r\n    \"contactId\": 22700,\r\n    \"propertyId\": 3869,\r\n    \"managementTypeId\": 1,\r\n    \"status\": 9,\r\n    \"minUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"maxUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"minStartDate\": \"2015-04-30T00:00:00\",\r\n    \"maxStartDate\": \"2015-04-30T00:00:00\",\r\n    \"minEndDate\": \"2023-04-29T00:00:00\",\r\n    \"maxEndDate\": \"2023-04-29T00:00:00\"\r\n}}"
                        }
                    }
                }
            ];
        }
    }
}
