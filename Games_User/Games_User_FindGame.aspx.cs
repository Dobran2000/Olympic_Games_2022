using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspmuser.Games_User
{
    public partial class Games_User_FindGame : System.Web.UI.Page
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
                    string sql = "SELECT * , (select event_name from Events e where e.event_id = g.event_id) " +
                       " as 'Eveniment' FROM Games g";
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




















        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!Page.IsPostBack)
        //    {

        //        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand
        //          ("select Year(game_year) as 'Anul',game_name 'Joc' ,season as 'Sezon', event_name as 'Eveniment' from Games g " +
        //                                              "inner join Events e " +
        //                                              "on g.event_id=e.event_id where game_name = '"  + "')");
        //        cmd.Connection = con;
        //       // SqlDataReader rd = cmd.ExecuteReader();
        //        table.Append("<table border='1'>");
        //        table.Append("<tr><th>game_name</th><th>season</th>");
        //        table.Append("</tr>");

        //        if (rd.HasRows)
        //        {
        //            while (rd.Read())
        //            {
        //                table.Append("<tr>");
        //                table.Append("<td>" + rd[2] + "</td>");
        //                table.Append("<td>" + rd[0] + "</td>");
        //                table.Append("</tr>");
        //            }
        //        }
        //        table.Append("</table>");
        //       // PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        //        rd.Close();


        //    }

        //}
    }
}