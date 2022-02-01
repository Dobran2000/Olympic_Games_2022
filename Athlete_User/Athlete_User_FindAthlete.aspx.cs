using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspmuser.Athlete_User
{
    public partial class Athelte_User_FindAthlete : System.Web.UI.Page
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
                                 "p.firstname as 'Nume' , " +
                                 "p.lastname as 'Prenume' ," +
                                 "p.gender as 'Sex' , " +
                                 "p.height as 'Inaltime' ," +
                                 "p.weight as 'Greutate', " +
                                 "p.age as 'Varsta', " +
                                 "t.firstname + ' ' + " +
                                 "t.lastname as 'Antrenor' ," +
                                 "p.birthday_date as 'Data de nastere' , " +
                                 "p.record_resultat as 'Rezultat record' ," +
                                 "c.country_name as 'Tara' ," +
                                 "g.game_name as 'Joc' " +
                                 "from Persons p , " +
                                 "Country c, Trainers t ," +
                                 "Games_Persons gp , Games g " +
                                 "where c.country_id = p.country_id " +
                                 "and t.id = p.trainer_id " +
                                 "and gp.person_id = p.person_id " +
                                 "and gp.game_id = g.id ";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += "and p.firstname LIKE @Name + '%'";
                        cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());

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

