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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnspectraProject.Views
{
    /// <summary>
    /// Interaction logic for FInalScreenView.xaml
    /// </summary>
    public partial class FinalScreenView : UserControl
    {
        public FinalScreenView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var msg = String.Format("The name is {0} and the Id is {1}", txt_blk_name.Text, txt_blk_id);
            if (MessageBox.Show(msg, "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Mediator.NotifyColleagues("ChangeView", "home");
                Mediator.NotifyColleagues("ChangeName", String.Empty);
                Mediator.NotifyColleagues("ChangeId", String.Empty);
            }
        }
    }
}
