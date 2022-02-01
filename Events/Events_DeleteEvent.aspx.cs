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
    public partial class Events_DeleteEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Events where event_name = '"
                + txtEventName.Value+"'", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This event doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}