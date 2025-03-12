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
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url ="/v1/Contacts/1", Name = "Get Contact By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url ="/v1/Contacts/{id}", Name = "Get Contact by Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
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
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                        new Subcategory{ Url ="/v1/Contacts/{id}", Name = "Get Contact by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Name = "Get List of Contacts",
                            Url = "/v1/Contacts/list",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"firstNames\": \"\",\r\n    \"lastName\": \"\",\r\n    \"companyName\": \"\",\r\n    \"email\": \"\",\r\n    \"telephone\": \"\",\r\n    \"mobile\": \"\",\r\n    \"altReference\": \"\",\r\n    \"type\": 0,\r\n    \"status\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                        new Subcategory{
                            Name = "Update Contact",
                            Url = "/v1/Contacts/{id}",
                            MethodType = ApiMethodType.Put,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Name = "Create Vendor",
                            Url = "/v1/Contacts/Vendor",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Name = "Create Landlord",
                            Url = "/v1/Contacts/Landlord",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Name = "Create Solicitor",
                            Url = "/v1/Contacts/Solicitor",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody=$"{{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Name = "Create Sales Applicant",
                            Url = "/v1/Contacts/SalesApplicant",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Name = "Create Lettings Applicant",
                            Url = "/v1/Contacts/LettingsApplicant",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": true,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": true,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": false,\r\n  \"firstNames\": \"\",\r\n  \"lastName\": \"\",\r\n  \"company\": \"\",\r\n  \"address\": {{\r\n    \"isHomeAddress\": false,\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"region\": \"\",\r\n    \"postcode\": \"\",\r\n    \"countryCode\": 0\r\n  }},\r\n  \"telephone\": \"\",\r\n  \"telephoneAlt\": \"\",\r\n  \"mobile\": \"\",\r\n  \"email\": \"\",\r\n  \"emailAlt\": \"\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"assignedUserId\": 0,\r\n  \"altReference\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        }
                    }
                },
                new Category
                {
                    Name = "Contact Sources",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url ="/v1/ContactSources/list", Name = "Get All Contact Sources", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactSources/1", Name = "Get Contact Source By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url ="/v1/ContactSources/{id}", Name = "Get Contact Source by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactSources/list",
                            Name = "Get List of Contact Sources",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url ="/v1/ContactSources/{id}", Name = "Get Contact Source by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactSources/list", 
                            Name = "Get List of Contact Sources", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Contact Statuses",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/ContactStatuses/1", Name = "Get Contact Statuss By Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactStatuses/list", Name = "Get All Contact Statuses", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/ContactStatuses/{id}", Name = "Get Contact Statuss by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactStatuses/list",
                            Name = "Get List of Contact Statuses",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/ContactStatuses/{id}", Name = "Get Contact Statuss by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactStatuses/list", 
                            Name = "Get List of Contact Statuses", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                 new Category
                {
                    Name = "Contact Titles",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url ="/v1/ContactTitles/list", Name = "Get All Contact Titles", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url ="/v1/ContactTitles/1", Name = "Get Contact Title By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url ="/v1/ContactTitles/{id}", Name = "Get Contact Title by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactTitles/list",
                            Name = "Get List of Contact Titles",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url ="/v1/ContactTitles/{id}", Name = "Get Contact Title by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url ="/v1/ContactTitles/list", 
                            Name = "Get List of Contact Titles", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Contact Types",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/ContactTypes/list", Name= "Get All Contact Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/ContactTypes/1", Name = "Get Contact Types By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/ContactTypes/{id}", Name = "Get Contact Types by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/ContactTypes/list",
                            Name= "Get List of Contact Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/ContactTypes/{id}", Name = "Get Contact Types by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/ContactTypes/list", 
                            Name= "Get List of Contact Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Management Types",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/ManagementTypes/list", Name = "Get All Management Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/ManagementTypes/1", Name = "Get Management Type By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/ManagementTypes/{id}", Name = "Get Management Type by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/ManagementTypes/list",
                            Name = "Get List of Management Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/ManagementTypes/{id}", Name = "Get Management Type by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/ManagementTypes/list", 
                            Name = "Get List of Management Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Notes",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/Notes/1", Name = "Get Note By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/Notes/{id}", Name = "Get Note by Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory{
                            Url ="/v1/Notes/list",
                            Name = "Get  List of Notes",
                            MethodType = ApiMethodType.GET,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 390,\r\n    \"propertyId\": null,    \r\n    \"minUpdatedDate\": null,\r\n    \"maxUpdatedDate\": \"2024-10-15T00:00:00\"   \r\n}}"
=======
                        new Subcategory{ Url = "/v1/Notes/{id}", Name = "Get Note by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Notes/list",
                            Name = "Get  List of Notes",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,    \r\n    \"minUpdatedDate\": \"1900-01-01 \",\r\n    \"maxUpdatedDate\": \"1900-01-01 \",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,    \r\n    \"minUpdatedDate\": \"1900-01-01 \",\r\n    \"maxUpdatedDate\": \"1900-01-01 \",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/Notes/{id}",
                            Name = "Update Note",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.PUT,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n        \"contactId\": 390,\r\n        \"propertyId\": 222,\r\n        \"subject\": \"Phond And Asked For The 2 Dorchester Bungalows\",\r\n        \"body\": \"Test...\"\r\n    }}"
=======
                            MethodType = ApiMethodType.Put,
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/Notes",
                            Name = "Create Note",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"\",\r\n  \"body\": \"\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                    }
                },
                new Category
                {
                    Name = "Properties",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory { Url = "/v1/Properties/1", Name = "Get Property By Id", MethodType= ApiMethodType.GET },
=======
                        new Subcategory { Url = "/v1/Properties/{id}", Name = "Get Property by Id", MethodType= ApiMethodType.Get },
>>>>>>> Stashed changes
=======
                        new Subcategory { Url = "/v1/Properties/{id}", Name = "Get Property by Id", MethodType= ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory {
                            Name = "Get List of Properties",
                            Url ="/v1/Properties/list",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.GET,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" oX10\",\r\n    \"altReference\": \"B231\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 3,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 110.0,\r\n    \"maxPrice\": 222220.0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"2022-04-03T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-04-03T00:00:00\"\r\n}}"
=======
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" \",\r\n    \"altReference\": \"\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 0,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 0,\r\n    \"maxPrice\": 0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" \",\r\n    \"altReference\": \"\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 0,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 0,\r\n    \"maxPrice\": 0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        }
                    }
                },
                new Category
                {
                    Name = "Propertie Areas",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory { Url = "/v1/PropertyAreas/list", Name = "Get All Property Areas", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/PropertyAreas/1", Name = "Get Property Area By Id", MethodType= ApiMethodType.GET },
=======
                        new Subcategory { Url = "/v1/PropertyAreas/{id}", Name = "Get Property Area by Id", MethodType= ApiMethodType.Get },
=======
                        new Subcategory { Url = "/v1/PropertyAreas/{id}", Name = "Get Property Area by Id", MethodType= ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory
                        {
                            Url = "/v1/PropertyAreas/list",
                            Name = "Get List of Property Areas",
<<<<<<< HEAD
                            MethodType= ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
                    }
                },
                new Category
                {
                    Name = "Property Details Sent Item",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory {
                            Url = "/v1/PropertyDetailsSentItem/list",
                            Name = "Get list of Propertie Details Sent Item",
                            MethodType= ApiMethodType.Get,
                            RequestBody = $"{{\r\n   \"contactIds\": 0,\r\n   \"propertyIds\": 0,\r\n   \"userId\": 0,\r\n   \"minAddedDate\": 0,\r\n   \"maxAddedDate\": 0,\r\n   \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Floor Plans",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/web",
                            Name = "Deletes the web optimized floor plan for a property",
                            MethodType= ApiMethodType.Delete
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/web",
                            Name = "Gets the web optimized floor plan for a property",
                            MethodType= ApiMethodType.Get
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/web",
                            Name = "Adds/Updates the web optimized floor plan for a property. The supported file types are .jpg, .jpeg, .gif, .tif, .pdf",
                            MethodType= ApiMethodType.Post,
                            isUploadFile = true,
                            SupportedFileTypes= "*.jpg;*.jpeg;*.gif;*.tif;*.pdf"
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/print",
                            Name = "Deletes the high quality floor plan for a property",
                            MethodType= ApiMethodType.Delete
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/print",
                            Name = "Gets the high quality floor plan for a property",
                            MethodType= ApiMethodType.Get
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/print",
                            Name = "Adds/Updates the high quality floor plan for a property. The supported file types are .jpg, .jpeg, .gif, .tif, .wmf",
                            MethodType= ApiMethodType.Post,
                            isUploadFile = true,
                            SupportedFileTypes= "*.jpg;*.jpeg;*.gif;*.tif;*.wmf"
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/web/metadata",
                            Name = "Gets the meta data of the web optimized floor plan of a property",
                            MethodType= ApiMethodType.Get
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/floorplans/print/metadata",
                            Name = "Gets the meta data of the high quality floor plan of a property",
                            MethodType= ApiMethodType.Get
                        }
>>>>>>> Stashed changes
=======
                            MethodType= ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                       
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Property Offers",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/PropertyOffers/2", Name = "Get Property Offer By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/PropertyOffers/{id}", Name = "Get Property Offer by Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory{
                            Url = "/v1/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.GET,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 2327,\r\n    \"propertyId\": 101,\r\n    \"minUpdatedDate\": \"2004-03-15T00:00:00\",\r\n    \"maxUpdatedDate\": \"2024-03-15T00:00:00\"\r\n}}"
=======
                        new Subcategory{ Url = "/v1/PropertyOffers/{id}", Name = "Get Property Offer by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers/{id}",
                            Name = "Update Property Offer",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.PUT,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
=======
                            MethodType = ApiMethodType.Put,
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers",
                            Name = "Create Property Offer",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"propertyId\": 35,\r\n    \"contactId\": 26073,\r\n    \"offerDate\": \"2002-11-26T00:00:00\",\r\n    \"amount\": 775000.00,\r\n    \"notes\": \"\",\r\n    \"statusId\": 2,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01T00:00:00\",\r\n    \"completionDate\": \"1900-01-01T00:00:00\"\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                    }
                },
                 new Category
                {
                    Name = "Property Pictures",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory {
                            Url = "/v1/Properties/{id}/pictures/{pictureId}",
                            Name = "Delete a picture from a property",
                            MethodType= ApiMethodType.Delete
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/pictures/{pictureId}",
                            Name = "Get a picture for a property",
                            MethodType= ApiMethodType.Get
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/pictures/{pictureId}",
                            Name = "Update a picture for a property",
                            MethodType= ApiMethodType.Put,
                            isUploadFile = true,
                            SupportedFileTypes= "*.jpg;*.jpeg;*.gif;*.tif;"
                        },
                        new Subcategory {
                            Url = "/v1/Properties/{id}/pictures",
                            Name = "Add a new picture to a property",
                            MethodType= ApiMethodType.Post,
                            isUploadFile = true,
                            SupportedFileTypes= "*.jpg;*.jpeg;*.gif;"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Requirements",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/PropertyRequirements/1", Name= "Get Poperty Requirements by Contact Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/PropertyRequirements/{contactId}", Name= "Get Property Requirements by Contact Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory{
                            Name = "Update Property Requirements by Contact Id",
                            Url = "/v1/PropertyRequirements/{contactId}",
                            MethodType= ApiMethodType.PUT,
<<<<<<< HEAD
                            RequestBody=$"{{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {{\r\n    \"isStudent\": true\r\n  }}\r\n}}"
=======
                        new Subcategory{ Url = "/v1/PropertyRequirements/{contactId}", Name= "Get Property Requirements by Contact Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Name = "Update Property Requirements by Contact Id",
                            Url = "/v1/PropertyRequirements/{contactId}",
                            MethodType= ApiMethodType.Put,
                            RequestBody=$"{{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {{\r\n    \"isStudent\": false\r\n  }}\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody=$"{{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {{\r\n    \"isStudent\": false\r\n  }}\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        }
                    }
                },
                new Category
                {
                    Name = "Property Tax Bands",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory { Url = "/v1/PropertyTaxBands/list", Name = "Get All Property Tax Bands", MethodType = ApiMethodType.GET },
                        new Subcategory { Url = "/v1/PropertyTaxBands/2", Name = "Get Property Tax Band By Id", MethodType = ApiMethodType.GET }
=======
                        new Subcategory { Url = "/v1/PropertyTaxBands/{id}", Name = "Get Property Tax Band by Id", MethodType = ApiMethodType.Get },
                        new Subcategory {
                            Url = "/v1/PropertyTaxBands/list",
                            Name = "Get List of Property Tax Bands",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory { Url = "/v1/PropertyTaxBands/{id}", Name = "Get Property Tax Band by Id", MethodType = ApiMethodType.GET },
                        new Subcategory { 
                            Url = "/v1/PropertyTaxBands/list", 
                            Name = "Get List of Property Tax Bands", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                       
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Property Types",
                    Subcategories = new List<Subcategory>
<<<<<<< HEAD
<<<<<<< Updated upstream
                    {                       
                        new Subcategory { Url = "/v1/Propertytypes/list", Name = "Get All Property Types", MethodType= ApiMethodType.GET },
                        new Subcategory { Url = "/v1/Propertytypes/1", Name = "Get Property Type By Id", MethodType= ApiMethodType.GET }
=======
                    {
                        new Subcategory { Url = "/v1/Propertytypes/{id}", Name = "Get Property Type by Id", MethodType= ApiMethodType.Get },
                        new Subcategory {
                            Url = "/v1/Propertytypes/list",
                            Name = "Get List of Property Types",
                            MethodType= ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                    {
                        new Subcategory { Url = "/v1/Propertytypes/{id}", Name = "Get Property Type by Id", MethodType= ApiMethodType.GET },
                        new Subcategory { 
                            Url = "/v1/Propertytypes/list", 
                            Name = "Get List of Property Types", 
                            MethodType= ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                        
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Sites",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/Sites/0", Name = "Get Site By Id", MethodType= ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/Sites/list", Name = "Get All Sites", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/Sites/{id}", Name = "Get Site by Id", MethodType= ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/Sites/list",
                            Name = "Get List of Sites",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/Sites/{id}", Name = "Get Site by Id", MethodType= ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/Sites/list", 
                            Name = "Get List of Sites", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Tasks",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/Tasks/1", Name = "Get Task By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/Tasks/{id}", Name = "Get Task by Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory{
                            Url ="/v1/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.GET,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": null,\r\n    \"propertyId\": 1103,\r\n    \"assignedUserId\": 1,\r\n    \"minUpdatedDate\": null,\r\n    \"maxUpdatedDate\": \"2024-10-15T00:00:00\",\r\n    \"minCompletedDate\": null,\r\n    \"maxCompletedDate\": null\r\n}}"
=======
                        new Subcategory{ Url = "/v1/Tasks/{id}", Name = "Get Task by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"assignedUserId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minCompletedDate\": \"1900-01-01\",\r\n    \"maxCompletedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"assignedUserId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minCompletedDate\": \"1900-01-01\",\r\n    \"maxCompletedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/Tasks/{id}",
                            Name = "Update Task",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.PUT,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
=======
                            MethodType = ApiMethodType.Put,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                        new Subcategory{
                            Url ="/v1/Tasks",
                            Name = "Create Task",
<<<<<<< Updated upstream
                            MethodType = ApiMethodType.POST,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 393,\r\n    \"propertyId\": 12,\r\n    \"subject\": \"Call Re: Valuation 2\",\r\n    \"body\": \"Interested in 30 Brentford Close but not on market yet.\",\r\n    \"taskTypeId\": 3,\r\n    \"priority\": 3,\r\n    \"startDate\": \"2012-11-15T00:00:00\",\r\n    \"dueDate\": \"2012-11-15T00:00:00\",\r\n    \"completedDate\": \"2017-11-15T13:25:42\",        \r\n    \"assignedToUserId\": 11080\r\n}}"
=======
                            MethodType = ApiMethodType.Post,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"subject\": \"\",\r\n    \"body\": \"\",\r\n    \"taskTypeId\": 0,\r\n    \"priority\": 0,\r\n    \"startDate\": \"1900-01-01\",\r\n    \"dueDate\": \"1900-01-01\",\r\n    \"completedDate\": \"1900-01-01\",        \r\n    \"assignedToUserId\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        },
                    }
                },

                new Category
                {
                    Name = "Task Types",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/TaskTypes/list", Name = "Get All Task Types", MethodType = ApiMethodType.GET },
                        new Subcategory{ Url = "/v1/TaskTypes/1", Name = "Get Task Type By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/TaskTypes/{id}", Name = "Get Task Type by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/TaskTypes/list",
                            Name = "Get List of Task Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/TaskTypes/{id}", Name = "Get Task Type by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/TaskTypes/list", 
                            Name = "Get List of Task Types", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        }                       
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                },
                new Category
                {
                    Name = "Tenancies",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/Tenancies/1", Name = "Get Tenancy By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/Tenancies/{id}", Name = "Get Tenancy by Id", MethodType = ApiMethodType.GET },
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        new Subcategory{
                            Url ="/v1/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.GET,
<<<<<<< HEAD
                            RequestBody = $"{{\r\n    \"contactId\": 1,\r\n    \"propertyId\": 1,\r\n    \"managementTypeId\": 1,\r\n    \"status\": 9,\r\n    \"minUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"maxUpdatedDate\": \"2023-05-03T09:19:38\",\r\n    \"minStartDate\": \"2015-04-30T00:00:00\",\r\n    \"maxStartDate\": \"2015-04-30T00:00:00\",\r\n    \"minEndDate\": \"2023-04-29T00:00:00\",\r\n    \"maxEndDate\": \"2023-04-29T00:00:00\"\r\n}}"
=======
                        new Subcategory{ Url = "/v1/Tenancies/{id}", Name = "Get Tenancy by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"managementTypeId\": 0,\r\n    \"status\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minStartDate\": \"1900-01-01\",\r\n    \"maxStartDate\": \"1900-01-01\",\r\n    \"minEndDate\": \"1900-01-01\",\r\n    \"maxEndDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> Stashed changes
=======
                            RequestBody = $"{{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"managementTypeId\": 0,\r\n    \"status\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minStartDate\": \"1900-01-01\",\r\n    \"maxStartDate\": \"1900-01-01\",\r\n    \"minEndDate\": \"1900-01-01\",\r\n    \"maxEndDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                        }
                    }
                },
                new Category
                {
                    Name = "Users",
                    Subcategories = new List<Subcategory>
                    {
<<<<<<< HEAD
<<<<<<< Updated upstream
                        new Subcategory{ Url = "/v1/Users/list", Name = "Get All Users", MethodType = ApiMethodType.GET },
                         new Subcategory{ Url = "/v1/Users/1", Name = "Get User By Id", MethodType = ApiMethodType.GET },
=======
                        new Subcategory{ Url = "/v1/Users/{id}", Name = "Get User by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/Users/list",
                            Name = "Get List of Users",
                            MethodType = ApiMethodType.Get,
                            RequestBody = $"{{\r\n    \"siteId\": 0,\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },
>>>>>>> Stashed changes
=======
                        new Subcategory{ Url = "/v1/Users/{id}", Name = "Get User by Id", MethodType = ApiMethodType.GET },
                        new Subcategory{ 
                            Url = "/v1/Users/list", 
                            Name = "Get List of Users", 
                            MethodType = ApiMethodType.GET,
                            RequestBody = $"{{\r\n    \"siteId\": 0,\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}}"
                        },                         
>>>>>>> 981e7c6af3eed711e8f1b724751cec0af82e9db5
                    }
                 }
            ];
        }
    }
}
