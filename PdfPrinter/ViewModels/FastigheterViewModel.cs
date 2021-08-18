using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfPrinter.ViewModels
{
    public class FastigheterViewModel : ViewModelBase
    {
        private int _fastighetId;
        private string _fastighetName;

        public string FastighetName
        {
            get => _fastighetName;
            set
            {
                _fastighetName = value;
                NotifyPropertyChanged(nameof(FastighetName));
            }
        }

        public int FastighetId
        {
            get => _fastighetId;
            set
            {
                _fastighetId = value;
                NotifyPropertyChanged(nameof(FastighetId));
            }
        }

        public override string ToString()
        {
            return _fastighetName.Trim().ToUpper();
        }
    }
}
