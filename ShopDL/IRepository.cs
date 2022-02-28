using ShopModel;

namespace ShopDL
{
    //This is the Data Layer responsible for interacting with our database
    //CRUD = Create, read, Update, Delete
    public interface IRepository
    {
        /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns> Returns customer that was added. </returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// Updates a customer to the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns> Returns customer that was updated. </returns>
        Customer UpdateCustomer(Customer p_customer);

        /// <summary>
        /// Will give back all customers in the database in the form of a list.
        /// </summary>
        /// <returns> Returns a list collection of all customers in database. </returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// Will give back all customers in the database in the form of a list (Async version).
        /// </summary>
        /// <returns> Returns a list collection of all customers in database. </returns>
        Task<List<Customer>> GetAllCustomerAsync();

        /// <summary>
        /// Will give back a list of orders by customer (There's only one currently).
        /// </summary>
        /// <param name="p_customerID"></param>
        /// <returns> Returns a list collection of order objects. </returns>
        List<Orders> GetOrderbyCustomerID(int p_customerID);

        /// <summary>
        /// Will add store info to the database.
        /// </summary>
        /// <param name="p_store"></param>
        /// <returns>Returns a store's information. </returns>
        StoreFront AddStoreFront(StoreFront p_store);

        // <summary>
        /// Will give back all the store fronts in the database (There's only one currently).
        /// </summary>
        /// <returns> Returns all store fronts. </returns>
        List<StoreFront> GetAllStoreFront();

        // <summary>
        /// Will give back all the store fronts in the database (Async version).
        /// </summary>
        /// <returns> Returns all store fronts. </returns>
        Task<List<StoreFront>> GetAllStoreFrontAsync();

        /// <summary>
        /// Will give back a list of orders by store. (There's only one currently).
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
        /// <returns> StoreID, Product ID and the updated product quantity. </returns>
        Inventory ReplenishInventory(Inventory p_inventory);

        /// <summary>
        /// Will allow customers to place orders.
        /// </summary>
        /// <param name="p_order"></param>
        /// <returns> Returns an order, total price, and update to the inventory. </returns>
        Orders PlaceNewOrder(Orders p_order);

        /// <summary>
        /// Will add line items to the order.
        /// </summary>
        /// <param name="p_order"></param>
        /// <returns> Returns line item objects. </returns>
        List<LineItem> AddLineItem(Orders p_order);

        /// <summary>
        /// Will return line items by order ID to be displayed in order history.
        /// </summary>
        /// <param name="p_orderID"></param>
        /// <returns> Returns line items by order ID. </returns>
        List<LineItem> GetLineItemsbyOrderID(Guid p_orderID);

    }
}
