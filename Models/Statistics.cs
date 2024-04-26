using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace OfficePulse.Statistics

    
{

    internal class Statistics : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

             
        
        public List<KeyValuePair<string,double>> DepartmentReviewList { get; private set; }
        public List<KeyValuePair<string, double>> TopicReviewList { get; private set; }





        private void getAVGbyDepartment()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                }
            }
        }

        private void getAVGbyTopic()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                }
            }
        }
    }
}
