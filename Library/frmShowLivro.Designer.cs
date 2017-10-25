namespace Library
{
    partial class frmShowLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtPg = new System.Windows.Forms.MaskedTextBox();
            this.txtEd = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtSubtitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDesejo = new System.Windows.Forms.RadioButton();
            this.rbTenho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNLido = new System.Windows.Forms.RadioButton();
            this.rbLendo = new System.Windows.Forms.RadioButton();
            this.rbLido = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbNTenho = new System.Windows.Forms.RadioButton();
            this.cbEmprestado = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(201, 260);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(37, 23);
            this.txtAno.TabIndex = 103;
            // 
            // txtPg
            // 
            this.txtPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPg.Location = new System.Drawing.Point(92, 260);
            this.txtPg.Mask = "0000";
            this.txtPg.Name = "txtPg";
            this.txtPg.Size = new System.Drawing.Size(35, 23);
            this.txtPg.TabIndex = 102;
            // 
            // txtEd
            // 
            this.txtEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEd.Location = new System.Drawing.Point(331, 260);
            this.txtEd.Mask = "00";
            this.txtEd.Name = "txtEd";
            this.txtEd.Size = new System.Drawing.Size(37, 23);
            this.txtEd.TabIndex = 101;
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(279, 442);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 38);
            this.btnExcluir.TabIndex = 109;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(172, 442);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 38);
            this.btnAlterar.TabIndex = 108;
            this.btnAlterar.Text = "OK";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(92, 316);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(201, 23);
            this.txtIdioma.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 116;
            this.label8.Text = "Idioma";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Enabled = false;
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(451, 260);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(170, 23);
            this.txtIsbn.TabIndex = 104;
            // 
            // txtSubtitulo
            // 
            this.txtSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtitulo.Location = new System.Drawing.Point(92, 148);
            this.txtSubtitulo.Name = "txtSubtitulo";
            this.txtSubtitulo.Size = new System.Drawing.Size(529, 23);
            this.txtSubtitulo.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "Páginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Edição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 112;
            this.label4.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Subtitulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(92, 92);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(529, 23);
            this.txtTitulo.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 120;
            this.label10.Text = "Titulo";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(389, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 38);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(92, 204);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(276, 23);
            this.txtAutor.TabIndex = 122;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(451, 204);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(170, 23);
            this.txtEditora.TabIndex = 123;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 125;
            this.label11.Text = "Lista de Leitura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEmprestado);
            this.groupBox2.Controls.Add(this.rbNTenho);
            this.groupBox2.Controls.Add(this.rbDesejo);
            this.groupBox2.Controls.Add(this.rbTenho);
            this.groupBox2.Location = new System.Drawing.Point(510, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 113);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            // 
            // rbDesejo
            // 
            this.rbDesejo.AutoSize = true;
            this.rbDesejo.Location = new System.Drawing.Point(16, 65);
            this.rbDesejo.Name = "rbDesejo";
            this.rbDesejo.Size = new System.Drawing.Size(58, 17);
            this.rbDesejo.TabIndex = 96;
            this.rbDesejo.TabStop = true;
            this.rbDesejo.Text = "Desejo";
            this.rbDesejo.UseVisualStyleBackColor = true;
            // 
            // rbTenho
            // 
            this.rbTenho.AutoSize = true;
            this.rbTenho.Location = new System.Drawing.Point(16, 19);
            this.rbTenho.Name = "rbTenho";
            this.rbTenho.Size = new System.Drawing.Size(56, 17);
            this.rbTenho.TabIndex = 97;
            this.rbTenho.TabStop = true;
            this.rbTenho.Text = "Tenho";
            this.rbTenho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNLido);
            this.groupBox1.Controls.Add(this.rbLendo);
            this.groupBox1.Controls.Add(this.rbLido);
            this.groupBox1.Location = new System.Drawing.Point(389, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 113);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            // 
            // rbNLido
            // 
            this.rbNLido.AutoSize = true;
            this.rbNLido.Location = new System.Drawing.Point(20, 65);
            this.rbNLido.Name = "rbNLido";
            this.rbNLido.Size = new System.Drawing.Size(68, 17);
            this.rbNLido.TabIndex = 2;
            this.rbNLido.TabStop = true;
            this.rbNLido.Text = "Não Lido";
            this.rbNLido.UseVisualStyleBackColor = true;
            // 
            // rbLendo
            // 
            this.rbLendo.AutoSize = true;
            this.rbLendo.Location = new System.Drawing.Point(20, 42);
            this.rbLendo.Name = "rbLendo";
            this.rbLendo.Size = new System.Drawing.Size(55, 17);
            this.rbLendo.TabIndex = 1;
            this.rbLendo.TabStop = true;
            this.rbLendo.Text = "Lendo";
            this.rbLendo.UseVisualStyleBackColor = true;
            // 
            // rbLido
            // 
            this.rbLido.AutoSize = true;
            this.rbLido.Location = new System.Drawing.Point(20, 19);
            this.rbLido.Name = "rbLido";
            this.rbLido.Size = new System.Drawing.Size(45, 17);
            this.rbLido.TabIndex = 0;
            this.rbLido.TabStop = true;
            this.rbLido.Text = "Lido";
            this.rbLido.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(228, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 128;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.comboBox1.Location = new System.Drawing.Point(135, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 129;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbNTenho
            // 
            this.rbNTenho.AutoSize = true;
            this.rbNTenho.Location = new System.Drawing.Point(16, 42);
            this.rbNTenho.Name = "rbNTenho";
            this.rbNTenho.Size = new System.Drawing.Size(79, 17);
            this.rbNTenho.TabIndex = 98;
            this.rbNTenho.TabStop = true;
            this.rbNTenho.Text = "Não Tenho";
            this.rbNTenho.UseVisualStyleBackColor = true;
            // 
            // cbEmprestado
            // 
            this.cbEmprestado.AutoSize = true;
            this.cbEmprestado.Location = new System.Drawing.Point(15, 88);
            this.cbEmprestado.Name = "cbEmprestado";
            this.cbEmprestado.Size = new System.Drawing.Size(82, 17);
            this.cbEmprestado.TabIndex = 130;
            this.cbEmprestado.Text = "Emprestado";
            this.cbEmprestado.UseVisualStyleBackColor = true;
            // 
            // frmShowLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 541);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPg);
            this.Controls.Add(this.txtEd);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtSubtitulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmShowLivro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowLivro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtPg;
        private System.Windows.Forms.MaskedTextBox txtEd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtSubtitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDesejo;
        private System.Windows.Forms.RadioButton rbTenho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNLido;
        private System.Windows.Forms.RadioButton rbLendo;
        private System.Windows.Forms.RadioButton rbLido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbNTenho;
        private System.Windows.Forms.CheckBox cbEmprestado;
    }
}