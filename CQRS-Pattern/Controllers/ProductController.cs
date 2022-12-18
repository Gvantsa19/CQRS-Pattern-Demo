using CQRS_Pattern.Recourses.Commands.Create;
using CQRS_Pattern.Recourses.Commands.Delete;
using CQRS_Pattern.Recourses.Commands.Update;
using CQRS_Pattern.Recourses.Queries.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Pattern.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> List([FromQuery] GetAllProductsQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet("{id:int}")]
        public async Task<Product> GetById(GetProductByIdQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("create")]
        public async Task<Product> Create(CreateProductCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("delete")]
        public async Task<Product> Delete(DeleteProductCommand command)
        {
            return  await _mediator.Send(command);
        }

        [HttpPut("update")]
        public async Task<Product> Update(UpdateProductCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
