using DataClient.Services.API;
using DataClient.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DataClient;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow mainWindow = new MainWindow()
        {
            DataContext = new MainViewModel()
        };

        mainWindow.Show();

        //APIDataModelService aPIDataModelService = new APIDataModelService();

        //var result = await aPIDataModelService.GetTopCases(10);

        base.OnStartup(e);
    }
}
