using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio_15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Convertir texto a números
            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);

            // Sumar
            double resultado = num1 + num2;

            // Mostrar resultado en el Label
            Label1.Text = "La suma es: " + resultado.ToString();
        }
    }
}