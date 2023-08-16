using Newtonsoft.Json;
using Model.CdsHooks.v1;
namespace Test.v1;

public class Tests
{
    private static HttpClient client = new HttpClient();
    private string endpoint = "https://fhir-org-cds-services.appspot.com/cds-services";
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task DiscoverServices()
    {
        var http = await client.GetAsync(endpoint);
        var stringResponse = await http.Content.ReadAsStringAsync();
        var services = JsonConvert.DeserializeObject<DiscoveryResponse>(stringResponse);
        Assert.Pass();
    }

    [Test]
    public async Task ServiceRequest()
    {
        var jsonString = @"{ ""hookInstance"": ""0a9d14ec-8902-4dfb-91f7-d8f2fa1ec7ac"", ""hook"": ""patient-view"", ""fhirServer"": ""https://launch.smarthealthit.org/v/r2/fhir"", ""context"": { ""patientId"": ""smart-1288992"", ""userId"": ""Practitioner/COREPRACTITIONER1"" }, ""prefetch"": { ""patient"": { ""resourceType"": ""Patient"", ""id"": ""smart-1288992"", ""meta"": { ""versionId"": ""634"", ""lastUpdated"": ""2021-05-12T02:30:37.942-04:00"", ""tag"": [ { ""system"": ""https://smarthealthit.org/tags"", ""code"": ""smart-8-2017"" } ] }, ""text"": { ""status"": ""generated"", ""div"": ""<div xmlns=\""http://www.w3.org/1999/xhtml\""> <p> Daniel Adams </p> </div>"" }, ""identifier"": [ { ""use"": ""usual"", ""type"": { ""coding"": [ { ""system"": ""http://hl7.org/fhir/v2/0203"", ""code"": ""MR"", ""display"": ""Medical record number"" } ], ""text"": ""Medical record number"" }, ""system"": ""http://hospital.smarthealthit.org"", ""value"": ""1288992"" } ], ""active"": true, ""name"": [ { ""use"": ""official"", ""family"": [ ""Adams"" ], ""given"": [ ""Daniel"", ""X."" ] } ], ""telecom"": [ { ""system"": ""email"", ""value"": ""daniel.adams@example.com"" } ], ""gender"": ""male"", ""birthDate"": ""1929-08-16"", ""address"": [ { ""use"": ""home"", ""line"": [ ""1 Hill AveApt 14"" ], ""city"": ""Tulsa"", ""state"": ""OK"", ""postalCode"": ""74117"", ""country"": ""USA"" } ] } } }";
        var cdsRequest = JsonConvert.DeserializeObject<CdsRequest>(jsonString);
        var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
        var result = await client.PostAsync(endpoint, content);

        var response = await result.Content.ReadAsStringAsync();
        var cards = JsonConvert.DeserializeObject<CdsResponse>(response);
        Assert.Pass();

    }
}