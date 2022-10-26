using System.Globalization;
using Interface2.Entities;


namespace Interface2.Services
{
    internal class ContratoService
    {
        public int QuantityParcelas { get; set; }
        private IPaymentService _paymentService;

        public ContratoService(int quantityParcelas, IPaymentService paymentService)
        {
            QuantityParcelas = quantityParcelas;
            _paymentService = paymentService;
        }

        public void GenerateParcela(Contrato contrato)
        {
            double new_value = contrato.TotalValue / QuantityParcelas;
            for(int i = 1; i <= QuantityParcelas; i++)
            {
                DateTime date = contrato.Date.AddMonths(i);
                double value = _paymentService.Payment(new_value, i);
                contrato.AddParcela(new Parcela(date, value));
            }
        }
    }
}
