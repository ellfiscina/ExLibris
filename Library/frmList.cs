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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        Lista lista = new Lista();
        ListaDAO listaDAO = new ListaDAO();
        Select select = new Select();
        Livro livro = new Livro();
        private void frmList_Load(object sender, EventArgs e)
        {
            listaDAO.Criar();
            cbLivro.DataSource = select.preencherCombo("livro","Titulo");
            cbLivro.DisplayMember = "Titulo";
            cbLivro.ValueMember = "ISBN";
            cbLivro.Text = null;        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp;
            label1.Text = listBox1.GetItemText(listBox1.SelectedItem);
            dataGridView1.DataSource = select.preencherGridLista(int.Parse(label1.Text));
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                temp = int.Parse(select.selectT((string)row.Cells[0].Value, "Estante"));
                Console.WriteLine(temp);
                if (temp == 0)
                {
                    Console.WriteLine("oi");
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
                
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lista.ISBN = cbLivro.SelectedValue.ToString();
            lista.Titulo = select.selectT(lista.ISBN, "Titulo");
            lista.Ano = int.Parse(label1.Text);
            lista.Autor = select.preencherTextA(lista.Titulo);

            Console.Write(lista.ISBN);
            Console.Write(lista.Titulo);
            Console.Write(lista.Ano);
            Console.Write(lista.Autor);
            listaDAO.Inserir(lista);
            MessageBox.Show("Livro Inserido com Sucesso", "Livro Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.frmList_Load(null, null);
        }
    }
}
