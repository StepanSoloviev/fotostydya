using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotostydya
{
    internal class AppConect
    {
        public static DataSet userSet = new DataSet();
        public static SqlDataAdapter sqlDataAdapter;
        public static DataSet TripSet = new DataSet();
        public static SqlDataAdapter sqlDataAdapterTrip;
    }
}
