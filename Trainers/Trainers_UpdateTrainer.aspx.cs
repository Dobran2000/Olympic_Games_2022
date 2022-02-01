using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Trainers
{
    public partial class Trainers_UpdateTrainer : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update_Athelet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
               ("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("[sp_Update_Trainer]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Value);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Value);
            cmd.Parameters.AddWithValue("@Age", txtAge.Value);
            cmd.Parameters.AddWithValue("@Results", txtResultats.Value);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Value);
        

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}