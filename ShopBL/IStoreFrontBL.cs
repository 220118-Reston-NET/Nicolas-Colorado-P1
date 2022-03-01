using ShopModel;

namespace ShopBL
{
    public interface IStoreFrontBL
    {
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
        /// <returns> Returns an update to the inventory via product quantity. </returns>
        Inventory ReplenishInventory(Inventory p_inventory);

        /// <summary>
        /// Will search for a specific manager.
        /// </summary>
        /// <param name="p_managerID"></param>
        /// <param name="p_password"></param>
        /// <returns> Returns a searched manager. </returns>
        List<Manager> GetManager(int p_managerID, string p_password);

        /// <summary>
        /// Will check if managerID and .
        /// </summary>
        /// <param name="p_managerID"></param>
        /// <param name="p_password"></param>
        /// <returns> Returns a manager that is an admin. </returns>
        bool isAdmin(int p_managerID, string p_password);

        ///<summary>
        ///Will allow customers to place orders.
        ///</summary>
        ///<param name="p_order"></param>
        ///<returns> Returns an order, total price, and update to the inventory. </returns>
        Orders PlaceNewOrder(Orders p_order);

    }
}