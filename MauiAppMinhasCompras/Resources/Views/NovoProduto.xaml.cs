using System;
using Microsoft.Maui.Controls;

namespace MauiAppMinhasCompras.Resources.Views
{
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
           
            string descricao = txt_descricao.Text;
            string quantidade = txt_quantidade.Text;
            string preco = txt_preco.Text;

            DisplayAlert("Sucesso!", $"Descrição: {descricao}\nQuantidade: {quantidade}\nPreço: {preco}", "OK");
        }
    }
}
