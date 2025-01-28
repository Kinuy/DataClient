using DataClient.Models;
using DataClient.Services.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataClient.Services.API;

public class APIDataModelService : IDataModelService
{
    public async Task<IEnumerable<DataModel>> GetTopCases(int amountOfCountries)
    {
        using(HttpClient client = new HttpClient())
        {
            string requestURI = "https://disease.sh/v3/covid-19/countries?sort=cases";

            HttpResponseMessage apiResponse = await client.GetAsync(requestURI);


            string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

            List<APIDataModel> apiDataModelListing = JsonSerializer.Deserialize<List<APIDataModel>>(jsonResponse, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            return apiDataModelListing.Take(amountOfCountries).Select(apiCountry => new DataModel()
            {
                CountryName = apiCountry.Country,
                CaseCount = apiCountry.Cases,
                FlagUri = apiCountry.CountryInfo.Flag
            });


        }
    }
}
