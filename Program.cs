using System.Globalization;

namespace AtividadeConstrutores
{
    internal class Program
    {
        static void Main(string[] args) {
            Banco banco;
            Console.Write("Entre o número da conta: ");
            int numero= int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char Requi = char.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (Requi == 's' || Requi == 'S') {
                Console.Write("Entre o valor de depósito inicial:");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                banco = new Banco(titular, numero, DepositoInicial);
            }
            else {
                banco = new Banco(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito:");
            double quanti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Deposito(quanti);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            quanti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Sacaque(quanti);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);


        }
    }
}
