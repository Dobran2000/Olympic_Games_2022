using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspmuser.Athlete_User
{
    public partial class Athlete_User_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                DataTable dt = this.GetData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table border = '5';");

                //Building the Header row.
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td style='background-color:green'>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder2.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private DataTable GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand
                ("select p.firstname as 'Nume' , p.lastname as 'Prenume' ," +
                "p.gender as 'Sex' , p.height as 'Inaltime' , p.weight as 'Greutate', p.age as 'Varsta' " +
                ",t.firstname+' '+t.lastname as 'Antrenor'," +
                "p.birthday_date as 'Data de nastere' , p.record_resultat as 'Rezultat record' ," +
                "c.country_name as 'Tara' , g.game_name as 'Joc' "
                 + "from Persons p," +
                 "Country c, Trainers " +
                 "t , Games_Persons gp , Games g " +
                 "where c.country_id=p.country_id " +
                 "and t.id=p.trainer_id " +
                 "and gp.person_id=p.person_id " +
                 "and gp.game_id=g.id"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}