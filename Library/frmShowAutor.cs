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
    public partial class frmShowAutor : Form
    {
        Boolean aux;
        string texto;
        int id;
        public frmShowAutor(string text,Boolean i)
        {
            InitializeComponent();

            texto = text;    
            aux = i;
        }

        Select select = new Select();
        Autor autor = new Autor();
        AutorDAO autorDAO = new AutorDAO();

        private void frmShowAutor_Load(object sender, EventArgs e)
        {

            if (aux)
            {
                label1.Text = texto;
                txtNome.Text = select.preencherTextN(texto, "Nome");
                txtSobrenome.Text = select.preencherTextN(texto, "Sobrenome");
                autor.ID = int.Parse(select.preencherTextN(texto, "idAutor"));
            }
            else
            {
                id = int.Parse(texto);
                label1.Text = select.selectCoisa(id, "CONCAT(Sobrenome, ', ', Nome)");
                txtNome.Text = select.selectCoisa(id, "Nome");
                txtSobrenome.Text = select.selectCoisa(id, "Sobrenome");
                autor.ID = int.Parse(texto);
            }

            dg.DataSource = select.preencherGridAutorLivro(autor.ID);
            int temp;
            foreach (DataGridViewRow row in dg.Rows)
            {
                temp = int.Parse(select.selectT((string)row.Cells[0].Value, "Estante"));
                if (temp == 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    Console.WriteLine("oi");
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            autor.Nome = txtNome.Text;
            autor.Sobrenome = txtSobrenome.Text;
            autorDAO.Alterar(autor);
            MessageBox.Show("Autor Alterado com Sucesso", "Autor Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            autor.Nome = txtNome.Text;
            autor.Sobrenome = txtSobrenome.Text;
            autorDAO.Excluir(autor);
            MessageBox.Show("Autor Excluido com Sucesso", "Autor Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
