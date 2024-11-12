using MucoaSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms; // Para aplicação Windows Forms

public class EncomendaManager
{
    // BindingList para permitir atualizações automáticas no DataGridView
    private BindingList<Encomenda> listaEncomendas = new BindingList<Encomenda>();

    // Propriedade para acessar a lista de encomendas
    public BindingList<Encomenda> ListaEncomendas => listaEncomendas;
    // Método para adicionar uma encomenda à lista
    public void AdicionarEncomenda(Encomenda encomenda)
    {
        listaEncomendas.Add(encomenda);
    }

    // Método para preencher o GridView com as encomendas
    public void PreencherGridView(DataGridView gridView)
    {
        gridView.DataSource = null; // Limpa a fonte de dados para atualizar
        gridView.DataSource = listaEncomendas; // Define a lista como fonte de dados
    }
}
