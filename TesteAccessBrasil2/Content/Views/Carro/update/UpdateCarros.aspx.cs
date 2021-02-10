using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteAccessBrasil2.Models;

namespace TesteAccessBrasil2.Content.Views.update
{
    public partial class UpdateCarros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AtualizarBtn(object sender, EventArgs e)
        {
            Regra regra = new Regra();
            Carro car = new Carro();
            
            car.Codigo = int.Parse(TextCod.Text);
            car.CodMarca = int.Parse(TextCodMarca.Text);
            car.Modelo = TextModel.Text;
            car.Ano = int.Parse(TextAno.Text);
            car.Cor = TextCor.Text;
            regra.Atualizar(int.Parse(TextId.Text));
        }

        protected void BtnBuscarDados_Click(object sender, EventArgs e)
        {
            Regra regra = new Regra();
            Carro car = regra.Encontrar(int.Parse(TextId.Text));
            TextCod.Text = Convert.ToString(car.Codigo);
            TextCodMarca.Text = Convert.ToString(car.CodMarca);
            TextModel.Text = car.Modelo;
            TextAno.Text = Convert.ToString(car.Ano);
            TextCor.Text = car.Cor;
        }
    }
}