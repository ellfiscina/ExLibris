using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes;

namespace Library
{
    public partial class frmAddEditora : Form
    {
        public frmAddEditora()
        {
            InitializeComponent();
        }

        EditoraDAO editoraDB = new EditoraDAO();
        Editora editora = new Editora();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        Categoria categoria = new Categoria();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                editora.Nome = txtNome.Text;
            
                editoraDB.Inserir(editora);
                MessageBox.Show("Editora Inserida com Sucesso", "Editora Salva!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro =" + ex, "Erro ao Gravar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void clearData()
        {
            txtNome.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.Nome = txtNome.Text;

                categoriaDAO.Inserir(categoria);
                MessageBox.Show("Editora Inserida com Sucesso", "Editora Salva!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro =" + ex, "Erro ao Gravar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
