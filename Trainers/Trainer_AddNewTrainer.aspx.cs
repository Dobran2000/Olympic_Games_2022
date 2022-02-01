using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Trainers
{
    public partial class Trainer_AddNewTrainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_New_Trainer(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection
                ("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand
                ("insert into Trainers(firstname, lastname , age , results , phone, CNP) "+
                 "SELECT '"+
                  txtFirstName.Value+ "' AS[firstname], '"+
                  txtLastName.Value+ "' AS[lastname], '"+
                  txtAge.Value + "' AS[age], '"+
                  txtRecordResultat.Value +"' AS[results], '"+
                  txtPhone.Value + "' AS[phone], '"+
                  txtCNP.Value +"' AS [CNP] ", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This trainer can not be inserted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}