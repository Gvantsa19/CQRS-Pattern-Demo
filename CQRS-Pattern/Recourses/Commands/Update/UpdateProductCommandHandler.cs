using MediatR;

namespace CQRS_Pattern.Recourses.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly ProductDBContext _context;

        public UpdateProductCommandHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == command.Id);
            if (product == null) { return default; }

            product.Name = command.Name;
            product.Description = command.Description;
            product.Category = command.Category;
            product.Price = command.Price;

            await _context.SaveChangesAsync();
            return product;
        }
    }
}
