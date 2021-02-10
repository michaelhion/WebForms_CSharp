using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteAccessBrasil2.Models;

namespace TesteAccessBrasil2.Content.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
            car.Codigo = int.Parse(TextCod.Text);
            car.CodMarca = int.Parse(TextCodMarca.Text);
            car.Modelo = TextModel.Text;
            car.Ano = int.Parse(TextAno.Text);
            car.Cor = TextCor.Text;
            Regra regra = new Regra();
            regra.Add(car);
            
        }
    }
}