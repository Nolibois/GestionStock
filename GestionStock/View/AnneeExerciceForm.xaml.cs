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
    /// Logique d'interaction pour AnneeExerciceForm.xaml
    /// </summary>
    public partial class AnneeExerciceForm : Window
    {
        private AnneeExerciceControl controllerAE;
        private AnneeExercice anneeExercice;

        public AnneeExerciceForm()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            controllerAE = new AnneeExerciceControl();
            gridAE.ItemsSource = controllerAE.Show();
        }

        private void AeCancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addbtn_Click_1(object sender, RoutedEventArgs e)
        {
            controllerAE.Add(new AnneeExercice(aeDate.SelectedDate.Value.ToString("yyyy-MM-dd")));
            //gridAE_Initialized(sender, e);
           Refresh();
        }

        private void gridAE_Initialized(object sender, EventArgs e)
        {
            Refresh();
        }

        private void AeDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            new AnneeExerciceControl().Delete(this.anneeExercice.codeAE);
            Refresh();
        }

        private void AeUpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            AnneeExercice anneeExercice = new AnneeExercice(aeDate.SelectedDate.Value.ToString("yyyy-MM-dd"));
            anneeExercice.codeAE = this.anneeExercice.codeAE;
            new AnneeExerciceControl().Update(anneeExercice);
            Refresh();
        }

        private void gridAE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.anneeExercice = (AnneeExercice)gridAE.SelectedItem;

            if (this.anneeExercice != null)
            {
                aeDate.SelectedDate = DateTime.Parse(this.anneeExercice.anneeExercice);
            }
        }
    }
}
