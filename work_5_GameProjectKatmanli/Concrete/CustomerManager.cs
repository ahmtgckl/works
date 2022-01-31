using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Abstract;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Concrete
{
    public class CustomerManager
    {
        private IValidationService _validationService;

        public CustomerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Customer customer)
        {
            if (_validationService.IsValid(customer))
            {
                Console.WriteLine(customer.FirstName + " isimli kullanıcı eklendi.");
            }
            else
            {
                Console.WriteLine("Kişi bilgileri hatalı!");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli kullanıcı güncellendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli kullanıcı silindi.");
        }
    }
}
