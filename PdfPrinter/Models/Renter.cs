using PdfPrinter.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PdfPrinter.Models
{
    [Table("Renter")]
    public class Renter : ViewModelBase, ICollection
    {
        private ArrayList _renterList = new ArrayList();
        private int _renterId;
        private string _renterName;
        private int _appartmentId;

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }

        public void CopyTo(Array array, int index)
        {
            _renterList.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return _renterList.GetEnumerator();
        }


        [XmlElement]
        [Key]
        public int RenterId
        {
            get => _renterId;
            set
            {
                _renterId = value;
                NotifyPropertyChanged(nameof(RenterId));
            }
        }

        [XmlElement]
        public int AppartmentId
        {
            get => _appartmentId;
            set
            {
                _appartmentId= value;
                NotifyPropertyChanged(nameof(AppartmentId));
            }
        }

        [XmlElement]
        public string RenterName
        {
            get => _renterName;
            set
            {
                _renterName = value;
                NotifyPropertyChanged(nameof(RenterName));
            }
        }

    }
}
