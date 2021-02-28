using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void RealizarPagamento()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago");
        }

        public void ReceberPagamento()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago");
        }
    }
}
