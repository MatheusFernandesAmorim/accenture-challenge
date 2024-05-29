using AccentureChallenge.Data.Context;
using AccentureChallenge.UI.CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AccentureChallenge.UI.CQRS.Resources.Queries
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, Sales>
    {
        private readonly ApplicationDbContext _context;

        public GetByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Sales> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Sales.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
        }
    }
}