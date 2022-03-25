using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GestionStock.Model;
using GestionStock.Controller;

namespace GestionStock.View
{
    /// <summary>
    /// Logique d'interaction pour FournisseurForm.xaml
    /// </summary>
    public partial class FournisseurForm : Window
    {
        private FournisseurControl controller;

        public FournisseurForm()
        {
            InitializeComponent();
            controller = new FournisseurControl();
            grid_Init();
        }


        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseur = new Fournisseurs(
                nomFournisseur.Text,
                nomContact.Text,
                titreContact.Text,
                adresse.Text,
                ville.Text,
                Int32.Parse(codePostal.Text),
                Int32.Parse(dept.Text),
                pays_region.Text,
                telephone.Text,
                Int32.Parse(paiement.Text),
                email.Text,
                remarques.Text);

           controller.Ajouter(fournisseur);

            grid_Initialized(sender, e);
        }

        private void btn_ajouter_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void grid_Initialized(object sender, EventArgs e)
        {
            grid_Init();
        }

        private void grid_Init() {
            FournisseurControl controller = new FournisseurControl();
            grid.ItemsSource = controller.Show();
        }
    }
}
