using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePulse.Statistics
{
    internal class Statistics : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int numUsers { get; set; }
        public List<KeyValuePair<string, int>> ByDepartmentList { get; set; }
        public List<KeyValuePair<string, int>> AllDepartmentsList { get; set; }


    }
}
