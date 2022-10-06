using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cloud
{
    public partial class example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result = 0;
            num1 = Convert.ToDouble(TextBox1.Text);
            num2 = Convert.ToDouble(TextBox2.Text);

            if (RadioButton1.Checked)
            {
                result = num1 + num2;
            }
            else if (RadioButton2.Checked)
            {
                result = num1 - num2;
            }
            else if (RadioButton3.Checked)
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Label4.Text = result.ToString();
        }
    }
}