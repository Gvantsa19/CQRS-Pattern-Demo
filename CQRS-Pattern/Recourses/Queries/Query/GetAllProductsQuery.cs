using MediatR;

namespace CQRS_Pattern.Recourses.Queries.Query
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
