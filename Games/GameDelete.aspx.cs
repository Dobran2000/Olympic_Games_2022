using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Games
{
    public partial class GameDelete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Games where game_name = '"
                + txtName.Value + "' and YEAR(game_year) = '" + txtGameYear.Value
                + "' and season = '" + txtSeason.SelectedItem.ToString() + "'", con);
               
            int i=cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Deleted Succesfully", "Deleted Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This game doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}