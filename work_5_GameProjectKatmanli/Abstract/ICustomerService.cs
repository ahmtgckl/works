using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
