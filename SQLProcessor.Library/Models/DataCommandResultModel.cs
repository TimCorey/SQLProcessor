using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQLProcessor.Library.Enums;

namespace SQLProcessor.Library.Models
{
    public class DataCommandResultModel
    {
        public ResultStatus StatusId { get; set; }
        public string StatusMessage { get; set; }
        public int RecordsAffected { get; set; }
    }
}
