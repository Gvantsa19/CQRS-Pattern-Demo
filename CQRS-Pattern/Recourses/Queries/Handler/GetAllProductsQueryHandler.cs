using CQRS_Pattern.Recourses.Queries.Query;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Pattern.Recourses.Queries.Handler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly ProductDBContext _context;

        public GetAllProductsQueryHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken) =>
            await _context.Products.ToListAsync(cancellationToken).ConfigureAwait(false);
    }
}
