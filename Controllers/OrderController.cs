using AppHondaDuyDuc.Backend.Models;
using AppHondaDuyDuc.Repositories;

namespace AppHondaDuyDuc.Controllers
{
    public class OrderController
    {
        private readonly OrderRepository _repo = new();

        public List<Order> GetAll()
        {
            return _repo.GetAll();
        }

        public void Create(Order order)
        {
            _repo.Insert(order);
        }
    }
}
