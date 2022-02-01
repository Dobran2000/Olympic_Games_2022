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
    public partial class Games_Update : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            //SqlCommand com = new SqlCommand("select *from employee", con);
            //// table name   
            //SqlDataAdapter da = new SqlDataAdapter(com);
            //DataSet ds = new DataSet();
            //da.Fill(ds);  // fill dataset  
            //DropDownList1.DataTextField = ds.Tables[0].Columns["FirstName"].ToString(); // text field name of table dispalyed in dropdown       
            //DropDownList1.DataValueField = ds.Tables[0].Columns["id"].ToString();
            //// to retrive specific  textfield name   
            //DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            //DropDownList1.DataBind()




        }

        protected void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("update Games set season= '" +
                ddlSeason.SelectedItem.ToString() 
                + "' , game_description = '" + txtGameDescription.Value
                + "' where game_name = '" + txtGameName.Value
                + "' and YEAR(game_year) = '" + txtGameYear.Value
                + "'", con);
           int i= cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The game doesn't exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}