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
    public partial class Athletes_AddNewAthlete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fill_Country();
            }
        }

        protected void Add_New_Athelete(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
            ("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("[sp_Insert_Athelete]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Value);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Value);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Height", txtHeight.Value);
            cmd.Parameters.AddWithValue("@Weight", txtWeight.Value);
            cmd.Parameters.AddWithValue("@Age", txtAge.Value);
            cmd.Parameters.AddWithValue("@Trainer", txtTrainer.Value);
            cmd.Parameters.AddWithValue("@CNP", txtCNP.Value);
            cmd.Parameters.AddWithValue("@BirthdayDate", txtBirthday.Value);
            cmd.Parameters.AddWithValue("@RecordResultat", txtRecordResultat.Value);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Value);
            cmd.Parameters.AddWithValue("@CountryName", ddlCountry.SelectedItem.ToString());

            SqlCommand cmd2 = new SqlCommand("[sp_Insert_Games_Persons]", con);

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@Game", txtGame.Value);
            cmd2.Parameters.AddWithValue("@Person", txtFirstName.Value + ' ' + txtLastName.Value);

            int i = cmd.ExecuteNonQuery();
            int i2 = cmd2.ExecuteNonQuery();

            if (i > 0 && i2 > 0)
            {
                MessageBox.Show("Inserted Succesfully", "Inserted Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Country
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
        #endregion

    }
}

