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
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        Select select = new Select();
        LivroDAO livroDB = new LivroDAO();
        Livro livro = new Livro();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        CategoriaDAO categoriaDAO2 = new CategoriaDAO();
        Categoria categoria = new Categoria();
        Categoria categoria2 = new Categoria();

        private void frmAddLivro_Load_1(object sender, EventArgs e)
        {
            cbAutor.DataSource = select.preencherComboAutor();
            cbAutor.DisplayMember = "Name";
            cbAutor.ValueMember = "idAutor";
            cbAutor.Text = null;

            cbEditora.DataSource = select.preencherCombo("editora", "Nome");
            cbEditora.DisplayMember = "Nome";
            cbEditora.ValueMember = "idEditora";
            cbEditora.Text = null;

            cbCat.DataSource = select.preencherCombo("categoria","Nome");
            cbCat.DisplayMember = "Nome";
            cbCat.ValueMember = "idcategoria";
            cbCat.Text = null;

            cbCat2.DataSource = select.preencherCombo("categoria", "Nome");
            cbCat2.DisplayMember = "Nome";
            cbCat2.ValueMember = "idcategoria";
            cbCat2.Text = null;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                livro.Titulo = txtTitulo.Text;
                livro.Subtitulo = txtSubtitulo.Text;                
                livro.Idioma = txtIdioma.Text;
                livro.ISBN = txtIsbn.Text;
                livro.Autor = int.Parse(cbAutor.SelectedValue.ToString());
                livro.Editora = int.Parse(cbEditora.SelectedValue.ToString());
                categoria.Id = int.Parse(cbCat.SelectedValue.ToString());
                categoria2.Id = int.Parse(cbCat2.SelectedValue.ToString());
                livro.Emprestimo = 0;

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

                if (rbTenho.Checked)
                {
                    livro.Estante = 1;
                }
                else if (rbDesejo.Checked)
                {
                    livro.Estante = 2;
                }
                else if(rbNTenho.Checked)
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
                
                livroDB.Inserir(livro);
                categoriaDAO.InserirCat(categoria, livro);
                categoriaDAO2.InserirCat(categoria2, livro);
                MessageBox.Show("Livro Inserido com Sucesso", "Livro Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch(Exception ex)
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
            txtTitulo.Clear();
            txtSubtitulo.Clear();
            //txtIdioma.Clear();
            txtEd.Clear();
            txtPg.Clear();
            txtAno.Clear();
            txtIsbn.Clear();
            //cbAutor.ResetText();
            //cbEditora.ResetText();
            rbDesejo.Checked = false;
            rbLendo.Checked = false;
            rbLido.Checked = false;
            rbNLido.Checked = false;
            rbTenho.Checked = false;
        }
    }
}
