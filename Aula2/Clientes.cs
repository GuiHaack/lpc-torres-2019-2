using System;

namespace Aula2
{
    public class Clientes
    {
        private string nome;
        private string codigo;

        public void nameSave(){
            Console.WriteLine("Nome do cliente: ");
            string nome = Console.ReadLine();
            this.nome = nome;
        }

        public void codSave(){
            Console.WriteLine("Codigo do cliente: ");
            string codigo = Console.ReadLine();
            this.codigo = codigo;
        }

        public void dataWrite(){
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("Codigo: "+this.codigo);
        }

        public string getName(){
            return this.nome;
        }
        public string getCodigo(){
            return this.codigo;
        }

    }
}