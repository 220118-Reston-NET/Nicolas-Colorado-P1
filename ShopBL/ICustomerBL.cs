using ShopModel;

namespace ShopBL
{
    //Business Layer is reponsible for furtehr validation of data
    //obtained from database or user
    public interface ICustomerBL
    {
        /// <summary>
        /// Will add customer information to the database.
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns>Returns a customer's information. </returns>
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
        /// Gets back a customer from a customer name input.
        /// </summary>
        /// <param name="p_customerID"></param>
        /// <returns> Returns customer that was added. </returns>
        List<Customer> GetCustomerbyName(string p_Name);

        /// <summary>
        /// Gets back a customer from a customer email input.
        /// </summary>
        /// <param name="p_Email"></param>
        /// <returns> Returns customer that was added. </returns>
        List<Customer> GetCustomerbyEmail(string p_Email);

    }
}