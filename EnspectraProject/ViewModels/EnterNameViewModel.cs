using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace EnspectraProject.ViewModels
{
    public class EnterNameViewModel : ViewModelBase
    {
        private ICommand _goBackCommand;
        private ICommand _continueCommand;

        private String _name = String.Empty;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name= value;
                OnPropertyChanged(nameof(Name));
                if (utils.validate_name(Name)) {
                    Mediator.NotifyColleagues("ChangeName", Name);
                }
            }
        }

        public ICommand GoBackCommand
        {
            get
            {
                return _goBackCommand ?? (_goBackCommand = new RelayCommand(
                   x =>
                   {
                       Name = String.Empty;
                       OnPropertyChanged(nameof(Name));
                       Mediator.NotifyColleagues("ChangeName", String.Empty);
                       Mediator.NotifyColleagues("ChangeId", String.Empty);
                       Mediator.NotifyColleagues("ChangeView", "home");
                   }));
            }
        }

        public ICommand ContinueCommand
        {
            get
            {
                return _continueCommand ?? (_continueCommand = new RelayCommand(
                   x =>
                   {
                       Mediator.NotifyColleagues("ChangeView", "enter_id");
                       Mediator.NotifyColleagues("FinalizeName", Name);
                   }));
            }
        }
    }
}
