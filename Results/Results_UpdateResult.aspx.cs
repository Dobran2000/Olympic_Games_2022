using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Results
{
    public partial class Results_UpdateResult : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            string sqlStatement = "SELECT * FROM Events";
            SqlDataAdapter sda = new SqlDataAdapter(sqlStatement, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlEventName.DataSource = dt;
            ddlEventName.DataValueField = "event_id";
            ddlEventName.DataValueField = "event_name";
            ddlEventName.DataBind();

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("[sp_Update_Result]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Athlete", txtAthlete.Value);
            cmd.Parameters.AddWithValue("@Game", txtGame.Value);
            cmd.Parameters.AddWithValue("@Event", ddlEventName.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Score", txtScore.Value);
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