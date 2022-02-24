using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ShopBL;
using ShopModel;

/*
    This Controller for Customer was autogenerated by utilizing aspnet-codegenerator tool
    (find url in notes)

    -To Start
    --Install tool first = dotnet tool install -g dotnet-aspnet-codegenerator
    ---Add package to api project = dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

    **Check notes for directions on creating a Controller.
*/


namespace ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //Customer dependency injection
        private ICustomerBL _customerBL;

        private IMemoryCache _memoryCache;

        public CustomerController(ICustomerBL p_customerBL, IMemoryCache p_memoryCache)
        {
            _customerBL = p_customerBL;
            _memoryCache = p_memoryCache;
        }
        //------------------------------------------------------

        // GET: api/Customer
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            try
            {
                List<Customer> listofCustomer = new List<Customer>();
                //TryGetValue (check if the cache still exists and if it does "out listofCustomer" puts that data inside our variable)
                if (!_memoryCache.TryGetValue("CustomerList", out listofCustomer))
                {
                    listofCustomer = await _customerBL.GetAllCustomerAsync();
                    _memoryCache.Set("CustomerList", listofCustomer, new TimeSpan(0, 0, 30));
                }

                return Ok(listofCustomer);
            }
            catch (SqlException)
            {
                //The Api iss responsible for sending the right resource and right status code
                //In this case, if it was unable to connect to the database, it'll give a 404 status code
                return NotFound();
            }
            
        }

        // GET: api/Customer/5
        [HttpGet]
        public IActionResult GetCustomerByName([FromQuery] string customerName)
        {
            try
            {
                return Ok(_customerBL.GetCustomerbyName(customerName));
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        // POST: api/Customer
        [HttpPost("AddCustomer")]
        public IActionResult Post([FromBody] Customer p_customer)
        {
            try
            {
                return Created("Successfully added", _customerBL.AddCustomer(p_customer));
            }
            catch (System.Exception ex)
            {
                
                return Conflict(ex.Message);
            }
        }

        // PUT: api/Customer/5
        [HttpPut("Update{customerID}")]
        public IActionResult Put(int customerID, [FromBody] Customer p_customer)
        {
            try
            {
                return Ok(_customerBL.UpdateCustomer(p_customer));
            }
            catch (System.Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // GET: api/Customer/5
        [HttpGet("ViewOrderByCustomerID/{customerID}")]
        public IActionResult GetOrderbyCustomerID(int customerID)
        {
            try
            {
                return Ok(_customerBL.GetOrderbyCustomerID(customerID));
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
