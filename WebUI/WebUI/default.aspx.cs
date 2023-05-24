using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //UI
            int height = int.Parse(this.TextBox1.Text);
            int weight = int.Parse(this.TextBox2.Text);

            //call services
            ServiceReference1.WebService1SoapClient ws1 = new ServiceReference1.WebService1SoapClient();
            var BMI=ws1.Calculate(height, weight);

            this.Label1.Text = BMI.ToString();
        }
    }
}