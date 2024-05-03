using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("anonimo")]
        [AllowAnonymous]
        public string Anonimo() => "Anonimo";

        [HttpGet("autenticado")]
        [Authorize]
        public string Autenticado() => $"Autenticado {User.Identity.Name}";

        [HttpGet("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "employee";

        [HttpGet("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "manager";
    }
}
