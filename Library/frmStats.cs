using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Library.Classes;


namespace Library
{
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }

        Select select = new Select();

        private void frmStats_Load(object sender, EventArgs e)
        {
            lbTotal.Text = select.preencherStats("livro","Estante",1);
            lbLido.Text = select.preencherStats("livro", "Status",1);
            lbLendo.Text = select.preencherStats("livro", "Status", 2);
            lbNLido.Text = select.preencherStats("livro", "Status", 3);

            livroMaiorT.Text = select.preencherGridStatusT("Pg","MAX");
            livroMaiorA.Text = select.preencherGridStatusA("Pg", "MAX");
            livroMaiorP.Text = select.preencherGridStatusP("Pg", "MAX");

            livroMenorT.Text = select.preencherGridStatusT("Pg", "MIN");
            livroMenorA.Text = select.preencherGridStatusA("Pg", "MIN");
            livroMenorP.Text = select.preencherGridStatusP("Pg", "MIN");

            livroAntigoT.Text = select.preencherGridStatusT("Ano", "MIN");
            livroAntigoA.Text = select.preencherGridStatusA("Ano", "MIN");
            livroAntigoY.Text = select.preencherGridStatusP("Ano", "MIN");

            //lbPg2008.Text = select.selectSum("2008") + " Pg";

            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 2008; i<=2017; i++)
            {
                Label lb = new Label();
                Label lb2 = new Label();
                lb.Text = select.preencherStats("lista", "Ano", i);
                lb.Font = new Font("Microsoft Sans Serif", 10);
                tableLayoutPanel4.Controls.Add(lb);
                lb2.Text = select.selectSum(i.ToString()) + " pg";
                lb2.Font = new Font("Microsoft Sans Serif", 10);
                tableLayoutPanel4.Controls.Add(lb2);
            }
            
            
        }

        private void frmStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
