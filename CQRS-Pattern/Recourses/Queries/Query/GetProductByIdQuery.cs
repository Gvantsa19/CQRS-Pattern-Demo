using MediatR;

namespace CQRS_Pattern.Recourses.Queries.Query
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
