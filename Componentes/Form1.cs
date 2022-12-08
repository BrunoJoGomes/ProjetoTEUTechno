//importando bibliotecas do framework
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes //nome do projeto
{
    public partial class frmFrutas : Form // : - extend - pega compnentes da classe forms 
    {
        //método construtor
        public frmFrutas()
        {
            InitializeComponent(); //carrega todos os componenetes da janela
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";

            operador = int.Parse(txtSelecione.Text); //casting de string p/ int

            switch (operador)
            {
                case 1: frutas = "Banana";
                    break;
                case 2: frutas = "Maçã";
                    break;
                case 3:
                    frutas = "Pêra";
                    break;
                case 4:
                    frutas = "Melância";
                    break;
                default: frutas = "Nenhuma fruta selecionada";
                    break;
            }
            txtFrutaSelecionada.Text = frutas;
            txtSelecione.Text = "";
            txtSelecione.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Executar método criado
            limparCampos();
        }

        //Criar o método para limpar os componentes
        public void limparCampos()
        {
            txtFrutaSelecionada.Clear();
            txtSelecione.Text = "";
            ltbFrutas.Items.Clear();
            cbbFrutasListadas.Items.Clear();
            cbbFrutasListadas.Text = "";

            txtSelecione.Focus(); //retorna p/ textbox selecione

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            ltbFrutas.Items.Add(txtFrutaSelecionada.Text);

            cbbFrutasListadas.Items.Clear();
            cbbFrutasListadas.Items.Add(txtFrutaSelecionada.Text);
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //formas de sair

            //  Close(); não fecha todos os processos na maquina
            // this.Close(); this == a propria classe
            // Application.Exit(); fecha a aplicação e tudo que estiver com ela

            DialogResult res;

            res = MessageBox.Show("Deseja sair?", "Mensagem do sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }


        }

        private void txtSelecione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnSelecionar.Focus();
            }
        }
    }
}
