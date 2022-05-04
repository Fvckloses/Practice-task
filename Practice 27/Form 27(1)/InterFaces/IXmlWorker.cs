using Form_26_1_.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_26_1_.InterFaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Parking parking);
        void Delete(string mark);
        Parking FindBy(string mark);
        List<Parking> GetAll();
    }
}
