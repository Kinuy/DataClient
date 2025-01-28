namespace DataClient.Services.API.Models;

public class APIDataModel
{
    public string Country {  get; set; }
    public int Cases {  get; set; }
    public APIDataModelCountryInfo CountryInfo { get; set; }
}