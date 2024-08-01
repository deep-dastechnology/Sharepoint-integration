using Newtonsoft.Json;
using Sharepoint.Services;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

SharePointService sharePointService = new SharePointService("<clientID>", "<tenantid>", "<clientsecret>");

var accessToken = await sharePointService.GetAccessTokenAsync();
var data = await sharePointService.GetSharePointSiteDataAsync("<MySharepointURL>");
Console.WriteLine(JsonConvert.SerializeObject(data));
var data1 = await sharePointService.GetListItemsAsync("<MySharepointURL>","My Folder");
await sharePointService.UploadFileAsync("<MySharepointURL>","My Folder","myfile.png");
Console.Read();