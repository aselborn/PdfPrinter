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
    [Table("Fastighet")]
    public class Fastighet : ViewModelBase, ICollection
    {
        private ArrayList _fastighet = new ArrayList();
        private int _fastighetId;
        private string _fastighetName;
        private string _fastighetAddress;


        public int Count => _fastighet.Count;

        public Fastighet this[int index] => (Fastighet)_fastighet[index];

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            _fastighet.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return _fastighet.GetEnumerator();
        }


        [XmlElement]
        [Key]
        public int FastighetId
        {
            get => _fastighetId;
            set
            {
                _fastighetId = value;
                NotifyPropertyChanged(nameof(FastighetId));
            }
        }

        [XmlElement]
        public string FastighetName
        {
            get => _fastighetName;
            set
            {
                _fastighetName = value;
                NotifyPropertyChanged(nameof(FastighetName));
            }
        }

        [XmlElement]
        public string FastighetAddress
        {
            get => _fastighetAddress;
            set
            {
                _fastighetAddress = value;
                NotifyPropertyChanged(nameof(FastighetAddress));
            }
        }

        public virtual ICollection<Appartment> Appartments { get; set; }

    }
}
