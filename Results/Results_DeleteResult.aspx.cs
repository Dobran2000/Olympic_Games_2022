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
    public partial class Results_DeleteResult : System.Web.UI.Page
    {
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
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("delete r from Results r " +
                "inner join Persons p on r.person_id = p.person_id " +
                "inner join Games g on r.games_id=g.id " +
                "inner join Events e on r.event_id=e.event_id "  +
                "where p.firstname +' '+p.lastname = '" + txtAthlete.Value +
                "' and g.game_name = '" + txtGame.Value +
                "' and e.event_name = '" + ddlEventName.SelectedItem.ToString() + "'",con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This athlete doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}