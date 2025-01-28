using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClient.Services.API.Models;

public class APIDataModelListing
{
    public IEnumerable<APIDataModel> Countries { get; set; }
}
