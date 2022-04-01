using GestionStock.Controller;
using GestionStock.Model;
using System;
using System.Windows;
using System.Windows.Controls;

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

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void grid_Init()
        {
            FournisseurControl controller = new FournisseurControl();
            grid.ItemsSource = controller.Show();
        }

        private void Grille_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
