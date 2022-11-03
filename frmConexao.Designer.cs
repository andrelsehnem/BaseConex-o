namespace BaseConexão
{
    partial class frmConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexao));
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.txt_servidor = new System.Windows.Forms.TextBox();
            this.lbl_database = new System.Windows.Forms.Label();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_porta = new System.Windows.Forms.Label();
            this.txt_porta = new System.Windows.Forms.TextBox();
            this.bt_conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_servidor
            // 
            this.lbl_servidor.AutoSize = true;
            this.lbl_servidor.Location = new System.Drawing.Point(12, 9);
            this.lbl_servidor.Name = "lbl_servidor";
            this.lbl_servidor.Size = new System.Drawing.Size(50, 15);
            this.lbl_servidor.TabIndex = 0;
            this.lbl_servidor.Text = "Servidor";
            // 
            // txt_servidor
            // 
            this.txt_servidor.Location = new System.Drawing.Point(12, 27);
            this.txt_servidor.Name = "txt_servidor";
            this.txt_servidor.Size = new System.Drawing.Size(100, 23);
            this.txt_servidor.TabIndex = 1;
            this.txt_servidor.Text = "localhost";
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Location = new System.Drawing.Point(132, 9);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(55, 15);
            this.lbl_database.TabIndex = 2;
            this.lbl_database.Text = "Database";
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(134, 27);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(100, 23);
            this.txt_database.TabIndex = 3;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 61);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(30, 15);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(12, 79);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(70, 23);
            this.txt_user.TabIndex = 5;
            this.txt_user.Text = "root";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(88, 61);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(39, 15);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(88, 79);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(70, 23);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.Text = "vssql";
            // 
            // lbl_porta
            // 
            this.lbl_porta.AutoSize = true;
            this.lbl_porta.Location = new System.Drawing.Point(164, 61);
            this.lbl_porta.Name = "lbl_porta";
            this.lbl_porta.Size = new System.Drawing.Size(35, 15);
            this.lbl_porta.TabIndex = 8;
            this.lbl_porta.Text = "Porta";
            // 
            // txt_porta
            // 
            this.txt_porta.Location = new System.Drawing.Point(164, 79);
            this.txt_porta.Name = "txt_porta";
            this.txt_porta.Size = new System.Drawing.Size(70, 23);
            this.txt_porta.TabIndex = 9;
            this.txt_porta.Text = "3306";
            // 
            // bt_conectar
            // 
            this.bt_conectar.Image = global::BaseConexão.Properties.Resources.Childish_Link_24990;
            this.bt_conectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_conectar.Location = new System.Drawing.Point(66, 123);
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(107, 39);
            this.bt_conectar.TabIndex = 10;
            this.bt_conectar.Text = "Conectar";
            this.bt_conectar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_conectar.UseVisualStyleBackColor = true;
            this.bt_conectar.Click += new System.EventHandler(this.bt_conectar_Click);
            // 
            // frmConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 180);
            this.Controls.Add(this.bt_conectar);
            this.Controls.Add(this.txt_porta);
            this.Controls.Add(this.lbl_porta);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.lbl_database);
            this.Controls.Add(this.txt_servidor);
            this.Controls.Add(this.lbl_servidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexão";
            this.Load += new System.EventHandler(this.frmConexao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.TextBox txt_servidor;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_porta;
        private System.Windows.Forms.TextBox txt_porta;
        private System.Windows.Forms.Button bt_conectar;
    }
}
