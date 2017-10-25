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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Select select = new Select();
        LivroDAO livroDB = new LivroDAO();

        private void menuAddLivro_Click(object sender, EventArgs e)
        {
            frmAddLivro frmAddLivro = new frmAddLivro();
            frmAddLivro.MdiParent = this;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            frmAddLivro.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmAddLivro.Show();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            dataGridView1.Visible = true;
        }

        private void menuAddAutor_Click(object sender, EventArgs e)
        {
            frmAddAutor frmAddAutor = new frmAddAutor();
            frmAddAutor.MdiParent = this;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            frmAddAutor.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmAddAutor.Show();
        }

        private void menuAddEditora_Click(object sender, EventArgs e)
        {
            frmAddEditora frmAddEditora = new frmAddEditora();
            frmAddEditora.MdiParent = this;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            frmAddEditora.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmAddEditora.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            EditoraDAO editoraDAO = new EditoraDAO();
            AutorDAO autorDAO = new AutorDAO();
            LivroDAO livroDAO = new LivroDAO();
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            editoraDAO.Criar();
            autorDAO.Criar();
            livroDAO.Criar();
            categoriaDAO.Criar();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGridMain();
        }

        private void btnEstante_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Estante", 1);
        }

        private void btnLido_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Status", 1);
        }

        private void btnLendo_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Status", 2);
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Status", 3);
        }

        private void btnDesejado_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Estante", 2);
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView2.DataSource = select.preencherGridAutor();
        }

        private void btnEditora_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.DataSource = select.preencherGridEditora();
        }

        private void btnEmprestado_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.DataSource = select.preencherGrid("Emprestimo", 1);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats frmStats = new frmStats();
            frmStats.MdiParent = this;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            frmStats.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmStats.Show();

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView4.DataSource = select.preencherGridCat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    frmShowLivro frm = new frmShowLivro(dataGridView1.CurrentCell.Value.ToString());
                    frm.MdiParent = this;
                    dataGridView1.Visible = false;
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frm.Show();
                }
            }
            else if (dataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    frmShowAutor frmShowAutor = new frmShowAutor(dataGridView1.CurrentCell.Value.ToString(),true);
                    frmShowAutor.MdiParent = this;
                    dataGridView1.Visible = false;
                    frmShowAutor.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frmShowAutor.Show();
                }
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
                {
                    frmShowAutor frmShowAutor = new frmShowAutor(dataGridView2.CurrentCell.Value.ToString(),false);
                    frmShowAutor.MdiParent = this;
                    dataGridView2.Visible = false;
                    frmShowAutor.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frmShowAutor.Show();
                }
            }
        }
        
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView3.CurrentCell != null && dataGridView3.CurrentCell.Value != null)
                {
                    frmShowEditora frmShowEditora = new frmShowEditora(dataGridView3.CurrentCell.Value.ToString());
                    frmShowEditora.MdiParent = this;
                    dataGridView3.Visible = false;
                    frmShowEditora.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frmShowEditora.Show();
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView4.CurrentCell != null && dataGridView4.CurrentCell.Value != null)
                {
                    string aux = dataGridView4.CurrentCell.Value.ToString();
                    dataGridView4.Visible = false;
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = select.preencherGridCatL(aux);
                }
            }
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList frmList = new frmList();
            frmList.MdiParent = this;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            frmList.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmList.Show();
        }
    }
}
