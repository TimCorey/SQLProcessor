using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProcessor.Library.Models
{
    public class FileResultsModel
    {
        public string FileName { get; set; }
        public List<DataCommandResultModel> CommandResults { get; set; } = new List<DataCommandResultModel>();
    }
}
