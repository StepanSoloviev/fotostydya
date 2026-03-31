using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotostydya
{
    internal class Trip
    {
           
        public int Id { get; set; }
        public string Razmer1 { get; set; }
        public string Naz1 { get; set; }
        public string Sot { get; set; }
        public string Spos { get; set; }
        public string Mes { get; set; }
        public int Qena1 { get; set; }
        public DateTime Zakaz { get; set; }
        public string TypeDescription { get; set; }
        = string.Empty;
        public Trip() { }
        public Trip(string Razmer, string Nazm, string Nazs,
     string FIO, DateTime DataZ, int Qena)
        {
            Razmer1 = Razmer;
            Naz1 = Nazm;
            Spos = Nazs;
            Sot = FIO;
            Zakaz = DataZ;
            Qena1 = Qena;
         


        }
    }
}
