using DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClient.Services;

public interface IDataModelService
{
    Task<IEnumerable<DataModel>> GetTopCases(int amountOfCountries);

}
