using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;

namespace aspmuser
{
    public partial class Games_Admin : System.Web.UI.Page
    {
        
        protected void Games_Click(object sender, EventArgs e)
        {
            Server.Transfer("Games_List.aspx");
        }
        protected void Add_Game(object sender, EventArgs e)
        {
            Server.Transfer("Games_AddNewGame.aspx");
        }
        protected void Find_Game(object sender, EventArgs e)
        {
            Server.Transfer("Games_FindGame.aspx");
        }
        protected void FindGame_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("Games.FindGame.aspx");
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

    }
}


