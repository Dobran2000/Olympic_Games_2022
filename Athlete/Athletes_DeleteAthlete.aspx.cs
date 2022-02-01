using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Athlete
{
    public partial class Athletes_DeleteAthlete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("delete from Persons " +
                " where firstname = '" + txtFirstname.Value 
                + "' and lastname = '" + txtLastName.Value 
                + "'" +
                " delete Games_Persons from Games_Persons gp " +
                " inner join Persons p " +
                " on p.person_id = gp.person_id " +
                " where p.firstname = '" + txtFirstname.Value
                + "' and p.lastname = '" + txtLastName.Value+ "'", con);

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