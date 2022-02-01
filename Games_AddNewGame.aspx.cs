using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser
{
    public partial class Games_AddNewGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_New_Game(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("[sp_Insert_Game]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Year", txtGameYear.Text);
            cmd.Parameters.AddWithValue("@Game", txtGameName.Text);
            cmd.Parameters.AddWithValue("@Season", txtSeason.Text);
            cmd.Parameters.AddWithValue("@EventName", txtEventName.Text);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                Response.Write("<script> alert('Registered Sucessfully'); </script>");

            }
            else
            {
                MessageBox.Show("X");
            }
        }

     
    }
}