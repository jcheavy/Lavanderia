
namespace Lavanderia
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txUsurio = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.ImageLogin = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(237, 186);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(114, 33);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(73, 186);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(114, 33);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(69, 122);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(77, 21);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario :";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(69, 154);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(66, 21);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha :";
            this.lbSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txUsurio
            // 
            this.txUsurio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsurio.Location = new System.Drawing.Point(152, 114);
            this.txUsurio.Name = "txUsurio";
            this.txUsurio.Size = new System.Drawing.Size(199, 29);
            this.txUsurio.TabIndex = 4;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(152, 146);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(199, 29);
            this.txSenha.TabIndex = 5;
            this.txSenha.TextChanged += new System.EventHandler(this.txSenha_TextChanged);
            // 
            // ImageLogin
            // 
            this.ImageLogin.Image = ((System.Drawing.Image)(resources.GetObject("ImageLogin.Image")));
            this.ImageLogin.Location = new System.Drawing.Point(68, 12);
            this.ImageLogin.Name = "ImageLogin";
            this.ImageLogin.Size = new System.Drawing.Size(283, 81);
            this.ImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageLogin.TabIndex = 6;
            this.ImageLogin.TabStop = false;
            this.ImageLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(169)))));
            this.btSair.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(73, 236);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(278, 36);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(424, 307);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.ImageLogin);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txUsurio);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txUsurio;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.PictureBox ImageLogin;
        private System.Windows.Forms.Button btSair;
    }
}

