using DataClient.Models;
using DataClient.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace DataClient.ViewModels;

public class DataModelChartViewModel
{
    private const int AMOUNT_OF_COUNTRIES = 10;
    private readonly IDataModelService _dataModelService;

    public ChartValues<int> DataModelCaseCounts { get; set; }

    public string[] DataModelNames { get; set; }

    public DataModelChartViewModel(IDataModelService dataModelService)
    {
        _dataModelService = dataModelService;

    }

    public static DataModelChartViewModel LoadViewModel(IDataModelService dataModelService, Action<Task> onLoaded = null)
    {
        DataModelChartViewModel viewModel = new DataModelChartViewModel(dataModelService);

        viewModel.Load().ContinueWith(t=>onLoaded?.Invoke(t));

        return viewModel;
    }

    public async Task Load()
    {
        IEnumerable<DataModel> countries = await _dataModelService.GetTopCases(AMOUNT_OF_COUNTRIES);

        DataModelCaseCounts = new ChartValues<int>(countries.Select(c => c.CaseCount));

        DataModelNames = countries.Select(c => c.CountryName).ToArray();
    }
}
