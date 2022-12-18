using CQRS_Pattern.Recourses.Queries.Query;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Pattern.Recourses.Queries.Handler
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ProductDBContext _context;

        public GetProductByIdQueryHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
            await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

    }
}
