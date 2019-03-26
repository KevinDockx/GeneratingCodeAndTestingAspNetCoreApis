# IO.Swagger.Api.BooksApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBook**](BooksApi.md#createbook) | **POST** /api/v1/authors/{authorId}/books | Create a book for a specific author
[**GetBook**](BooksApi.md#getbook) | **GET** /api/v1/authors/{authorId}/books/{bookId} | Get a book by id for a specific author
[**GetBooks**](BooksApi.md#getbooks) | **GET** /api/v1/authors/{authorId}/books | Get the books for a specific author

<a name="createbook"></a>
# **CreateBook**
> Book CreateBook (Guid? authorId, BookForCreation body = null)

Create a book for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBookExample
    {
        public void main()
        {
            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the book author
            var body = new BookForCreation(); // BookForCreation |  (optional) 

            try
            {
                // Create a book for a specific author
                Book result = apiInstance.CreateBook(authorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.CreateBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the book author | 
 **body** | [**BookForCreation**](BookForCreation.md)|  | [optional] 

### Return type

[**Book**](Book.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.marvin.bookforcreation+json, application/vnd.marvin.bookforcreationwithamountofpages+json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbook"></a>
# **GetBook**
> Book GetBook (Guid? authorId, Guid? bookId)

Get a book by id for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBookExample
    {
        public void main()
        {
            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the book author
            var bookId = new Guid?(); // Guid? | The id of the book

            try
            {
                // Get a book by id for a specific author
                Book result = apiInstance.GetBook(authorId, bookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.GetBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the book author | 
 **bookId** | [**Guid?**](Guid?.md)| The id of the book | 

### Return type

[**Book**](Book.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.marvin.book+json, application/json, application/xml, application/vnd.marvin.bookwithconcatenatedauthorname+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbooks"></a>
# **GetBooks**
> List<Book> GetBooks (Guid? authorId)

Get the books for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBooksExample
    {
        public void main()
        {
            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the book author

            try
            {
                // Get the books for a specific author
                List&lt;Book&gt; result = apiInstance.GetBooks(authorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.GetBooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the book author | 

### Return type

[**List<Book>**](Book.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
