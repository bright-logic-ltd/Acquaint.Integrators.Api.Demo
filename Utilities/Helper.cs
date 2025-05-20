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
                    Name = "Appointments",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/Appointments/{id}", Name = "Get appointment by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Appointments/{id}",
                            Name = "Update appointment by Id",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n  \"startDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"endDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"appointmentTypeId\": 0,\r\n  \"confirmed\": true,\r\n  \"cancelled\": true,\r\n  \"noShow\": true,\r\n  \"notes\": \"string\",\r\n  \"properties\": [\r\n    0\r\n  ],\r\n  \"attendees\": [\r\n    0\r\n  ],\r\n  \"assignedUserId\": 0,\r\n  \"siteId\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Appointments/list",
                            Name = "Get list of appointments",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n  \"contactId\": -99,\r\n  \"propertyId\": -99,\r\n  \"appointmentTypeId\": 0,\r\n  \"appointmentTypeGroupId\": 0,\r\n  \"siteId\": 0,\r\n  \"minUpdatedDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"maxUpdatedDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"assignedUserId\": 0,\r\n  \"propertyCategory\": 99,\r\n  \"currentPage\": 0,\r\n  \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Appointments",
                            Name = "Create an appointment",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n  \"startDate\": \"2025-04-09T10:59:24.049Z\",\r\n  \"endDate\": \"2025-04-09T10:59:24.049Z\",\r\n  \"appointmentTypeId\": 0,\r\n  \"confirmed\": true,\r\n  \"cancelled\": true,\r\n  \"noShow\": true,\r\n  \"notes\": \"string\",\r\n  \"properties\": [\r\n    0\r\n  ],\r\n  \"attendees\": [\r\n    0\r\n  ],\r\n  \"assignedUserId\": 0,\r\n  \"siteId\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Appointment Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/AppointmentTypes/{id}", Name = "Get an Appointment Types by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/AppointmentTypes/list",
                            Name = "Get List of Appointment Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"appointmentTypeGroupId\": 0,\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Certificates",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/Certificates/{id}", Name = "Get a Certificates by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Certificates/{id}",
                            Name = "Update Certificate by Id",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"issuerId\": 0,\r\n  \"certificateTypeId\": 0,\r\n  \"status\": 0,\r\n  \"startDate\": \"2025-04-09T10:59:24.058Z\",\r\n  \"endDate\": \"2025-04-09T10:59:24.058Z\",\r\n  \"reference\": \"string\"\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Certificates/list",
                            Name = "Get List of Certificates",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n  \"contactId\": -99,\r\n  \"propertyId\": -99,\r\n  \"siteId\": 0,\r\n  \"issuerId\": 0,\r\n  \"status\": 0,\r\n  \"minStartDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"maxStartDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"minEndDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"maxEndDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"minUpdatedDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"maxUpdatedDate\": \"2025-04-09T10:59:24.043Z\",\r\n  \"currentPage\": 0,\r\n  \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Certificates",
                            Name = "Create a Certificate",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"issuerId\": 0,\r\n  \"certificateTypeId\": 0,\r\n  \"status\": 0,\r\n  \"startDate\": \"2025-04-09T10:59:24.064Z\",\r\n  \"endDate\": \"2025-04-09T10:59:24.064Z\",\r\n  \"reference\": \"string\"\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Certificate Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/CertificateTypes/{id}", Name = "Get a Certificate Type by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/CertificateTypes/list",
                            Name = "Get List of Certificate Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n  \"currentPage\": 0,\r\n  \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Contact Property Requirements",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/ContactPropertyRequirements/{contactId}", Name = "Get a Contact Property Requirements by contact Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactPropertyRequirements/{contactId}",
                            Name = "Update Contact Property Requirements by contact Id",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {\r\n    \"isStudent\": true\r\n  }\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Contacts",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/Contacts/{id}", Name = "Get Contact by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Name = "Get List of Contacts",
                            Url = "/v1/Contacts/list",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"firstNames\": \"\",\r\n    \"lastName\": \"\",\r\n    \"companyName\": \"\",\r\n    \"email\": \"\",\r\n    \"telephone\": \"\",\r\n    \"mobile\": \"\",\r\n    \"altReference\": \"\",\r\n    \"type\": 0,\r\n    \"status\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Update Contact",
                            Url = "/v1/Contacts/{id}",
                            MethodType = ApiMethodType.Put,
                            RequestBody="{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"statusId\": 0,\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Create Vendor",
                            Url = "/v1/Contacts/Vendor",
                            MethodType = ApiMethodType.Post,
                            RequestBody="{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Create Landlord",
                            Url = "/v1/Contacts/Landlord",
                            MethodType = ApiMethodType.Post,
                            RequestBody="{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Create Solicitor",
                            Url = "/v1/Contacts/Solicitor",
                            MethodType = ApiMethodType.Post,
                            RequestBody="{\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Create Sales Applicant",
                            Url = "/v1/Contacts/SalesApplicant",
                            MethodType = ApiMethodType.Post,
                            RequestBody="{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        },
                        new Subcategory{
                            Name = "Create Lettings Applicant",
                            Url = "/v1/Contacts/LettingsApplicant",
                            MethodType = ApiMethodType.Post,
                            RequestBody="{\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"isStudent\": true,\r\n  \"firstNames\": \"string\",\r\n  \"lastName\": \"string\",\r\n  \"company\": \"string\",\r\n  \"address\": {\r\n    \"isHomeAddress\": true,\r\n    \"propertyName\": \"string\",\r\n    \"street\": \"string\",\r\n    \"locality\": \"string\",\r\n    \"town\": \"string\",\r\n    \"region\": \"string\",\r\n    \"postcode\": \"string\",\r\n    \"countryCode\": 0\r\n  },\r\n  \"telephone\": \"string\",\r\n  \"telephoneAlt\": \"string\",\r\n  \"mobile\": \"string\",\r\n  \"email\": \"string\",\r\n  \"emailAlt\": \"string\",\r\n  \"titleId\": 0,\r\n  \"sourceId\": 0,\r\n  \"siteId\": 0,\r\n  \"altReference\": \"string\",\r\n  \"assignedUserId\": 0,\r\n  \"linkedTo\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Contact Sources",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/ContactSources/{id}", Name = "Get Contact Source by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactSources/list",
                            Name = "Get List of Contact Sources",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Contact Statuses",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ContactStatuses/{id}", Name = "Get Contact Statuss by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactStatuses/list",
                            Name = "Get List of Contact Statuses",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                 new Category
                {
                    Name = "Contact Titles",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url ="/v1/ContactTitles/{id}", Name = "Get Contact Title by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/ContactTitles/list",
                            Name = "Get List of Contact Titles",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Contact Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ContactTypes/{id}", Name = "Get Contact Types by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/ContactTypes/list",
                            Name= "Get List of Contact Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Documents",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Documents/{id}", Name = "Retrieves the file of a document record by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/Documents/list",
                            Name= "Get List of Documents",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"certificateId\": 0,\r\n    \"templateId\": 0,\r\n    \"minAddedDate\": \"2025-04-09T10:59:24.064Z\",\r\n    \"maxAddedDate\": \"2025-04-09T10:59:24.064Z\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url = "/v1/Documents",
                            Name= "Create a new document from the passed file contents",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"certificateId\": 0,\r\n    \"templateId\": 0,\r\n}",
                            isUploadFile = true,
                            SupportedFileTypes= "*",
                            IsFromUri = true
                        }
                    }
                },
                new Category
                {
                    Name = "Document Templates",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/DocumentTemplates/{id}", Name = "Retrieves a document template by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/DocumentTemplates/list",
                            Name= "Get List of Document Template",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Management Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/ManagementTypes/{id}", Name = "Get Management Type by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/ManagementTypes/list",
                            Name = "Get List of Management Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Notes",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Notes/{id}", Name = "Get Note by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Notes/list",
                            Name = "Get  List of Notes",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,    \r\n    \"minUpdatedDate\": \"1900-01-01 \",\r\n    \"maxUpdatedDate\": \"1900-01-01 \",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes/{id}",
                            Name = "Update Note",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"string\",\r\n  \"body\": \"string\",\r\n  \"alwaysShowAtTop\": true,\r\n  \"desktopAlert\": true\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Notes",
                            Name = "Create Note",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"string\",\r\n  \"body\": \"string\",\r\n  \"alwaysShowAtTop\": true,\r\n  \"desktopAlert\": true\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Properties",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/Properties/{id}", Name = "Get Property by Id", MethodType= ApiMethodType.Get },
                         new Subcategory {
                            Name = "Update Properties",
                            Url ="/v1/Properties/list",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" \",\r\n    \"altReference\": \"\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 0,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 0,\r\n    \"maxPrice\": 0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory {
                            Name = "Get List Of Properties",
                            Url ="/v1/Properties/list",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"propertyName\": \"\",\r\n    \"street\": \"\",\r\n    \"locality\": \"\",\r\n    \"town\": \"\",\r\n    \"postcode\": \" \",\r\n    \"altReference\": \"\",\r\n    \"contactId\": 0,\r\n    \"categoryId\": 0,\r\n    \"statusId\": 0,\r\n    \"tenureId\": 0,\r\n    \"propertyAreaId\": 0,\r\n    \"minPrice\": 0,\r\n    \"maxPrice\": 0,\r\n    \"bedrooms\": 0,\r\n    \"siteId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Propertie Areas",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/PropertyAreas/{id}", Name = "Get Property Area by Id", MethodType= ApiMethodType.Get },
                        new Subcategory
                        {
                            Url = "/v1/PropertyAreas/list",
                            Name = "Get List of Property Areas",
                            MethodType= ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
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
                            RequestBody = "{\r\n   \"contactIds\": 0,\r\n   \"propertyIds\": 0,\r\n   \"userId\": 0,\r\n   \"minAddedDate\": 0,\r\n   \"maxAddedDate\": 0,\r\n   \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Feedback",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory {
                            Url = "/v1/Properties/{propertyId}/Feedback/{contactId}",
                            Name = "Add/Update feedback to a property for a contact",
                            MethodType= ApiMethodType.Post,
                            RequestBody = "{\r\n  \"feedbackDate\": \"2025-04-16T10:11:03.004Z\",\r\n  \"response\": 0,\r\n  \"notes\": \"string\",\r\n  \"locationRating\": 0,\r\n  \"conditionRating\": 0,\r\n  \"priceRating\": 0\r\n}"
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
                            SupportedFileTypes= "*.png;*.jpg;*.jpeg;*.gif;*.tif;*.pdf"
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
                            SupportedFileTypes= "*.png;*.jpg;*.jpeg;*.gif;*.tif;*.wmf"
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
                    }
                },
                new Category
                {
                    Name = "Property Offers",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/PropertyOffers/{id}", Name = "Get Property Offer by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/PropertyOffers/list",
                            Name = "Get List of Property Offers",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers/1",
                            Name = "Update Property Offer",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/PropertyOffers",
                            Name = "Create Property Offer",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n    \"propertyId\": 0,\r\n    \"contactId\": 0,\r\n    \"offerDate\": \"1900-01-01\",\r\n    \"amount\": 0,\r\n    \"notes\": \"\",\r\n    \"statusId\": 0,\r\n    \"solicitorId\": 0,\r\n    \"exchangedContracts\": \"1900-01-01\",\r\n    \"completionDate\": \"1900-01-01\"\r\n}"
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
                        new Subcategory{ Url = "/v1/PropertyRequirements/{contactId}", Name= "Get Property Requirements by Contact Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Name = "Update Property Requirements by Contact Id",
                            Url = "/v1/PropertyRequirements/{contactId}",
                            MethodType= ApiMethodType.Put,
                            RequestBody="{\r\n  \"category\": 0,\r\n  \"usage\": 0,\r\n  \"minPrice\": 0,\r\n  \"maxPrice\": 0,\r\n  \"minBedrooms\": 0,\r\n  \"lettingsPropertyRequirements\": {\r\n    \"isStudent\": false\r\n  }\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Property Tax Bands",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/PropertyTaxBands/{id}", Name = "Get Property Tax Band by Id", MethodType = ApiMethodType.Get },
                        new Subcategory {
                            Url = "/v1/PropertyTaxBands/list",
                            Name = "Get List of Property Tax Bands",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Property Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory { Url = "/v1/Propertytypes/{id}", Name = "Get Property Type by Id", MethodType= ApiMethodType.Get },
                        new Subcategory {
                            Url = "/v1/Propertytypes/list",
                            Name = "Get List of Property Types",
                            MethodType= ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Sites",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Sites/{id}", Name = "Get Site by Id", MethodType= ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/Sites/list",
                            Name = "Get List of Sites",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                },
                new Category
                {
                    Name = "Tasks",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Tasks/{id}", Name = "Get Task by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Tasks/list",
                            Name = "Get  List of Tasks",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"assignedUserId\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minCompletedDate\": \"1900-01-01\",\r\n    \"maxCompletedDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks/67128",
                            Name = "Update Task",
                            MethodType = ApiMethodType.Put,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"string\",\r\n  \"body\": \"string\",\r\n  \"taskTypeId\": 0,\r\n  \"priority\": 0,\r\n  \"alwaysShowAtTop\": true,\r\n  \"startDate\": \"2025-04-16T10:11:03.023Z\",\r\n  \"dueDate\": \"2025-04-16T10:11:03.023Z\",\r\n  \"completedDate\": \"2025-04-16T10:11:03.023Z\",\r\n  \"assignedUserId\": 0,\r\n  \"desktopAlert\": true\r\n}"
                        },
                        new Subcategory{
                            Url ="/v1/Tasks",
                            Name = "Create Task",
                            MethodType = ApiMethodType.Post,
                            RequestBody = "{\r\n  \"contactId\": 0,\r\n  \"propertyId\": 0,\r\n  \"subject\": \"string\",\r\n  \"body\": \"string\",\r\n  \"taskTypeId\": 0,\r\n  \"priority\": 0,\r\n  \"alwaysShowAtTop\": true,\r\n  \"startDate\": \"2025-04-16T10:11:03.026Z\",\r\n  \"dueDate\": \"2025-04-16T10:11:03.026Z\",\r\n  \"completedDate\": \"2025-04-16T10:11:03.026Z\",\r\n  \"assignedUserId\": 0,\r\n  \"desktopAlert\": true\r\n}"
                        },
                    }
                },

                new Category
                {
                    Name = "Task Types",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/TaskTypes/{id}", Name = "Get Task Type by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/TaskTypes/list",
                            Name = "Get List of Task Types",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Tenancies",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Tenancies/{id}", Name = "Get Tenancy by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url ="/v1/Tenancies/list",
                            Name = "Get List of Tenancies",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"contactId\": 0,\r\n    \"propertyId\": 0,\r\n    \"managementTypeId\": 0,\r\n    \"status\": 0,\r\n    \"minUpdatedDate\": \"1900-01-01\",\r\n    \"maxUpdatedDate\": \"1900-01-01\",\r\n    \"minStartDate\": \"1900-01-01\",\r\n    \"maxStartDate\": \"1900-01-01\",\r\n    \"minEndDate\": \"1900-01-01\",\r\n    \"maxEndDate\": \"1900-01-01\",\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        }
                    }
                },
                new Category
                {
                    Name = "Users",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory{ Url = "/v1/Users/{id}", Name = "Get User by Id", MethodType = ApiMethodType.Get },
                        new Subcategory{
                            Url = "/v1/Users/list",
                            Name = "Get List of Users",
                            MethodType = ApiMethodType.Get,
                            RequestBody = "{\r\n    \"siteId\": 0,\r\n    \"currentPage\": 0,\r\n    \"pageSize\": 0\r\n}"
                        },
                    }
                 }
            ];
        }
    }
}