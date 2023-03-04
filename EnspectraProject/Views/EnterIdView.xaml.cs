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
    /// Interaction logic for EnterIdView.xaml
    /// </summary>
    public partial class EnterIdView : UserControl
    {
        public EnterIdView()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (utils.validate_id(txt_id.Text))
            {
                btn_continue.IsEnabled = true;
            }
            else { btn_continue.IsEnabled = false; }
        }
    }
}
