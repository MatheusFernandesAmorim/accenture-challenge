using AccentureChallenge.UI.CQRS.Models;
using MediatR;

namespace AccentureChallenge.UI.CQRS.Resources.Command
{
    public class DeleteCommand : IRequest<Sales>
    {
        public int Id { get; set; }
    }
}
