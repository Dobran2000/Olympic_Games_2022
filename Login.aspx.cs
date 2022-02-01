using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace aspmuser
{
    public partial class home : System.Web.UI.Page
    {
        protected void Login_Button(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Users where username ='" + txtUser.Value
                + "' and password= '" + txtPass.Value +
                "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Server.Transfer("user.aspx");
            }
            else if (txtUser.Value == "admin" && txtPass.Value == "admin")
            {
                Server.Transfer("admin.aspx");
            }
            else
            {
                MessageBox.Show("User sau parola incorecta!", "Eroare");
            }

        }
        protected void SendToRegister(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx");
        }
    }
}