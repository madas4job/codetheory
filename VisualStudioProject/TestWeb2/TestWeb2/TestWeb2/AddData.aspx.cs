using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWeb2.Presenter;

namespace TestWeb2
{
    public partial class AddData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string useridStr = userid.Text;
            string glucoseStr = glucose.Text;
            DataHandler.GetInstance().AddGlucose(useridStr, Int32.tryParse(glucoseStr));
        }
    }
}