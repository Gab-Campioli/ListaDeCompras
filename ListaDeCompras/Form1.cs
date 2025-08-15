using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Verificar se txtInserir está vazio:
            if(txbInserir.Text.Length == 0)
            {
                MessageBox.Show("Você precisa inserir um valor.", 
                    "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Mudar cor do fundo e da letra
                txbInserir.BackColor = Color.Crimson;
                txbInserir.ForeColor = Color.White;
            }
            else if (txbInserir.Text.Length < 2)
            {
                MessageBox.Show("O nome do produtor precisar ter no mínimo duas letras!!",
                    "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txbInserir.BackColor = Color.Crimson;
                txbInserir.ForeColor = Color.White;

            }
            else
            {
                // Verificar se o item esta na lista:
                if (libLista.Items.Contains(txbInserir))
                {
                    MessageBox.Show("Esse item já foi adicionado.",
                    "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                }
                    // Inserir item na lista
                    libLista.Items.Add(txbInserir.Text);
                // Mostrar mensagem de sucesso
                MessageBox.Show($"{txbInserir.Text} foi adicionado a lista!",
                    "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Retornar o txbInserir ao valor normal
                txbInserir.BackColor= Color.White;
                txbInserir.ForeColor= Color.Black;

                // Limpar campo
                txbInserir.Clear();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?",
                "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                libLista.Items.Clear();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            // Verificar se o usuário não selecionou nada
            if (libLista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para excluir.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Salvar temporariamente o nome do item que será removido:
                string itemRemovido = libLista.SelectedItem.ToString();

                // Remover o item:
                libLista.Items.RemoveAt(libLista.SelectedIndex);

                MessageBox.Show($"{itemRemovido} foi removido da lista.",
                    "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbInserir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Pressionar o btn pressionar
                btAdd.PerformClick();
            }
        }
    }
}
