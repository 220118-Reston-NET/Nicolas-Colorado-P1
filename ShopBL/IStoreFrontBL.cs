using ShopModel;

namespace ShopBL
{
    public interface IStoreFrontBL
    {
        /// <summary>
        /// Will add store info to the database.
        /// </summary>
        /// <param name="p_store"></param>
        /// <returns>Returns a store's information. </returns>
        StoreFront AddStoreFront(StoreFront p_store);

        /// <summary>
        /// Will give back all stores in the database in the form of a list.
        /// </summary>
        /// <returns> Returns a list collection of all stores in database. </returns>
        List<StoreFront> GetAllStoreFront();

        /// <summary>
        /// Will give back all stores in the database in the form of a list (Async version).
        /// </summary>
        /// <returns> Returns a list collection of all stores in database. </returns>
        Task<List<StoreFront>> GetAllStoreFrontAsync();

        /// <summary>
        /// Will give back a list of orders by stores. (There's only one currently).
        /// </summary>
        /// <param name="p_storeID"></param>
        /// <returns> Returns a list collection of order objects. </returns>
        List<Orders> GetOrderbyStoreID(int p_storeID);

        /// <summary>
        /// Will give back a list of products by store. (There's only one currently).
        /// </summary>
        /// <param name="p_storeID"></param>
        /// <returns> Returns a list collection of order objects. </returns>
        List<Product> GetProductbyStoreID(int p_storeID);


        /// <summary>
        /// Will allow store inventory to be replenished.
        /// </summary>
        /// <param name="p_inventory"></param>
        /// <returns> Returns an update to the inventory via product quantity.
        Inventory ReplenishInventory(Inventory p_inventory);

        // / <summary>
        // / Will allow customers to place orders.
        // / </summary>
        // / <param name="p_order"></param>
        // / <returns> Returns an order, total price, and update to the inventory. </returns>
        Orders PlaceNewOrder(Orders p_order);

    }
}