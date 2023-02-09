
namespace Blaze_2._0 {
    partial class FrmLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtEntrar = new System.Windows.Forms.Button();
            this.LbSenha = new System.Windows.Forms.Label();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtEntrar
            // 
            this.BtEntrar.Location = new System.Drawing.Point(74, 136);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(181, 36);
            this.BtEntrar.TabIndex = 11;
            this.BtEntrar.Text = "ENTRAR";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.Location = new System.Drawing.Point(23, 68);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(63, 18);
            this.LbSenha.TabIndex = 10;
            this.LbSenha.Text = "SENHA:";
            this.LbSenha.Click += new System.EventHandler(this.LbSenha_Click);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(23, 22);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(79, 18);
            this.LbUsuario.TabIndex = 9;
            this.LbUsuario.Text = "USUÁRIO:";
            this.LbUsuario.Click += new System.EventHandler(this.LbUsuario_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(110, 65);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(190, 24);
            this.TxtSenha.TabIndex = 8;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(110, 22);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(190, 24);
            this.TxtUsuario.TabIndex = 7;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 191);
            this.Controls.Add(this.BtEntrar);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
    }
}