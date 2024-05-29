using AccentureChallenge.UI.CQRS.Models;
using MediatR;

namespace AccentureChallenge.UI.CQRS.Resources.Command
{
    public class AddCommand : IRequest<Sales>
    {
        public string AccountID { get; set; }
        public string TransactionID { get; set; }
        public string TransactionAmount { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public int LocalHour { get; set; }
        public string TransactionScenario { get; set; }
        public string TransactionType { get; set; }
        public string TransactionIPAddress { get; set; }
        public string IPState { get; set; }
        public string IPPostalCode { get; set; }
        public string IPCountry { get; set; }
        public bool IsProxyIP { get; set; }
        public int BrowserLanguage { get; set; }
        public string PaymentInstrumentType { get; set; }
        public string CardType { get; set; }
        public string PaymentBillingPostalCode { get; set; }
        public string PaymentBillingState { get; set; }
        public string PaymentBillingCountryCode { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string CvvVerifyResult { get; set; }
        public int DigitalItemCount { get; set; }
        public int PhysicalItemCount { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
