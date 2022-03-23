namespace exemplopoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textRg = new System.Windows.Forms.TextBox();
            this.pnpessoa = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.alunos = new System.Windows.Forms.Panel();
            this.professsor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnpessoa.SuspendLayout();
            this.alunos.SuspendLayout();
            this.professsor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(87, 108);
            this.textnome.Name = "textnome";
            this.textnome.PlaceholderText = "Digite o nome";
            this.textnome.Size = new System.Drawing.Size(100, 23);
            this.textnome.TabIndex = 4;
            this.textnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textRg
            // 
            this.textRg.Location = new System.Drawing.Point(87, 142);
            this.textRg.Name = "textRg";
            this.textRg.Size = new System.Drawing.Size(100, 23);
            this.textRg.TabIndex = 6;
            this.textRg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pnpessoa
            // 
            this.pnpessoa.Controls.Add(this.groupBox1);
            this.pnpessoa.Controls.Add(this.textEmail);
            this.pnpessoa.Controls.Add(this.txtEmail);
            this.pnpessoa.Controls.Add(this.txtCpf);
            this.pnpessoa.Controls.Add(this.txtRg);
            this.pnpessoa.Controls.Add(this.txtNome);
            this.pnpessoa.Controls.Add(this.button1);
            this.pnpessoa.Controls.Add(this.textCPF);
            this.pnpessoa.Controls.Add(this.textnome);
            this.pnpessoa.Controls.Add(this.textRg);
            this.pnpessoa.Location = new System.Drawing.Point(24, 12);
            this.pnpessoa.Name = "pnpessoa";
            this.pnpessoa.Size = new System.Drawing.Size(282, 396);
            this.pnpessoa.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(87, 203);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 23);
            this.textEmail.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(46, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 15);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "E-mail";
            // 
            // txtCpf
            // 
            this.txtCpf.AutoSize = true;
            this.txtCpf.Location = new System.Drawing.Point(46, 174);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(28, 15);
            this.txtCpf.TabIndex = 11;
            this.txtCpf.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.AutoSize = true;
            this.txtRg.Location = new System.Drawing.Point(46, 145);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(22, 15);
            this.txtRg.TabIndex = 10;
            this.txtRg.Text = "RG";
            this.txtRg.Click += new System.EventHandler(this.txtRg_Click);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(41, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(40, 15);
            this.txtNome.TabIndex = 9;
            this.txtNome.Text = "Nome";
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(87, 171);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(100, 23);
            this.textCPF.TabIndex = 7;
            // 
            // alunos
            // 
            this.alunos.Controls.Add(this.textBox1);
            this.alunos.Controls.Add(this.maskedTextBox1);
            this.alunos.Location = new System.Drawing.Point(300, 12);
            this.alunos.Name = "alunos";
            this.alunos.Size = new System.Drawing.Size(219, 396);
            this.alunos.TabIndex = 9;
            this.alunos.Paint += new System.Windows.Forms.PaintEventHandler(this.alunos_Paint);
            // 
            // professsor
            // 
            this.professsor.Controls.Add(this.textBox3);
            this.professsor.Controls.Add(this.textBox2);
            this.professsor.Location = new System.Drawing.Point(538, 12);
            this.professsor.Name = "professsor";
            this.professsor.Size = new System.Drawing.Size(205, 396);
            this.professsor.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(759, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 396);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(18, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aluno";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Professor";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(62, 113);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1127, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.professsor);
            this.Controls.Add(this.alunos);
            this.Controls.Add(this.pnpessoa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnpessoa.ResumeLayout(false);
            this.pnpessoa.PerformLayout();
            this.alunos.ResumeLayout(false);
            this.alunos.PerformLayout();
            this.professsor.ResumeLayout(false);
            this.professsor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textnome;
        private TextBox textRg;
        private Panel pnpessoa;
        private TextBox textCPF;
        private Panel alunos;
        private Panel professsor;
        private Panel panel1;
        private Button button1;
        private TextBox textEmail;
        private Label txtEmail;
        private Label txtCpf;
        private Label txtRg;
        private Label txtNome;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pessoaToolStripMenuItem;
    }
}