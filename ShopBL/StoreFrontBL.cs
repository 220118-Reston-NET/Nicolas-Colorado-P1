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



        public StoreFront AddStoreFront(StoreFront p_store)
        {
            return _repo.AddStoreFront(p_store);
        }


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


        public Inventory ReplenishInventory(Inventory p_inventory)
        {
            return _repo.ReplenishInventory(p_inventory);
        }


        // public Orders PlaceNewOrder(Orders p_order)
        // {
        //     return _repo.PlaceNewOrder(p_order);
        // }

    }
}