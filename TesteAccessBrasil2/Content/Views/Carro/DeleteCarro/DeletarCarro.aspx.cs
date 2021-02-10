﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteAccessBrasil2.Models;

namespace TesteAccessBrasil2.Content.Views.DeleteCarro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeletarBtn(object sender, EventArgs e)
        {
            Regra regra = new Regra();
            
            regra.excluir(int.Parse(TextId.Text));

            
            TextCod.Text = "";
            TextCodMarca.Text = "";
            TextModel.Text = "";
            TextAno.Text = "";
            TextCor.Text = "";
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