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
namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            BindTripsToDataGridView();
        }
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
                        Spos= row["Nazs"].ToString(),
                        Sot = row["FIO"].ToString(),
                        Zakaz = Convert.ToDateTime(row["DataZ"]),
                        Qena1 = Convert.ToInt32(row["Qena"]),

        private void BindTripsToDataGridView()
        {
            LoadTripsData();
            List<Trip> tripsList = GetTripsList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tripsList;
        }
        public static void LoadTripsData()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Fotost;Integrated Security=False";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        string selectQuery = "SELECT* FROM Pytech";
                        AppData.sqlDataAdapterTrip = new SqlDataAdapter(selectQuery, sqlConnection);

                        AppData.TripSet = new DataSet();
                        AppData.sqlDataAdapterTrip.Fill(AppData.TripSet, "Pytech");




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузки данный о путешествиях: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kon Kon = new Kon();
            Kon.ShowDialog();
        }
    }
}