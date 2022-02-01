using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspmuser.Trainers
{
    public partial class Trainers_FindTrainer : System.Web.UI.Page
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
                    string sql = ("select " +
                                 " t1.firstname as 'Nume', " +
                                 " t1.lastname as 'Prenume' , " +
                                 " t1.age as 'Varsta' ," +
                                 " t1.Results as 'Rezultate' ," +
                                 " t1.CNP as 'CNP' ," +
                                 " t1.phone as 'Telefon'" +
                                 " from Trainers t1 ");
                    
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " where exists  (select t2.firstname from Trainers t2   " +
                               " where  t1.id = t2.id and t2.firstname LIKE @Athlete + '%') " +
                               " order by t1.firstname ";
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

