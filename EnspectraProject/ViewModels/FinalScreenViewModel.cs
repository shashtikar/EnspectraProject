using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnspectraProject.ViewModels
{
    public class FinalScreenViewModel : ViewModelBase
    {
        private String _name = String.Empty;
        private String _id = String.Empty;

        public FinalScreenViewModel()
        {
            Mediator.Register("FinalizeName", OnFinalizeName);
            Mediator.Register("FinalizeId", OnFinalizeId);
        }

        public void OnFinalizeId(object obj)
        {
           Id = (String)obj;
            OnPropertyChanged(nameof(Id));
        }

        public void OnFinalizeName(object obj)
        {
            Name = (String)obj;
            OnPropertyChanged(nameof(Name));
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }

        public String Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
