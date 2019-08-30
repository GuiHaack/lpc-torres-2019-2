using System;
using System.Collections.Generic;

namespace aula05_exercicio_static.Models
{
    public class Cliente
    {
        public static int autoIncrement = 1;
        public List<ClienteModel> listaClientes = new List<ClienteModel>();

        public Cliente()
        {
            this.CreateCliente(new ClienteModel{
                nome = "Cliente 1",
                cpf = "11111111111"
            });

            this.CreateCliente(new ClienteModel{
                nome = "Cliente 2",
                cpf = "22222222222"
            });

            this.CreateCliente(new ClienteModel{
                nome = "Cliente 3",
                cpf = "33333333333"
            });
        }

        public void CreateCliente(ClienteModel clienteModelo)
        {
            clienteModelo.id = Cliente.autoIncrement++;
            listaClientes.Add(clienteModelo);
        }

        public void UpdateCliente(ClienteModel clienteModelo)
        {
            listaClientes.Find(cli => cli.id == clienteModelo.id).nome = clienteModelo.nome;
        }

        public ClienteModel GetCliente(int id)
        {
            ClienteModel _cliente = listaClientes.Find(cli => cli.id == id);

            return _cliente;
        }

        public List<ClienteModel> GetAllCliente()
        {
            return listaClientes;
        }

        public void DeleteCliente(int id)
        {
            listaClientes.Remove(listaClientes.Find(cli => cli.id == id));
        }
    }
}