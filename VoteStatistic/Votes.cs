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

namespace VoteStatistic
{
    public partial class Votes : Form
    {
        public Votes()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=DbElection;Integrated Security=True;TrustServerCertificate=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblCities (cityName,AParty,BParty,CParty,DParty,EParty) values(@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", txtCity.Text);
            cmd.Parameters.AddWithValue("@p2", txtAParty.Text);
            cmd.Parameters.AddWithValue("@p3", txtBParty.Text);
            cmd.Parameters.AddWithValue("@p4", txtCParty.Text);
            cmd.Parameters.AddWithValue("@p5", txtDParty.Text);
            cmd.Parameters.AddWithValue("@p6", txtEParty.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void tbnGraph_Click(object sender, EventArgs e)
        {
            Graphic graphic = new Graphic();
            graphic.Show();
        }
    }
}
