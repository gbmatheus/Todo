namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllersBase
    {
        [HttpGet]
        public IActionResult GetAllTodo()
        {
            
            return Ok();
        }

    }
}