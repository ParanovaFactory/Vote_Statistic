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
using System.Windows.Forms.DataVisualization.Charting;

namespace VoteStatistic
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=DbElection;Integrated Security=True;TrustServerCertificate=True");

        private void Graphic_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select cityName from TblCities",sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select SUM(AParty),SUM(BParty),SUM(CParty),SUM(DParty),SUM(EParty) from TblCities", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chart1.Series["Party"].Points.AddXY("AParty", sqlDataReader.GetInt32(0));
                chart1.Series["Party"].Points.AddXY("BParty", sqlDataReader.GetInt32(1));
                chart1.Series["Party"].Points.AddXY("CParty", sqlDataReader.GetInt32(2));
                chart1.Series["Party"].Points.AddXY("DParty", sqlDataReader.GetInt32(3));
                chart1.Series["Party"].Points.AddXY("EParty", sqlDataReader.GetInt32(4));
            }
            sqlDataReader.Close();
            sqlConnection.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select AParty,BParty,CParty,DParty,EParty from TblCities where cityName = @p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", comboBox1.SelectedItem.ToString());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                progressBarA.Value = reader.GetInt32(0);
                progressBarB.Value = reader.GetInt32(1);
                progressBarC.Value = reader.GetInt32(2);
                progressBarD.Value = reader.GetInt32(3);
                progressBarE.Value = reader.GetInt32(4);
            }
        }
    }
}
