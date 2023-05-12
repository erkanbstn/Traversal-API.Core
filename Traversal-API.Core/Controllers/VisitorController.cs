using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_API.Core.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly IVisitorService _visitorService;

        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        [HttpGet]
        public IActionResult VisitorList()
        {
            var values = _visitorService.YouCanList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddVisitor(Visitor visitor)
        {
            _visitorService.YouCanInsert(visitor);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            _visitorService.YouCanUpdate(visitor);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteVisitor(int id)
        {
            _visitorService.YouCanDelete(_visitorService.YouCanGetById(id));
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetVisitor(int id)
        {
            var values = _visitorService.YouCanGetById(id);
            if (values != null)
            {
                return Ok(values);
            }
            return NotFound();
        }
    }
}
