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
    public partial class frmShowLivro : Form
    {
        public frmShowLivro(string title)
        {
            InitializeComponent();
            label1.Text = title;
            check_cb();
        }

        Select select = new Select();
        Livro livro = new Livro();
        LivroDAO livroDAO = new LivroDAO();
        Lista lista = new Lista();
        ListaDAO listaDAO = new ListaDAO();

        private void frmShowLivro_Load(object sender, EventArgs e)
        {
            
            string text = label1.Text;
            txtTitulo.Text = text;
            txtSubtitulo.Text = select.preencherText("Subtitulo", text);
            txtEd.Text = select.preencherText("Edicao", text);
            txtPg.Text = select.preencherText("Pg", text);
            txtAno.Text = select.preencherText("Ano", text);
            txtIsbn.Text = select.preencherText("ISBN", text);
            txtIdioma.Text = select.preencherText("Idioma", text);
            txtAutor.Text = select.preencherTextA(text);
            txtEditora.Text = select.preencherTextE(text);
            if(int.Parse(select.preencherText("Status", text)) == 1)
            {
                rbLido.Checked = true;
            }
            else if (int.Parse(select.preencherText("Status", text)) == 2)
            {
                rbLendo.Checked = true;
            }
            else if (int.Parse(select.preencherText("Status", text)) == 3)
            {
                rbNLido.Checked = true;
            }

            if (int.Parse(select.preencherText("Estante", text)) == 1)
            {
                rbTenho.Checked = true;
            }
            else if (int.Parse(select.preencherText("Estante", text)) == 2)
            {
                rbDesejo.Checked = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            livro.Titulo = txtTitulo.Text;
            livro.Subtitulo = txtSubtitulo.Text;
            livro.Idioma = txtIdioma.Text;
            livro.ISBN = txtIsbn.Text;

            if (string.IsNullOrEmpty(txtEd.Text))
            {
                livro.Edicao = 0;
            }
            else
            {
                livro.Edicao = int.Parse(txtEd.Text);
            }

            if (string.IsNullOrEmpty(txtAno.Text))
            {
                livro.Ano = 0;
            }
            else
            {
                livro.Ano = int.Parse(txtAno.Text);
            }

            if (string.IsNullOrEmpty(txtPg.Text))
            {
                livro.Pg = 0;
            }
            else
            {
                livro.Pg = int.Parse(txtPg.Text);
            }
            if (cbEmprestado.Checked)
            {
                livro.Emprestimo = 1;
            }

            if (rbTenho.Checked)
            {
                livro.Estante = 1;
            }
            else if (rbDesejo.Checked)
            {
                livro.Estante = 2;
            }
            else if (rbNTenho.Checked)
            {
                livro.Estante = 0;
            }
            
            if (rbLido.Checked)
            {
                livro.Status = 1;
            }
            else if (rbLendo.Checked)
            {
                livro.Status = 2;
            }
            else if (rbNLido.Checked)
            {
                livro.Status = 3;
            }
            livroDAO.Alterar(livro);
            MessageBox.Show("Livro Alterado com Sucesso", "Livro Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            livro.Titulo = txtTitulo.Text;
            livro.Subtitulo = txtSubtitulo.Text;
            livro.Idioma = txtIdioma.Text;
            livro.ISBN = txtIsbn.Text;

            if (string.IsNullOrEmpty(txtEd.Text))
            {
                livro.Edicao = 0;
            }
            else
            {
                livro.Edicao = int.Parse(txtEd.Text);
            }

            if (string.IsNullOrEmpty(txtAno.Text))
            {
                livro.Ano = 0;
            }
            else
            {
                livro.Ano = int.Parse(txtAno.Text);
            }

            if (string.IsNullOrEmpty(txtPg.Text))
            {
                livro.Pg = 0;
            }
            else
            {
                livro.Pg = int.Parse(txtPg.Text);
            }

            livroDAO.Excluir(livro);
            MessageBox.Show("Livro Excluido com Sucesso", "Livro Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.ISBN = txtIsbn.Text;
            lista.Titulo = txtTitulo.Text;
            lista.Autor = txtAutor.Text;
            
            listaDAO.Inserir(lista);
            MessageBox.Show("Livro Inserido!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_cb();
            
        }
        private void check_cb()
        {
            if (comboBox1.SelectedItem != null)
            {
                lista.Ano = int.Parse(comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
                
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
