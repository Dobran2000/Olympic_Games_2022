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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            string sqlStatement = "SELECT event_id,event_name FROM Events";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStatement, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlEventName.DataSource = dt;
            ddlEventName.DataTextField = "event_name";
            ddlEventName.DataValueField = "event_id";
            ddlEventName.DataBind();
           //ddlEventName.Items.Insert(0, new ListItem("--Event--", "0"));

        }

      
            protected void Add_New_Game(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("[sp_Insert_Game]", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", txtGameYear.Value);
                cmd.Parameters.AddWithValue("@Game", txtGameName.Value);
                cmd.Parameters.AddWithValue("@Season", ddlSeason.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Description", txtGameDescription.Value);
                cmd.Parameters.AddWithValue("@EventName", ddlEventName.SelectedItem.ToString());

                int i = cmd.ExecuteNonQuery();
 
                if (i > 0)
                {
                    MessageBox.Show("Inserted Succesfully", "Inserted Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  
                }
            }
        
   
    }
}