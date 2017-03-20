using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kalender
{
    public partial class KalenderWebForm : System.Web.UI.Page
    {
        private DateTime verjaardag;
        private string verjaardagText = "Mijn geboortedatum is op: ";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                verjaardag = new DateTime(1995, 1, 1);
                KalVerjaardag.VisibleDate = verjaardag;
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void KalVerjaardag_SelectionChanged(object sender, EventArgs e)
        {
            verjaardag = KalVerjaardag.SelectedDate;
            tbDatum.Text = verjaardagText + verjaardag.ToLongDateString();

            DateTime now = DateTime.Now;

            TimeSpan difference = now.Subtract(verjaardag);
            int jaren = difference.Days / 365;

            tbLeeftijd.Text = jaren.ToString();
        }
    }
}