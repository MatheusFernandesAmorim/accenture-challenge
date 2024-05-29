using AccentureChallenge.UI.CQRS.Models;
using MediatR;

namespace AccentureChallenge.UI.CQRS.Resources.Queries
{
    public class GetByIdQuery : IRequest<Sales>
    {
        public int Id { get; set; }
    }
}
