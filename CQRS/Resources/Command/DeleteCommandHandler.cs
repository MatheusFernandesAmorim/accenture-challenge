using AccentureChallenge.Data.Context;
using AccentureChallenge.UI.CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AccentureChallenge.UI.CQRS.Resources.Command
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Sales>
    {
        private readonly ApplicationDbContext _context;

        public DeleteCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Sales> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var sale = await _context.Sales.Where(s => s.Id == request.Id).FirstOrDefaultAsync();

            _context.Remove(sale);

            await _context.SaveChangesAsync();

            return sale;
        }
    }
}
