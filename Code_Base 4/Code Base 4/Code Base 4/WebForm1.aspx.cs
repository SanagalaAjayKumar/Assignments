using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_Base_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] { "HeadPhones", "Mobiles", "", "Cars", };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JFIF";




            if (DropDownList1.Items.FindByText("HeadPhones").Selected == true)
            {
                Label1.Text = "Price: 27504/-";
            }
            else if (DropDownList1.Items.FindByText("Mobiles").Selected == true)
            {
                Label1.Text = "Price: 71,35,000/-";
            }
            else if (DropDownList1.Items.FindByText("Cars").Selected == true)
            {
                Label1.Text = "Price: 65,25,00,000/-";
            }
           
        }
    }
}