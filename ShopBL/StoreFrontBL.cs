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


        public void ReplenishInventory(int p_productID, int p_Quantity, int p_storedID)
        {
            _repo.ReplenishInventory(p_productID, p_Quantity, p_storedID);
        }


        public void PlaceNewOrder(int p_customerID, int p_storeID, double p_priceTotal, List<LineItem> p_orderedItems)
        {
            _repo.PlaceNewOrder(p_customerID, p_storeID, p_priceTotal, p_orderedItems);
        }

    }
}