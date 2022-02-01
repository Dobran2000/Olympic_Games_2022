using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Athlete
{
    public partial class Atheltes_UpdateAthelet : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fill_Country();
            }

        }

        protected void Update_Athelet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
               ("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("[sp_Update_Athelete]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Value);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Value);
            cmd.Parameters.AddWithValue("@Height", txtHeight.Value);
            cmd.Parameters.AddWithValue("@Weight", txtWeight.Value);
            cmd.Parameters.AddWithValue("@Age", txtAge.Value);
            cmd.Parameters.AddWithValue("@Trainer", txtTrainer.Value);
            cmd.Parameters.AddWithValue("@RecordResultat", txtRecordResultat.Value);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Value);
            cmd.Parameters.AddWithValue("@CountryName", ddlCountry.SelectedItem.ToString());

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public void Fill_Country()
        {
            DataSet ds = new DataSet();
            ds = GetData("Get_Country", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlCountry.DataSource = ds;
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, new ListItem("Country", "0"));
            }
        }

        private DataSet GetData(string SP_Name, SqlParameter param)
        {
            SqlDataAdapter da = new SqlDataAdapter(SP_Name, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (param != null)
            {
                da.SelectCommand.Parameters.Add(param);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        protected void Error(object sender, EventArgs e)
        {
            MessageBox.Show("Some text", "Some title",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
