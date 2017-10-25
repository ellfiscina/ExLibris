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
    public partial class frmAddAutor : Form
    {
        public frmAddAutor()
        {
            InitializeComponent();
        }

        AutorDAO autorDB = new AutorDAO();
        Autor autor = new Autor();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                autor.Nome = txtNome.Text;
                autor.Sobrenome = txtSobrenome.Text;

                autorDB.Inserir(autor);
                MessageBox.Show("Autor Inserido com Sucesso", "Autor Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtSobrenome.Clear();
        }
    }
}
