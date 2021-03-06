using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfPrinter.Models
{
    public class DbApi
    {
        private DeviceContext _dbDeviceContext;
        public DbApi()
        {
            _dbDeviceContext = new DeviceContext();
        }

        public List<Fastighet> Fastigheter => _dbDeviceContext.FastighetObject.ToList();
        
        public List<Appartment> Appartments => _dbDeviceContext.AppartmentObject.ToList();

        public Appartment AppartmentById(int appartmentId)
        {
            return _dbDeviceContext.AppartmentObject.Find(appartmentId);
        }

        public void SaveApparment(Appartment appartment)
        {
            _dbDeviceContext.AppartmentObject.Add(appartment);
            _dbDeviceContext.SaveChanges();
        }

        public void SaveRenter(Renter renter)
        {
            _dbDeviceContext.RenterObject.Add(renter);
            _dbDeviceContext.SaveChanges();
        }

        public void SaveFastighet(Fastighet fastighet)
        {
            _dbDeviceContext.FastighetObject.Add(fastighet);
            _dbDeviceContext.SaveChanges();
        }

    }
}
