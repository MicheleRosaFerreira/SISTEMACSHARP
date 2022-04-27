namespace SistemadeVendasCsharp.FORMULARIOS
{
    partial class PainelDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelDeUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.Label();
            this.txtsobrenome = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.txtcontato = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.Label();
            this.txttipousuario = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textContato = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.comboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.textPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.txtpesquisarusuario = new System.Windows.Forms.Label();
            this.dvgUsuario = new System.Windows.Forms.DataGridView();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btdeletar = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 28);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 13);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "ID";
            this.txtId.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(12, 87);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(43, 13);
            this.txtnome.TabIndex = 2;
            this.txtnome.Text = "Nome:";
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.AutoSize = true;
            this.txtsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsobrenome.Location = new System.Drawing.Point(8, 115);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(74, 13);
            this.txtsobrenome.TabIndex = 3;
            this.txtsobrenome.Text = "Sobrenome:";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(12, 148);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(41, 13);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "Email:";
            // 
            // txtusuario
            // 
            this.txtusuario.AutoSize = true;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(8, 181);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(54, 13);
            this.txtusuario.TabIndex = 5;
            this.txtusuario.Text = "Usuario:";
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(8, 217);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(47, 13);
            this.txtsenha.TabIndex = 6;
            this.txtsenha.Text = "Senha:";
            // 
            // txtcontato
            // 
            this.txtcontato.AutoSize = true;
            this.txtcontato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontato.Location = new System.Drawing.Point(12, 244);
            this.txtcontato.Name = "txtcontato";
            this.txtcontato.Size = new System.Drawing.Size(55, 13);
            this.txtcontato.TabIndex = 7;
            this.txtcontato.Text = "Contato:";
            // 
            // txtendereco
            // 
            this.txtendereco.AutoSize = true;
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(8, 273);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(65, 13);
            this.txtendereco.TabIndex = 8;
            this.txtendereco.Text = "Endereço:";
            // 
            // txtsexo
            // 
            this.txtsexo.AutoSize = true;
            this.txtsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexo.Location = new System.Drawing.Point(16, 380);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(39, 13);
            this.txtsexo.TabIndex = 9;
            this.txtsexo.Text = "Sexo:";
            // 
            // txttipousuario
            // 
            this.txttipousuario.AutoSize = true;
            this.txttipousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipousuario.Location = new System.Drawing.Point(12, 405);
            this.txttipousuario.Name = "txttipousuario";
            this.txttipousuario.Size = new System.Drawing.Size(101, 13);
            this.txttipousuario.TabIndex = 10;
            this.txttipousuario.Text = "Tipo de Usuario:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(52, 54);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(70, 20);
            this.textID.TabIndex = 11;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(88, 84);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(181, 20);
            this.textNome.TabIndex = 12;
            this.textNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textSobrenome
            // 
            this.textSobrenome.Location = new System.Drawing.Point(88, 112);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(247, 20);
            this.textSobrenome.TabIndex = 13;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(72, 145);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(267, 20);
            this.textEmail.TabIndex = 14;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(72, 178);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(267, 20);
            this.textUsuario.TabIndex = 15;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(72, 210);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(267, 20);
            this.textSenha.TabIndex = 16;
            // 
            // textContato
            // 
            this.textContato.Location = new System.Drawing.Point(72, 241);
            this.textContato.Name = "textContato";
            this.textContato.Size = new System.Drawing.Size(267, 20);
            this.textContato.TabIndex = 18;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Não Especificado"});
            this.comboSexo.Location = new System.Drawing.Point(72, 375);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 21);
            this.comboSexo.TabIndex = 19;
            // 
            // comboTipoUsuario
            // 
            this.comboTipoUsuario.FormattingEnabled = true;
            this.comboTipoUsuario.Items.AddRange(new object[] {
            "Usuario",
            "Admin"});
            this.comboTipoUsuario.Location = new System.Drawing.Point(119, 402);
            this.comboTipoUsuario.Name = "comboTipoUsuario";
            this.comboTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboTipoUsuario.TabIndex = 20;
            // 
            // textPesquisarUsuario
            // 
            this.textPesquisarUsuario.Location = new System.Drawing.Point(524, 54);
            this.textPesquisarUsuario.Name = "textPesquisarUsuario";
            this.textPesquisarUsuario.Size = new System.Drawing.Size(264, 20);
            this.textPesquisarUsuario.TabIndex = 21;
            this.textPesquisarUsuario.TextChanged += new System.EventHandler(this.textPesquisarUsuario_TextChanged);
            // 
            // txtpesquisarusuario
            // 
            this.txtpesquisarusuario.AutoSize = true;
            this.txtpesquisarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisarusuario.Location = new System.Drawing.Point(405, 57);
            this.txtpesquisarusuario.Name = "txtpesquisarusuario";
            this.txtpesquisarusuario.Size = new System.Drawing.Size(113, 13);
            this.txtpesquisarusuario.TabIndex = 22;
            this.txtpesquisarusuario.Text = "Pesquisar Usuario:";
            // 
            // dvgUsuario
            // 
            this.dvgUsuario.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dvgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuario.Location = new System.Drawing.Point(408, 92);
            this.dvgUsuario.Name = "dvgUsuario";
            this.dvgUsuario.Size = new System.Drawing.Size(380, 225);
            this.dvgUsuario.TabIndex = 23;
            this.dvgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuario_CellContentClick);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.IndianRed;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.Black;
            this.btcadastrar.Location = new System.Drawing.Point(417, 336);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(75, 23);
            this.btcadastrar.TabIndex = 24;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.BackColor = System.Drawing.Color.LightCoral;
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Location = new System.Drawing.Point(512, 337);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(75, 23);
            this.btatualizar.TabIndex = 25;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = false;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btdeletar
            // 
            this.btdeletar.BackColor = System.Drawing.Color.Salmon;
            this.btdeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletar.Location = new System.Drawing.Point(605, 337);
            this.btdeletar.Name = "btdeletar";
            this.btdeletar.Size = new System.Drawing.Size(75, 23);
            this.btdeletar.TabIndex = 26;
            this.btdeletar.Text = "Deletar";
            this.btdeletar.UseVisualStyleBackColor = false;
            // 
            // textEndereco
            // 
            this.textEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEndereco.Location = new System.Drawing.Point(72, 264);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(267, 102);
            this.textEndereco.TabIndex = 27;
            // 
            // PainelDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.btdeletar);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.dvgUsuario);
            this.Controls.Add(this.txtpesquisarusuario);
            this.Controls.Add(this.textPesquisarUsuario);
            this.Controls.Add(this.comboTipoUsuario);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.textContato);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.txttipousuario);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtcontato);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PainelDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelDeUsuario";
            this.Load += new System.EventHandler(this.PainelDeUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txtsobrenome;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.Label txtcontato;
        private System.Windows.Forms.Label txtendereco;
        private System.Windows.Forms.Label txtsexo;
        private System.Windows.Forms.Label txttipousuario;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textContato;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.ComboBox comboTipoUsuario;
        private System.Windows.Forms.TextBox textPesquisarUsuario;
        private System.Windows.Forms.Label txtpesquisarusuario;
        private System.Windows.Forms.DataGridView dvgUsuario;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btdeletar;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}