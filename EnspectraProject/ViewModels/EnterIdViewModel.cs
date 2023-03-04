using EnspectraProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace EnspectraProject.ViewModels
{
    internal class EnterIdViewModel : ViewModelBase
    {
        private ICommand _goBackCommand;
        private ICommand _continueCommand;

        private string _id = string.Empty;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
                if (utils.validate_id(value))
                {
                    Mediator.NotifyColleagues("ChangeId", Id);
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
                       Mediator.NotifyColleagues("ChangeView", "enter_name");
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
                       Mediator.NotifyColleagues("ChangeView", "confirmation_page");
                       Mediator.NotifyColleagues("FinalizeId", Id);
                   }));
            }
        }
    }
}
