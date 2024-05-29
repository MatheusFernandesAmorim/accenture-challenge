using AccentureChallenge.Data.Context;
using AccentureChallenge.UI.CQRS.Models;
using MediatR;

namespace AccentureChallenge.UI.CQRS.Resources.Command
{
    public class AddCommandHandler : IRequestHandler<AddCommand, Sales>
    {
        private readonly ApplicationDbContext _context;

        public AddCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Sales> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            var sale = new Sales();

            sale.AccountID = request.AccountID;
            sale.TransactionID = request.TransactionID;
            sale.TransactionAmount = request.TransactionAmount;
            sale.TransactionCurrencyCode = request.TransactionCurrencyCode;
            sale.LocalHour = request.LocalHour;
            sale.TransactionScenario = request.TransactionScenario;
            sale.TransactionType = request.TransactionType;
            sale.TransactionIPAddress = request.TransactionIPAddress;
            sale.IPState = request.IPState;
            sale.IPPostalCode = request.IPPostalCode;
            sale.IPCountry = request.IPCountry;
            sale.IsProxyIP = request.IsProxyIP;
            sale.BrowserLanguage = request.BrowserLanguage;
            sale.PaymentInstrumentType = request.PaymentInstrumentType;
            sale.CardType = request.CardType;
            sale.PaymentBillingPostalCode = request.PaymentBillingPostalCode;
            sale.PaymentBillingState = request.PaymentBillingState;
            sale.PaymentBillingCountryCode = request.PaymentBillingCountryCode;
            sale.ShippingPostalCode = request.ShippingPostalCode;
            sale.ShippingState = request.ShippingState;
            sale.ShippingCountry = request.ShippingCountry;
            sale.CvvVerifyResult = request.CvvVerifyResult;
            sale.DigitalItemCount = request.DigitalItemCount;
            sale.PhysicalItemCount = request.PhysicalItemCount;
            sale.TransactionDateTime = request.TransactionDateTime;

            _context.Sales.Add(sale);

            await _context.SaveChangesAsync();

            return sale;
        }
    }
}
