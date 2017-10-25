namespace Library
{
    partial class frmAddLivro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNTenho = new System.Windows.Forms.RadioButton();
            this.rbDesejo = new System.Windows.Forms.RadioButton();
            this.rbTenho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNLido = new System.Windows.Forms.RadioButton();
            this.rbLendo = new System.Windows.Forms.RadioButton();
            this.rbLido = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtPg = new System.Windows.Forms.MaskedTextBox();
            this.txtEd = new System.Windows.Forms.MaskedTextBox();
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
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCat2 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(319, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNTenho);
            this.groupBox2.Controls.Add(this.rbDesejo);
            this.groupBox2.Controls.Add(this.rbTenho);
            this.groupBox2.Location = new System.Drawing.Point(514, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 91);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            // 
            // rbNTenho
            // 
            this.rbNTenho.AutoSize = true;
            this.rbNTenho.Location = new System.Drawing.Point(16, 42);
            this.rbNTenho.Name = "rbNTenho";
            this.rbNTenho.Size = new System.Drawing.Size(79, 17);
            this.rbNTenho.TabIndex = 12;
            this.rbNTenho.TabStop = true;
            this.rbNTenho.Text = "Não Tenho";
            this.rbNTenho.UseVisualStyleBackColor = true;
            // 
            // rbDesejo
            // 
            this.rbDesejo.AutoSize = true;
            this.rbDesejo.Location = new System.Drawing.Point(16, 65);
            this.rbDesejo.Name = "rbDesejo";
            this.rbDesejo.Size = new System.Drawing.Size(58, 17);
            this.rbDesejo.TabIndex = 13;
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
            this.rbTenho.TabIndex = 11;
            this.rbTenho.TabStop = true;
            this.rbTenho.Text = "Tenho";
            this.rbTenho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNLido);
            this.groupBox1.Controls.Add(this.rbLendo);
            this.groupBox1.Controls.Add(this.rbLido);
            this.groupBox1.Location = new System.Drawing.Point(393, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 91);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            // 
            // rbNLido
            // 
            this.rbNLido.AutoSize = true;
            this.rbNLido.Location = new System.Drawing.Point(20, 65);
            this.rbNLido.Name = "rbNLido";
            this.rbNLido.Size = new System.Drawing.Size(68, 17);
            this.rbNLido.TabIndex = 10;
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
            this.rbLendo.TabIndex = 9;
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
            this.rbLido.TabIndex = 8;
            this.rbLido.TabStop = true;
            this.rbLido.Text = "Lido";
            this.rbLido.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(96, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(529, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 143;
            this.label10.Text = "Titulo";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(205, 226);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(37, 23);
            this.txtAno.TabIndex = 4;
            // 
            // txtPg
            // 
            this.txtPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPg.Location = new System.Drawing.Point(337, 226);
            this.txtPg.Mask = "0000";
            this.txtPg.Name = "txtPg";
            this.txtPg.Size = new System.Drawing.Size(35, 23);
            this.txtPg.TabIndex = 5;
            // 
            // txtEd
            // 
            this.txtEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEd.Location = new System.Drawing.Point(96, 226);
            this.txtEd.Mask = "00";
            this.txtEd.Name = "txtEd";
            this.txtEd.Size = new System.Drawing.Size(37, 23);
            this.txtEd.TabIndex = 3;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(96, 282);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(201, 23);
            this.txtIdioma.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 141;
            this.label8.Text = "Idioma";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(455, 226);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(170, 23);
            this.txtIsbn.TabIndex = 6;
            // 
            // txtSubtitulo
            // 
            this.txtSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtitulo.Location = new System.Drawing.Point(96, 114);
            this.txtSubtitulo.Name = "txtSubtitulo";
            this.txtSubtitulo.Size = new System.Drawing.Size(529, 23);
            this.txtSubtitulo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 140;
            this.label7.Text = "Páginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 139;
            this.label6.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Edição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 135;
            this.label2.Text = "Subtitulo";
            // 
            // cbAutor
            // 
            this.cbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(96, 170);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(276, 24);
            this.cbAutor.TabIndex = 15;
            // 
            // cbEditora
            // 
            this.cbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(455, 170);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(170, 24);
            this.cbEditora.TabIndex = 16;
            // 
            // cbCat
            // 
            this.cbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(96, 337);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(201, 24);
            this.cbCat.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 152;
            this.label1.Text = "Categoria";
            // 
            // cbCat2
            // 
            this.cbCat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCat2.FormattingEnabled = true;
            this.cbCat2.Location = new System.Drawing.Point(96, 367);
            this.cbCat2.Name = "cbCat2";
            this.cbCat2.Size = new System.Drawing.Size(201, 24);
            this.cbCat2.TabIndex = 18;
            // 
            // frmAddLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(644, 541);
            this.Controls.Add(this.cbCat2);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEditora);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPg);
            this.Controls.Add(this.txtEd);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmAddLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Livro";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddLivro_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDesejo;
        private System.Windows.Forms.RadioButton rbTenho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNLido;
        private System.Windows.Forms.RadioButton rbLendo;
        private System.Windows.Forms.RadioButton rbLido;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtPg;
        private System.Windows.Forms.MaskedTextBox txtEd;
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
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.RadioButton rbNTenho;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCat2;
    }
}