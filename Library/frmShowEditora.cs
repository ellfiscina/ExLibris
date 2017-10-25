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
    public partial class frmShowEditora : Form
    {
        public frmShowEditora(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        Editora editora = new Editora();
        EditoraDAO editoraDAO = new EditoraDAO();
        Select select = new Select();
        int id;
        private void frmShowEditora_Load(object sender, EventArgs e)
        {
            txtNome.Text = label1.Text;
            id = int.Parse(select.selectIDEd(label1.Text));
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            editora.Nome = txtNome.Text;
            editoraDAO.Alterar(editora, id);
            MessageBox.Show("Editora Alterada com Sucesso", "Editora Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            editora.Nome = txtNome.Text;
            editoraDAO.Excluir(editora, id);
            MessageBox.Show("Editora Excluida com Sucesso", "Editora Excluida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
