using RealLifeInandAbs.Abstract;
using RealLifeInandAbs.Entites;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealLifeInandAbs.Adapters
{
    public class MernisSeviceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
