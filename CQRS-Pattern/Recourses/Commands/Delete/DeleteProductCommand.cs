using MediatR;

namespace CQRS_Pattern.Recourses.Commands.Delete
{
    public class DeleteProductCommand  : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
