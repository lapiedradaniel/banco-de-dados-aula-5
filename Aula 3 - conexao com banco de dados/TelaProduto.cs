using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_3___conexao_com_banco_de_dados
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void CarregaCategoria()
        {
            cbxcategoria.DataSource = null;
            cbxcategoria.DataSource = con.Retorna("select * from tb_categoria");
            cbxcategoria.DisplayMember = "cat_descricao";
            cbxcategoria.ValueMember = "cat_id";
        }
        private void CarregaTabela()
        {
            dvgDados.DataSource = null;
            DataTable dados = con.Retorna("select * from td_categoria");
        }

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            CarregaCategoria();
            CarregaTabela();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into td_produto values (null, '" + txtnome.Text + "', '" + txtdescricao.Text +
                "','" + cbxcategoria.SelectedValue + "," + txtvalor.Text + ")";
            if (con.Executar(sql))
            {
                MessageBox.Show("atualizado");
            }
            else
            {
                MessageBox.Show("erro");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "update tb_produto set prod_nome='" + txtnome.Text + "', prod_descricao='" + txtdescricao.Text
                + "' , prod_categoria=" + cbxcategoria.SelectedValue + " prod_valor+" + txtvalor.Text + "where prod_codigo=" + txtcodigo.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("atualizado");
            }
            else
            {
                MessageBox.Show("erro");
            }
        }

        private void btnEcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_produto where prod_ id=" + txtcodigo.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("excluido");
            }
            else
            {
                MessageBox.Show("erro");
            }

        }
    }
}
