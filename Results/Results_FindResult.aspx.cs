using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspmuser.Results
{
    public partial class Results_FindResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.SearchCustomers();
            }
        }

        private void SearchCustomers()
        {
            using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-8BB4SK2\\SQLEXPRESS; Initial Catalog = OlympicGames; Integrated Security = True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = "select " +
                        "r.score as 'Score' , " +
                        "p.firstname + ' ' + p.lastname  as 'Athlete', " +
                        "(select game_name from Games where r.games_id=id) as 'Joc' , " +
                        "e.event_name as 'Eveniment'  " +
                        "from Results r , " +
                        "Persons p , " +
                        "Games g , " +
                        "Events e " +
                        "where p.person_id = r.person_id " +
                        "and r.games_id = g.id " +
                        "and e.event_id = r.event_id ";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " and p.firstname + ' ' + p.lastname " +
                            " in " +
                            "(select p.firstname + ' ' + p.lastname from Persons p " +
                            "where p.firstname + ' ' + p.lastname  LIKE @Athlete + '%' ) ";
                        cmd.Parameters.AddWithValue("@Athlete", txtSearch.Text.Trim());
                    }
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvCustomers.DataSource = dt;
                        gvCustomers.DataBind();
                    }
                }
            }
        }
        protected void Search(object sender, EventArgs e)
        {
            this.SearchCustomers();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvCustomers.PageIndex = e.NewPageIndex;
            this.SearchCustomers();
        }
    }
}