using System;

namespace Aula2
{
    public class Contas
    {
        private string numero; 
        private double saldo;
        private double limite = 100;
        private string referencia;
         public Contas(string referencia){
            this.limite = 100;
            this.referencia = referencia;
        }
        public void newClient(){
            Console.WriteLine("Numero da conta: ");
            string numero = Console.ReadLine();
            this.numero = numero;

            Console.WriteLine("Saldo da conta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            this.saldo = saldo;

            Console.WriteLine("Limite da conta: ");
            double limite = Convert.ToDouble(Console.ReadLine());
            this.limite += limite;
        }
        public string getNum(){
            return this.numero;
        } 

        public void writeClient(){
            Console.WriteLine("Numero da conta: "+this.numero+"\nSaldo da conta: "+this.saldo+"\nLimite da conta: "+this.limite);
        }
        public void writeSaldo(){
            Console.WriteLine("Saldo da conta: "+this.saldo);
        }

        public void deposito(){
            Console.WriteLine("Quanto deseja depositar? ");
            this.saldo += Convert.ToDouble(Console.ReadLine());
        }
        public void saque(){
            Console.WriteLine("Quanto deseja sacar? ");
            this.saldo -= Convert.ToDouble(Console.ReadLine());
        }

        public Contas transferencia(Contas conta2){
            Console.WriteLine("Quanto deseja trasferir para a conta: "+conta2.getNum());
            double quantidade = Convert.ToDouble(Console.ReadLine());
            this.saldo -= quantidade;
            conta2.saldo += quantidade;
            return conta2;
        }
    }
}