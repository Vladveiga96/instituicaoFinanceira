using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        private long numero;
        private decimal saldo;

        public Conta(long numero, decimal saldoInicial = 0)
        {
            this.numero = numero;
            this.saldo = saldoInicial;
        }

        public Conta()
        {
            Random random = new Random();
            numero = random.Next(100000, 999999);
            saldo = 0;
        }

        public long Numero
        {
            get { return numero; }
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        // Método de depósito (igual ao da imagem)
        public void deposito(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        // Método de saque (retorna saldo após operação, sem permitir saldo negativo)
        public decimal saque(decimal valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
            }
            return saldo;
        }

        // Método estático para descobrir qual conta tem o maior saldo
        public static Conta ContaComMaiorSaldo(Conta c1, Conta c2)
        {
            return c1.saldo >= c2.saldo ? c1 : c2;
        }
    }
}
  