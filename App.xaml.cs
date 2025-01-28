using DataClient.Services.API;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DataClient;

public partial class App : Application
{
    protected override async void OnStartup(StartupEventArgs e)
    {
        APIDataModelService aPIDataModelService = new APIDataModelService();

        var result = await aPIDataModelService.GetTopCases(10);

        base.OnStartup(e);
    }
}
