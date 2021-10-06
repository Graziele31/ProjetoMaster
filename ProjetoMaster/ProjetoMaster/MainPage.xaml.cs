using ProjetoMaster.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoMaster
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Produto>
            {
              new Produto
              {
                  descricao="Produto1", valor="R$ 120,00"
              },
              new Produto
              {
                  descricao="Produto2", valor="R$ 110,00"
              },
              new Produto
              {
                  descricao="Produto3", valor="R$ 260,00"
              },
              new Produto
              {
                  descricao="Produto4", valor="R$ 80,00"
              },
              new Produto
              {
                  descricao="Produto5", valor="R$ 70,00"
              }
            };

        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var produto = e.SelectedItem as Produto;
            Detail = new NavigationPage(new Detalhes(produto));
            IsPresented = false;
        }
    }
}

