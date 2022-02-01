using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Events
{
    public partial class Events_UpdateEvent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("update Events set start_date = '" +
                txtStartDate.Value 
                + "', end_date = '" + txtEndDate.Value
                + "', numberGames = '" + txtNumberGames.Value
                + "' where event_name = '" + txtEventName.Value
                + "'", con);
            int i=cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The event doesn't exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}