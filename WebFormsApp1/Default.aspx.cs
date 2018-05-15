using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp1
{
    
    public partial class Default : System.Web.UI.Page
    {
        //public string test = "test text";
        //public string output = "";

        //public static int counter = 0;
        public int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*myLabel.ForeColor = System.Drawing.Color.Red;

            string fileName = Server.MapPath(@"App_Data\UserData.txt");
            output = File.ReadAllText(fileName);
            User user = new User("user1", "test@test.test");
            output = output.Replace("<%Login%>", user.mLogin);
            output = output.Replace("<%Email%>", user.mEmail);*/

            String counterParam = Request.QueryString["counter"];
            if (counterParam != null)
            {
                counter = Int32.Parse(counterParam);
            }

        }

        protected override void OnLoadComplete(EventArgs e)
        {
            base.OnLoadComplete(e);
            
            
        }

        protected void add_1_Click(object sender, EventArgs e)
        {
            //counter++;

            //int counter = 0;

            //a. ViewState
            /*Object obj = ViewState["counter"];
            if (obj != null)
            {
                counter = (int)obj;
            }
            counter += 1;
            ViewState["counter"] = counter;*/

            //b. redirect
            counter++;
            Response.Redirect("Default.aspx?counter=" + counter);
        }

        /*protected void submitButton_Click(object sender, EventArgs e)
        {
            myLabel.Text = myTextBox.Text;
        }

        public string myFunc() {

            return "result";
        }*/
    }
}