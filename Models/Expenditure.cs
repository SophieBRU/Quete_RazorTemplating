using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_RazorTemplating.Models
{
    public class Expenditure
    {
        public Int32 ExpenditureId { get; set; }

        public String Name { get; set; }

        public String Date { get; set; }

        public Double Amount { get; set; }
    }
}
