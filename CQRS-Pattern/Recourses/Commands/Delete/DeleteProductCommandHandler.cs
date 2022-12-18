using MediatR;

namespace CQRS_Pattern.Recourses.Commands.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly ProductDBContext _context;

        public DeleteProductCommandHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == request.Id);
            if (product == null) { return default; }
            _context.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
