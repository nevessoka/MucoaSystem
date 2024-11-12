using MucoaSystem.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms; // Para aplicação Windows Forms

public class ClienteManager
{
    // Lista para armazenar os clientes
    private List<Cliente> listaClientes = new List<Cliente>();

    // Método para adicionar um cliente à lista
    public void AdicionarCliente(Cliente cliente)
    {
        listaClientes.Add(cliente);
    }

    // Método para preencher o GridView
    public void PreencherGridView(DataGridView gridView)
    {
        gridView.DataSource = null; // Limpa a fonte de dados para atualizar
        gridView.DataSource = listaClientes; // Define a lista como fonte de dados
    }
}
