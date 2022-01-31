using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Abstract
{
    public interface IValidationService
    {
        bool IsValid(Customer customer);
    }
}
