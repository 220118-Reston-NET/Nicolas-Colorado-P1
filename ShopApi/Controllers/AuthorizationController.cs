using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBL;
using ShopModel;


namespace ShopApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        //Dependency Injection
        private IStoreFrontBL _storeBL;
        public AuthorizationController(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        [HttpGet("GetAllManager")]
        public IActionResult GetManager([FromQuery] int p_managerID, string p_password)
        {
            try
            {
                if (p_password == null)
                {
                    Log.Information("User did not input a password for the manager.");
                    throw new Exception("You did not input the manager's password!");
                }
                else if (p_managerID == 0)
                {
                    Log.Information("User did not input a manager ID for the manager.");
                }
                Log.Information("Successfully returned all current manager.");
                return Ok(_storeBL.GetManager(p_managerID, p_password));
            }
            catch (SqlException ex)
            {
                Log.Warning("Could not find managers.");
                return NotFound(ex.Message);
                
            }
        }
    }
}