using System; 

namespace Aula2
{
    public class Agencias
    {
        private string nome;
        private string numero { get; set; }
        public Agencias (){
            Console.WriteLine("Adicione o numero da agencia: ");
            string numero = Console.ReadLine();
            this.numero = numero;
        }

        public void saveAgency(){
            Console.WriteLine("Adicione o nome da agencia: ");
            string nome = Console.ReadLine();
            this.nome = nome;
        }

        public void writeAgency(){
            Console.WriteLine("Nome da agencia: "+this.nome+"\nNumero da agencia: "+this.numero);
        } 
    }
}