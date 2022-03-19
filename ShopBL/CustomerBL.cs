using ShopDL;
using ShopModel;


namespace ShopBL
{
    public class CustomerBL : ICustomerBL
    {
        //Dependency injection Pattern
        //This will save time on rewriting code without compiler helping
        private IRepository _repo;
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //====================================


        public Customer AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer);
        }


        public Customer UpdateCustomer(Customer p_customer)
        {
            return _repo.UpdateCustomer(p_customer);
        }


        public List<Orders> GetOrderbyCustomerID(int p_customerID)
        {
            return _repo.GetOrderbyCustomerID(p_customerID);
        }


        public List<Customer> GetCustomerbyName(string p_Name)
        {
            List<Customer> listCustomer = _repo.GetAllCustomer();

            var searchname = listCustomer.Find(p => p.Name.Contains(p_Name));
            if (searchname != null)
            {
                return listCustomer
                            .Where(customer => customer.Name.Contains(p_Name))
                            .ToList();
            }
            else 
            {
                throw new Exception("This customer name cannot be found.");
            }
        }

        
        public List<Customer> GetCustomerbyEmail(string p_Email)
        {
            List<Customer> listCustomer = _repo.GetAllCustomer();

            var searchname = listCustomer.Find(p => p.Email.Contains(p_Email));
            if (searchname != null)
            {
                return listCustomer
                            .Where(customer => customer.Email.Equals(p_Email))
                            .ToList();
            }
            else 
            {
                throw new Exception("This customer email cannot be found.");
            }
        }


        public List<Customer> GetAllCustomer()
        {
            return _repo.GetAllCustomer();
        }


        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _repo.GetAllCustomerAsync();
        }

            
    }
}
