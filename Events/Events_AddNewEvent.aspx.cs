using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aspmuser.Events
{
    public partial class Events_AddNewEvent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");
            //    string sqlStatement = "select * from City";
            //    SqlDataAdapter sda = new SqlDataAdapter(sqlStatement, con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    ddlCityEvent.DataSource = dt;
            //    ddlCityEvent.DataValueField = "id";
            //    ddlCityEvent.DataValueField = "city_name";
            //    ddlCityEvent.DataBind();
            ////  ddlEventName.Items.Insert(0, new ListItem("--Event--", "0"));
            if (!IsPostBack)
            {
                Fill_Country();
                ddlCityEvent.Items.Insert(0, new ListItem("City", "0"));
                ddlCityEvent.Enabled = false;
            }



        }

        protected void Add_New_Event(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8BB4SK2\\SQLEXPRESS;Initial Catalog=OlympicGames;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("[sp_Insert_Event]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EventName", txtEventName.Value);
            cmd.Parameters.AddWithValue("@StartDate", txtStartDate.Value);
            cmd.Parameters.AddWithValue("@EndDate", txtEndDate.Value);
            cmd.Parameters.AddWithValue("@NumberOfGames", txtNumberGames.Value);
            cmd.Parameters.AddWithValue("@CityName", ddlCityEvent.SelectedItem.ToString());

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("Inserted Succesfully", "Inserted Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            public void Fill_Country()
            {
                DataSet ds = new DataSet();
                ds = GetData("Get_Country", null);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlCountryEvent.DataSource = ds;
                    ddlCountryEvent.DataBind();
                    ddlCountryEvent.Items.Insert(0, new ListItem("Country", "0"));
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
                if (ddlCountryEvent.SelectedValue == "0")
                {
                    ddlCityEvent.SelectedValue = "0";
                    ddlCityEvent.Enabled = false;
                }
                else
                {
                    ddlCityEvent.Enabled = true;
                    SqlParameter param = new SqlParameter("@country_id", ddlCountryEvent.SelectedValue);
                    DataSet ds = new DataSet();
                    ds = GetData("Get_City", param);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ddlCityEvent.DataSource = ds;
                        ddlCityEvent.DataBind();
                        ddlCityEvent.Items.Insert(0, new ListItem("City", "0"));

                    }
                }
            }
        }
    }
