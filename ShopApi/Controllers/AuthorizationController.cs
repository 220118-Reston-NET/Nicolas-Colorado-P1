using System.Data.SqlClient;
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
        public IActionResult GetManager(int p_managerID, string p_password)
        {
            //try
            //{
                Log.Information("Successfully returned all current manager.");
                return Ok(_storeBL.GetManager(p_managerID, p_password));
            //}
            //catch (SqlException ex)
           // {
                //Log.Warning("Could not find managers.");
                
            //}
        }
    }
}