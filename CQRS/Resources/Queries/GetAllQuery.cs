using AccentureChallenge.UI.CQRS.Models;
using MediatR;

namespace AccentureChallenge.UI.CQRS.Resources.Queries
{
    public class GetAllQuery : IRequest<IEnumerable<Sales>>
    {
    }
}
