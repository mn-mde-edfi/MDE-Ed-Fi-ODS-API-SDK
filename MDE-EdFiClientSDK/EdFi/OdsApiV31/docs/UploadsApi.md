# EdFi.OdsApi.Sdk.Apis.Bulk.UploadsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/Bulk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostChunk**](UploadsApi.md#postchunk) | **POST** /uploads/{uploadid}/chunk | Allows for the upload of files parts of a larger upload file.
[**PostCommit**](UploadsApi.md#postcommit) | **POST** /uploads/{uploadId}/commit | Creates a Command to commit the uploaded chunks and validate the file appears composable.


<a name="postchunk"></a>
# **PostChunk**
> string PostChunk (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk)

Allows for the upload of files parts of a larger upload file.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Bulk;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Bulk;

namespace Example
{
    public class PostChunkExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UploadsApi();
            var uploadid = uploadid_example;  // string | uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API
            var offset = 789;  // long? | The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.
            var size = 789;  // long? | The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes
            var uploadChunk = new System.IO.Stream(); // System.IO.Stream | The chunk to be uploaded.

            try
            {
                // Allows for the upload of files parts of a larger upload file.
                string result = apiInstance.PostChunk(uploadid, offset, size, uploadChunk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostChunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadid** | **string**| uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API | 
 **offset** | **long?**| The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent. | 
 **size** | **long?**| The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes | 
 **uploadChunk** | **System.IO.Stream**| The chunk to be uploaded. | 

### Return type

**string**

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: text/plain; charset=utf-8, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcommit"></a>
# **PostCommit**
> string PostCommit (string uploadId)

Creates a Command to commit the uploaded chunks and validate the file appears composable.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Bulk;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Bulk;

namespace Example
{
    public class PostCommitExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UploadsApi();
            var uploadId = uploadId_example;  // string | The id of the upload to commit to the bulk operation.

            try
            {
                // Creates a Command to commit the uploaded chunks and validate the file appears composable.
                string result = apiInstance.PostCommit(uploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostCommit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadId** | **string**| The id of the upload to commit to the bulk operation. | 

### Return type

**string**

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

