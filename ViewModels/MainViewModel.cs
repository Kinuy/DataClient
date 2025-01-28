using DataClient.Services;
using DataClient.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClient.ViewModels;

public class MainViewModel
{
    public DataModelChartViewModel DataModelChartViewModel {  get; set; }

    public MainViewModel() 
    {
        IDataModelService dataModelService = new APIDataModelService();
        DataModelChartViewModel = DataModelChartViewModel.LoadViewModel(dataModelService);
    }
}
