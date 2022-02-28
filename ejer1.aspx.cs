using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taler_ejerc01
{
    public partial class ejer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double peso, trm, calcdolar;
            //datos de entrada
            peso = Convert.ToDouble(txtpeso.Text);
            trm = 3910.64;
            //proceso
            calcdolar = peso / trm;
            //datos de salida
            LblTdolar.Text = System.Convert.ToString(calcdolar);
            lbltrm.Text = System.Convert.ToString(trm);
        }
    }
}