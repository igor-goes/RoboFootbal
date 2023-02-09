
namespace Blaze_2._0.Telas_menus {
    partial class FrmUsuario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.DgDados = new System.Windows.Forms.DataGridView();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.LbSenha = new System.Windows.Forms.Label();
            this.BtAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgDados
            // 
            this.DgDados.AllowUserToAddRows = false;
            this.DgDados.AllowUserToDeleteRows = false;
            this.DgDados.AllowUserToResizeColumns = false;
            this.DgDados.AllowUserToResizeRows = false;
            this.DgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDados.Location = new System.Drawing.Point(15, 108);
            this.DgDados.Name = "DgDados";
            this.DgDados.ReadOnly = true;
            this.DgDados.RowHeadersVisible = false;
            this.DgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgDados.Size = new System.Drawing.Size(452, 135);
            this.DgDados.TabIndex = 1;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(99, 18);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(265, 24);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(99, 51);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(265, 24);
            this.TxtSenha.TabIndex = 3;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(12, 18);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(79, 18);
            this.LbUsuario.TabIndex = 4;
            this.LbUsuario.Text = "USUÁRIO:";
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.Location = new System.Drawing.Point(12, 54);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(63, 18);
            this.LbSenha.TabIndex = 5;
            this.LbSenha.Text = "SENHA:";
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Location = new System.Drawing.Point(387, 18);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(80, 57);
            this.BtAtualizar.TabIndex = 6;
            this.BtAtualizar.Text = "ATUALIZAR DADOS";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 255);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.DgDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE USUÁRIO";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgDados;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.Button BtAtualizar;
    }
}