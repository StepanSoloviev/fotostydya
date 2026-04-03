using fotostydya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    internal static class Form3Helpers
    {
        public static List<Trip> GetTripsList()
        {
            var trips = new List<Trip>();
            if (AppData.TripSet?.Tables["Pytech"] != null)
            {
                foreach (DataRow row in AppData.TripSet.Tables["Pytech"].Rows)
                {
                    trips.Add(new Trip
                    {
                        Razmer1 = row["Razmer"].ToString(),
                        Naz1 = row["Nazm"].ToString(),
                        Spos = row["Nazs"].ToString(),
                        Sot = row["FIO"].ToString(),
                        Zakaz = Convert.ToDateTime(row["DataZ"]),
                        Qena1 = Convert.ToInt32(row["Qena"]),


                    });
                }
            }
            return trips;
        }
        public static List<Trip> tre()
        {
            var trips = new List<Trip>();
            if (AppData.TripSet?.Tables["Foto"] != null)
            {
                foreach (DataRow row in AppData.TripSet.Tables["Foto"].Rows)
                {
                    trips.Add(new Trip
                    {
                        Razmer1 = row["Razmer"].ToString(),
                        Naz1 = row["RNaz"].ToString(),
                        Naz2 = row["MNaz"].ToString(),
                        Qena1 = (int)Convert.ToDecimal(row["Qena"]),


                    });
                }
            }
            return trips;
        }
    }
}