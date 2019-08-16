using System;

namespace Aula2
{
    public class CartãoDeCredito
    {
        private string numero;
        private string dataValidade;
        private Clientes cliente;

        public void saveClient(Clientes cliente){
            Console.WriteLine("Proprietario do cartão: "+cliente.getName());
            this.cliente = cliente;
            this.cliente.dataWrite();
        }
        public void saveNumber(){
            Console.WriteLine("Adicione o numero do cartão: ");
            string numero = Console.ReadLine();
            this.numero = numero;
        } 
        public void saveDate(){
            Console.WriteLine("Adicione a data de validade do cartão: ");
            string validade = Console.ReadLine();
            this.dataValidade = validade;
        }

        public void writeData(){
            Console.WriteLine("Proprietario do Cartão: "+cliente.getName()+"\nNumero do cartão: "+this.numero+"\nData de validade: "+this.dataValidade);
        } 
    }
}