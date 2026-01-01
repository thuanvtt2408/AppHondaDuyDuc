using AppHondaDuyDuc.Backend.Models;
using AppQuanLySuaXe.Backend.Repositories;

namespace AppHondaDuyDuc.Controllers
{
    public class CustomerController
    {
        private readonly CustomerRepository _repo = new();

        public List<Customer> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
