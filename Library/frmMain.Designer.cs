namespace Library
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEditora = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnDesejado = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnLendo = new System.Windows.Forms.Button();
            this.btnLido = new System.Windows.Forms.Button();
            this.btnEstante = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnEmprestado = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddLivro,
            this.menuAddAutor,
            this.menuAddEditora});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // menuAddLivro
            // 
            this.menuAddLivro.Name = "menuAddLivro";
            this.menuAddLivro.Size = new System.Drawing.Size(111, 22);
            this.menuAddLivro.Text = "Livro";
            this.menuAddLivro.Click += new System.EventHandler(this.menuAddLivro_Click);
            // 
            // menuAddAutor
            // 
            this.menuAddAutor.Name = "menuAddAutor";
            this.menuAddAutor.Size = new System.Drawing.Size(111, 22);
            this.menuAddAutor.Text = "Autor";
            this.menuAddAutor.Click += new System.EventHandler(this.menuAddAutor_Click);
            // 
            // menuAddEditora
            // 
            this.menuAddEditora.Name = "menuAddEditora";
            this.menuAddEditora.Size = new System.Drawing.Size(111, 22);
            this.menuAddEditora.Text = "Editora";
            this.menuAddEditora.Click += new System.EventHandler(this.menuAddEditora_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(136, 537);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Estante";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditora
            // 
            this.btnEditora.BackColor = System.Drawing.Color.Transparent;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEditora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.Location = new System.Drawing.Point(8, 303);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Size = new System.Drawing.Size(128, 32);
            this.btnEditora.TabIndex = 10;
            this.btnEditora.Text = "Editoras";
            this.btnEditora.UseVisualStyleBackColor = false;
            this.btnEditora.Click += new System.EventHandler(this.btnEditora_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.Transparent;
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.Location = new System.Drawing.Point(8, 265);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(128, 32);
            this.btnAutor.TabIndex = 9;
            this.btnAutor.Text = "Autores";
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnDesejado
            // 
            this.btnDesejado.BackColor = System.Drawing.Color.Transparent;
            this.btnDesejado.FlatAppearance.BorderSize = 0;
            this.btnDesejado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDesejado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDesejado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDesejado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDesejado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesejado.Location = new System.Drawing.Point(8, 189);
            this.btnDesejado.Name = "btnDesejado";
            this.btnDesejado.Size = new System.Drawing.Size(128, 32);
            this.btnDesejado.TabIndex = 8;
            this.btnDesejado.Text = "Desejado";
            this.btnDesejado.UseVisualStyleBackColor = false;
            this.btnDesejado.Click += new System.EventHandler(this.btnDesejado_Click);
            // 
            // btnLer
            // 
            this.btnLer.BackColor = System.Drawing.Color.Transparent;
            this.btnLer.FlatAppearance.BorderSize = 0;
            this.btnLer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLer.Location = new System.Drawing.Point(8, 151);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(128, 32);
            this.btnLer.TabIndex = 7;
            this.btnLer.Text = "Fila de Leitura";
            this.btnLer.UseVisualStyleBackColor = false;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLendo
            // 
            this.btnLendo.BackColor = System.Drawing.Color.Transparent;
            this.btnLendo.FlatAppearance.BorderSize = 0;
            this.btnLendo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLendo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLendo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLendo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLendo.Location = new System.Drawing.Point(8, 113);
            this.btnLendo.Name = "btnLendo";
            this.btnLendo.Size = new System.Drawing.Size(128, 32);
            this.btnLendo.TabIndex = 6;
            this.btnLendo.Text = "Lendo";
            this.btnLendo.UseVisualStyleBackColor = false;
            this.btnLendo.Click += new System.EventHandler(this.btnLendo_Click);
            // 
            // btnLido
            // 
            this.btnLido.BackColor = System.Drawing.Color.Transparent;
            this.btnLido.FlatAppearance.BorderSize = 0;
            this.btnLido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLido.Location = new System.Drawing.Point(8, 75);
            this.btnLido.Name = "btnLido";
            this.btnLido.Size = new System.Drawing.Size(128, 32);
            this.btnLido.TabIndex = 5;
            this.btnLido.Text = "Lidos";
            this.btnLido.UseVisualStyleBackColor = false;
            this.btnLido.Click += new System.EventHandler(this.btnLido_Click);
            // 
            // btnEstante
            // 
            this.btnEstante.BackColor = System.Drawing.Color.Transparent;
            this.btnEstante.FlatAppearance.BorderSize = 0;
            this.btnEstante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstante.Location = new System.Drawing.Point(8, 37);
            this.btnEstante.Name = "btnEstante";
            this.btnEstante.Size = new System.Drawing.Size(128, 32);
            this.btnEstante.TabIndex = 12;
            this.btnEstante.Text = "Estante";
            this.btnEstante.UseVisualStyleBackColor = false;
            this.btnEstante.Click += new System.EventHandler(this.btnEstante_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(8, 379);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(128, 32);
            this.btnStats.TabIndex = 17;
            this.btnStats.Text = "Estatística";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 537);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(142, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(641, 537);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(142, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(641, 537);
            this.dataGridView3.TabIndex = 21;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnEmprestado
            // 
            this.btnEmprestado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestado.FlatAppearance.BorderSize = 0;
            this.btnEmprestado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEmprestado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmprestado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmprestado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEmprestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestado.Location = new System.Drawing.Point(8, 227);
            this.btnEmprestado.Name = "btnEmprestado";
            this.btnEmprestado.Size = new System.Drawing.Size(128, 32);
            this.btnEmprestado.TabIndex = 23;
            this.btnEmprestado.Text = "Emprestado";
            this.btnEmprestado.UseVisualStyleBackColor = false;
            this.btnEmprestado.Click += new System.EventHandler(this.btnEmprestado_Click);
            // 
            // btnCat
            // 
            this.btnCat.BackColor = System.Drawing.Color.Transparent;
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.Location = new System.Drawing.Point(8, 341);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(128, 32);
            this.btnCat.TabIndex = 25;
            this.btnCat.Text = "Categorias";
            this.btnCat.UseVisualStyleBackColor = false;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(142, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(641, 537);
            this.dataGridView4.TabIndex = 26;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnEmprestado);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEstante);
            this.Controls.Add(this.btnEditora);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnDesejado);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnLendo);
            this.Controls.Add(this.btnLido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Ex-Libris";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddLivro;
        private System.Windows.Forms.ToolStripMenuItem menuAddAutor;
        private System.Windows.Forms.ToolStripMenuItem menuAddEditora;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnDesejado;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLendo;
        private System.Windows.Forms.Button btnLido;
        private System.Windows.Forms.Button btnEstante;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.Button btnEmprestado;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

