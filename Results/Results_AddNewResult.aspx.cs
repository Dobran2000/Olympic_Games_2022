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
    public partial class Results_AddNewResult : System.Web.UI.Page
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

        protected void Add_New_Result(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand
                ("insert into Results (person_id,games_id,event_id,score) "+
                " SELECT "+
               "p.person_id AS[person_id], " +
               "g.id AS[games_id], "+
               "e.event_id AS[event_id], '"+
                txtScore.Value+"' AS [score] "+
               " from Events e, Games g, Persons p "+
               " where '" + ddlEventName.SelectedItem.ToString() + "' = e.event_name"+
               " and  '"+txtAthelte.Value +"' = p.firstname + ' ' + p.lastname "+
               " and '"+ txtGames.Value + "' = g.game_name ", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This result can not be inserted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    } 
}
  