# IO.Swagger.Api.AuthorsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuthor**](AuthorsApi.md#getauthor) | **GET** /api/v1/authors/{authorId} | Get an author by his/her id
[**GetAuthors**](AuthorsApi.md#getauthors) | **GET** /api/v1/authors | Get a list of authors
[**UpdateAuthor**](AuthorsApi.md#updateauthor) | **PUT** /api/v1/authors/{authorId} | Update an author
[**UpdateAuthor_0**](AuthorsApi.md#updateauthor_0) | **PATCH** /api/v1/authors/{authorId} | Partially update an author

<a name="getauthor"></a>
# **GetAuthor**
> Author GetAuthor (Guid? authorId)

Get an author by his/her id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthorExample
    {
        public void main()
        {
            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author you want to get

            try
            {
                // Get an author by his/her id
                Author result = apiInstance.GetAuthor(authorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.GetAuthor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author you want to get | 

### Return type

[**Author**](Author.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getauthors"></a>
# **GetAuthors**
> List<Author> GetAuthors ()

Get a list of authors

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthorsExample
    {
        public void main()
        {
            var apiInstance = new AuthorsApi();

            try
            {
                // Get a list of authors
                List&lt;Author&gt; result = apiInstance.GetAuthors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.GetAuthors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Author>**](Author.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthor"></a>
# **UpdateAuthor**
> Author UpdateAuthor (Guid? authorId, AuthorForUpdate body = null)

Update an author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAuthorExample
    {
        public void main()
        {
            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author to update
            var body = new AuthorForUpdate(); // AuthorForUpdate |  (optional) 

            try
            {
                // Update an author
                Author result = apiInstance.UpdateAuthor(authorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.UpdateAuthor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author to update | 
 **body** | [**AuthorForUpdate**](AuthorForUpdate.md)|  | [optional] 

### Return type

[**Author**](Author.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthor_0"></a>
# **UpdateAuthor_0**
> Author UpdateAuthor_0 (Guid? authorId, List<Operation> body = null)

Partially update an author

Sample request (this request updates the author's **first name**)                              PATCH /authors/authorId              [                   {                      \"op\": \"replace\",                       \"path\": \"/firstname\",                       \"value\": \"new first name\"                   }               ]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAuthor_0Example
    {
        public void main()
        {
            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author you want to get
            var body = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Partially update an author
                Author result = apiInstance.UpdateAuthor_0(authorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.UpdateAuthor_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author you want to get | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)|  | [optional] 

### Return type

[**Author**](Author.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
