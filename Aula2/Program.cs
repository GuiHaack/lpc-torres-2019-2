using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente1 = new Clientes();
            cliente1.nameSave();
            cliente1.codSave();
            cliente1.dataWrite();

            Clientes cliente2 = new Clientes();
            cliente2.nameSave();
            cliente2.codSave();
            cliente2.dataWrite();

            /**************************************/
         
            CartãoDeCredito cartao1 = new CartãoDeCredito();
            cartao1.saveClient(cliente1);
            cartao1.saveNumber();
            cartao1.saveDate();
            cartao1.writeData();

            CartãoDeCredito cartao2 = new CartãoDeCredito();
            cartao2.saveClient(cliente2);
            cartao2.saveNumber();
            cartao2.saveDate();
            cartao2.writeData();
            
            /**************************************/

            Agencias agencia1 = new Agencias();
            agencia1.saveAgency();
            agencia1.writeAgency();

            Agencias agencia2 = new Agencias();
            agencia2.saveAgency();
            agencia2.writeAgency();

            /**************************************/
 
            Contas conta1 = new Contas("referencia1");
            conta1.newClient();
            conta1.deposito();
            conta1.writeSaldo();
            conta1.saque();
            conta1.writeClient();
        
            Contas conta2 = new Contas("referencia2");
            conta2.newClient(); 
            conta2.deposito();
            conta2.writeSaldo();
            conta2.saque();
            conta2.transferencia(conta1);
            conta2.writeClient();

            /**************************************/
            
            Gerente gerente = new Gerente();
            gerente.aumento();
            gerente.aumento(20);
        }
    }
}
