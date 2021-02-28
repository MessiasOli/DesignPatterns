using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adapter com MercadoPago");
        }

        public Token AuthToken()
        {
           return mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            mercadoPago.RealizarPagamento();
        }

        public void PayPalReceive()
        {
            mercadoPago.ReceberPagamento();
        }
    }
}
