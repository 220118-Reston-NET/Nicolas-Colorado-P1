using ShopDL;
using ShopModel;

namespace ShopBL
{
    public class StoreFrontBL : IStoreFrontBL
    {
        //Dependency injection Pattern
        //This will save time on rewriting code without compiler helping
        private IRepository _repo;
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //====================================



        public List<Orders> GetOrderbyStoreID(int p_storeID)
        {
            return _repo.GetOrderbyStoreID(p_storeID);
        }


        public List<Product> GetProductbyStoreID(int p_storeID)
        {
            return _repo.GetProductbyStoreID(p_storeID);
        }


        public List<StoreFront> GetAllStoreFront()
        {
            return _repo.GetAllStoreFront();
        }


        public async Task<List<StoreFront>> GetAllStoreFrontAsync()
        {
            return await _repo.GetAllStoreFrontAsync();
        }

        public List<Manager> GetManager(int p_managerID, string p_password)
        {
            return _repo.GetManager(p_managerID, p_password);
        }

        public bool isAdmin(int p_managerID, string p_password)
        {
            try
            {
                Manager manager = new Manager();
                manager = GetManager(p_managerID, p_password).Where(manager => manager.managerID.Equals(p_managerID) && manager.password.Equals(p_password)).First();
                return manager.isAdmin;
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        public Inventory ReplenishInventory(Inventory p_inventory)
        {
            return _repo.ReplenishInventory(p_inventory);
        }


        public Orders PlaceNewOrder(Orders p_order)
        {
            return _repo.PlaceNewOrder(p_order);
        }
    }
}