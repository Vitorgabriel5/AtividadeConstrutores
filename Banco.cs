using System.Globalization;
using System.Runtime.CompilerServices;

namespace AtividadeConstrutores {
    internal class Banco {
        public string Titular { get; set; }
        public int NumeroConta {  get; private set; }
        public double Saldo {  get; private set; }

        public Banco(string titular, int numeroConta) {
            Titular = titular;
            NumeroConta = numeroConta;
        }

        public Banco(string titular, int numeroConta, double saldo) : this(titular, numeroConta) {
            Saldo = saldo;
        }

        public void Deposito(double quant) {
            Saldo += quant;
        }
        public void Sacaque(double quant) { 
            Saldo -= quant + 5.0; 
        }
    
          
        public override string ToString() {
            return "Conta "
                + NumeroConta
                + " Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
