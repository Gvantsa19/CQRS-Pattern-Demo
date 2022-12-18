using MediatR;

namespace CQRS_Pattern.Recourses.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>    
    {
        private readonly ProductDBContext _context;

        public CreateProductCommandHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var res = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Category = command.Category,
                Price = command.Price,
            };
            _context.Products.Add(res);
            await _context.SaveChangesAsync();
            return res;
        }
    }
}
