using AccentureChallenge.Data.Context;
using AccentureChallenge.UI.CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace AccentureChallenge.UI.CQRS.Resources.Queries
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, IEnumerable<Sales>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Sales>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            return await _context.Sales.ToListAsync();
        }
    }
}