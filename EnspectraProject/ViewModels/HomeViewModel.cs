using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnspectraProject.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ICommand _goToEnterNameCommand;

        public ICommand GoToEnterNameCommand
        {
            get
            {
                return _goToEnterNameCommand ?? (_goToEnterNameCommand = new RelayCommand(
                   x =>
                   {
                       Mediator.NotifyColleagues("ChangeView", "enter_name");
                   }));
            }
        }
    }
}
