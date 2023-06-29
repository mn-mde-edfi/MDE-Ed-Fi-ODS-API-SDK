# MDE-Ed-Fi-ODS-API-SDK

A C sharp client SDK to interact with the MN Ed-Fi ODS API.

## Use the SDK Source files in a Sample C# Program
1. Open up Visual Studio and create a new project. 
2. Choose the type Visual C# > Console Application. 
3. Name the project "MNEdFiClientSDK".
4. Add folders to the project, one for each of the folders generated from the previous step, i.e.,:

#### Sdk (includes MN Identities API)
#### Api
* \Resources
* \Descriptors
* \Types
* \Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile
#### Models
* \Resources
* \Descriptors
* \Types
* \Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile


5. Right-click on each of the folders and add the existing classes for each package. The files can be found at the following location: MDE-Ed-Fi-ODS-API-SDK/MDE-EdFiClientSDK/EdFi/OdsApi/. Be sure to select all of the generated SDK files for each package.
6. Use the NuGet Package Manager Console to install the RestSharp library. 
7. Use the Program.cs file found here (MDE-Ed-Fi-ODS-API-SDK/MDE-EdFiClientSDK/EdFi/OdsApi/) 

The client key and secret are will need to be replaced to match a MN sandbox environment with sample data.  URLS provided connect to the MN Public Sandbox environment. 

```
// OAuth configuration
var oauthUrl = "https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/";
var clientKey = "RvcohKxyzXYZ";
var clientSecret = "ABCabcaNf81xzCxwHfbolkC";
 
// RestSharp dependency, install via NuGet
var client = new RestClient("https://test.edfi.education.mn.gov/sb21_/edfi.ods.webapi/");
```

Build the project and run it without debugging (Ctrl+F5) and a console will open and display the results of your API request.

###### Important note on profile references

_An existing defect in the the SDK generator outputs the references to profiles without hyphens.  You should change references to the SIS Vendor profile so that they include hyphens that are part of the actual profile name. For example:  "application/vnd.ed-fi.student.minnesota-sisvendor-profile.writable+json"_


