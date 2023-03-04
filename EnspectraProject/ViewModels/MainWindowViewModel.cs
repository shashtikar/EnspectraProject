using EnspectraProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnspectraProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object _homeView = new HomeView();
        private object _enterNameView = new EnterNameView();
        private object _enterIdView = new EnterIdView();
        private object _finalScreenView = new FinalScreenView();

        private Dictionary<string, object> _view_name_to_object = new Dictionary<string, object>();

        private String _nameStatus = String.Empty;
        private String _idStatus = String.Empty;
        private object _currentView;

        public MainWindowViewModel()
        {
            _currentView = _homeView;
            Mediator.Register("ChangeView", OnChangeView);
            Mediator.Register("ChangeName", OnChangedName);
            Mediator.Register("ChangeId", OnChangedId);

            _view_name_to_object.Add("home", _homeView);
            _view_name_to_object.Add("enter_name", _enterNameView);
            _view_name_to_object.Add("enter_id", _enterIdView);
            _view_name_to_object.Add("confirmation_page", _finalScreenView);
        }

        public String NameStatus
        {
            get { 
                return _nameStatus; 
            }
            set {
                _nameStatus = value; 
                OnPropertyChanged("NameStatus");
            }
        }

        public String IdStatus
        {
            get
            {
                return _idStatus;
            }
            set
            {
                _idStatus = value;
                OnPropertyChanged("IdStatus");
            }
        }

        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public void OnChangeView(object show)
        {
            String viewName = (String)show;
            if (_view_name_to_object.ContainsKey(viewName))
            {
                CurrentView = _view_name_to_object[viewName];
            }
        }

        public void OnChangedName(object newName)
        {
            NameStatus = (String)newName;
        }

        public void OnChangedId(object newId) { 
            IdStatus = (String)newId;
        }
    }
}
