using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using PdfPrinter.ViewModels;

namespace PdfPrinter.Models
{
    [Table("Appartment")]
    public class Appartment : ViewModelBase, ICollection
    {
        private ArrayList _appartmentList = new ArrayList();
        private int _appartmentId;
        private int _fastighetId;

        public Fastighet Fastighet { get; set; }


        public IEnumerator GetEnumerator()
        {
            return _appartmentList.GetEnumerator();
        }

        public Appartment this[int index] => (Appartment) _appartmentList[index];

        [XmlElement]
        [Required]
        [Key]
        public int AppartmentId
        {
            get => _appartmentId;
            set
            {
                _appartmentId = value;
                NotifyPropertyChanged(nameof(AppartmentId));
            }
        }

        [XmlElement] 
        private string _apparmentNumber;

        public string AppartmentNumber
        {
            get => _apparmentNumber;
            set
            {
                _apparmentNumber = value;
                NotifyPropertyChanged(nameof(AppartmentNumber));
            }
        }

        [XmlElement]
        private double _appartmentRent;

        public double AppartmentRent
        {
            get => _appartmentRent;
            set
            {
                _appartmentRent = value;
                NotifyPropertyChanged(nameof(AppartmentRent));
            }
        }

        [XmlElement]
        [Required]
        [ForeignKey("Fastighet")]
        public int FastighetId
        {
            get => _fastighetId;
            set
            {
                _fastighetId = value;
                NotifyPropertyChanged(nameof(FastighetId));
            }
        }

        public void Add(Appartment app)
        {
            _appartmentList.Add(app);
        }
        public void CopyTo(Array array, int index)
        {
            _appartmentList.CopyTo(array, index);
        }

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
    }
}
