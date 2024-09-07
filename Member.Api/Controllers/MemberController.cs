using Member.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Member.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberServices _memberServices;
        public MemberController(IMemberServices memberServices) { 
            _memberServices = memberServices;
        }
        [HttpGet]
        public ActionResult<IList<Domain.Member>> Get()
        {
            return Ok(_memberServices.GetAllMembers());
        }
    }
}
