using RealLifeInandAbs.Abstract;
using RealLifeInandAbs.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealLifeInandAbs.Concrete
{
    internal class NeroCustomerManager : BaseCustomerManager
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
