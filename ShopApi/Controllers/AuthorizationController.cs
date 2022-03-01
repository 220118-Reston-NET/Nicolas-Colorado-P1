using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using ShopBL;
using ShopModel;


namespace ShopApi.Controllers

{
    [Route("[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        //Dependency Injection
        private IStoreFrontBL _storeBL;
        public AuthorizationController(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        [HttpGet("Manager")]
        public IActionResult GetManager(int p_managerID, string p_password)
        {
            try
            {
                return Ok(_storeBL.GetManager(p_managerID, p_password));
            }
            catch (SqlException ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}