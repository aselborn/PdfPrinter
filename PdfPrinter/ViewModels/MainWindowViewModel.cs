using System;
using System.Collections.Generic;
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

        private void OnPrintRequest()
        {

            var all = _dbApi.Appartments;

            _dbApi.SaveApparment(new Appartment
            {
                AppartmentNumber = "10",
                AppartmentId = 1
            }
            );

        }


        public MainWindowViewModel()
        {
            _dbApi = new DbApi();
            var apps = _dbApi.Appartments;
        }


    }
}
