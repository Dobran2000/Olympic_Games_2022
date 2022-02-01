using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser
{
    public partial class Games_FindGame : System.Web.UI.Page
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
                    string sql = "SELECT game_name, season , " +
                                 "e.event_name as 'Eveniment' , game_description from Games g " +
                                 "join Events e on e.event_id = g.event_id "; ;
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " WHERE game_name LIKE @game_name + '%'";
                        cmd.Parameters.AddWithValue("@game_name", txtSearch.Text.Trim());
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