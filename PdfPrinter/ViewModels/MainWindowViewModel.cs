using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PdfPrinter.Models;

namespace PdfPrinter.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private DbApi _dbApi;
        public ICommand PrintPdf => new RelayCommand(x => OnPrintRequest());
        //private Sele
        public ObservableCollection<FastigheterViewModel> FastighetItems { get; } = new ObservableCollection<FastigheterViewModel>();
        private void OnPrintRequest()
        {
            //AddMockdata();
           
        }

        private void AddMockdata()
        {
            var all = _dbApi.Appartments;

            _dbApi.SaveFastighet(new Fastighet
            {
                FastighetAddress = "Dahlemsgatan 8",
                FastighetName = "Tryckaren 7"
            });

            _dbApi.SaveFastighet(new Fastighet
            {
                FastighetAddress = "Sörgårdsgatan 3",
                FastighetName = "Uttern 9"
            });

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "836",
                AppartmentRent = 5091,
                FastighetId = 1
            });

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "837",
                AppartmentRent = 5391,
                FastighetId = 1
            });

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "838",
                AppartmentRent = 4391,
                FastighetId = 1
            });

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "1",
                AppartmentRent = 1029,
                FastighetId = 2
            });


            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "2",
                AppartmentRent = 1329,
                FastighetId = 2
            });

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "3",
                AppartmentRent = 1529,
                FastighetId = 2
            });


            _dbApi.SaveRenter(new Renter
            {
                RenterName = "Anders Olof Selborn",
                AppartmentId = 1
            });

            _dbApi.SaveRenter(new Renter
            {
                RenterName = "Jan Olof Selborn",
                AppartmentId = 2
            });

            _dbApi.SaveRenter(new Renter
            {
                RenterName = "Viktor Olof Selborn",
                AppartmentId = 3
            });
        }

        public MainWindowViewModel()
        {
            _dbApi = new DbApi();
            var apps = _dbApi.Appartments;
            var fList = _dbApi.Fastigheter.OrderBy(s => s.FastighetName).ToList();

            foreach (var item in fList)
            {
                FastighetItems.Add(new FastigheterViewModel
                {
                    FastighetName = item.FastighetName,
                    FastighetId = item.FastighetId
                });
            }

            

        }


    }
}
