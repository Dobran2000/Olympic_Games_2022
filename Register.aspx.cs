using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace aspmuser
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fill_Country();
                ddlcity.Items.Insert(0, new ListItem("--select city--", "0"));
                ddlcity.Enabled = false;
            }


        }
        protected void Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("sp_Insert", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Country", ddlcountry.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@City", ddlcity.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@CNp", txtCNP.Text);
            cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedItem.ToString());
            int marks = GetPasswordStrength(txtPassword.Text);
            string status = "";
            switch (marks)
            {
                case 1:
                    status = "Very Weak";
                    break;
                case 2:
                    status = "Weak";
                    break;
                case 3:
                    status = "Medium";
                    break;
                case 4:
                    status = "Strong";
                    break;
                case 5:
                    status = "Very Strong";
                    break;
                default:
                    break;
            }

            lblPasswordStrength.Text = "Status : " + status;
            if (marks < 4)
            {
                lblPasswordStrength.ForeColor = Color.Red;
                return;
            }

        
            lblPasswordStrength.ForeColor = Color.Green;

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                Response.Write("<script> alert('Registered Sucessfully'); </script>");
                Server.Transfer("user.aspx");
            }
        }

        #region Country_City
        public void Fill_Country()
        {
            DataSet ds = new DataSet();
            ds = GetData("Get_Country", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlcountry.DataSource = ds;
                ddlcountry.DataBind();
                ddlcountry.Items.Insert(0, new ListItem("--select country--", "0"));
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
        protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlcountry.SelectedValue == "0")
            {
                ddlcity.SelectedValue = "0";
                ddlcity.Enabled = false;
            }
            else
            {
                ddlcity.Enabled = true;
                SqlParameter param = new SqlParameter("@country_id", ddlcountry.SelectedValue);
                DataSet ds = new DataSet();
                ds = GetData("Get_City", param);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlcity.DataSource = ds;
                    ddlcity.DataBind();
                    ddlcity.Items.Insert(0, new ListItem("--select city--", "0"));
                }
            }
        }
        #endregion
        private int GetPasswordStrength(string password)
        {
            int Marks = 0;
            // here we will check password strength
            if (password.Length < 6)
            {
                // Very Weak
                return 1;
            }
            else
            {
                Marks = 1;
            }
            if (Regex.IsMatch(password, "[a-z]"))
            {
                // 2    weak
                Marks++;
            }
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                // 3    medium
                Marks++;
            }
            if (Regex.IsMatch(password, "[0-9]"))
            {
                //4     strong
                Marks++;
            }
            if (Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
            {
                //5     very strong
                Marks++;
            }
            return Marks;
        }
    }
}
