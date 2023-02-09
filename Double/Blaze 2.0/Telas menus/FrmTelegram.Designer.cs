
namespace Blaze_2._0.Telas_menus {
    partial class FrmTelegram {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelegram));
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LbId = new System.Windows.Forms.Label();
            this.LbToken = new System.Windows.Forms.Label();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(229, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(341, 24);
            this.TxtId.TabIndex = 3;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(12, 37);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(165, 18);
            this.LbId.TabIndex = 1;
            this.LbId.Text = "ID DO GRUPO/CANAL:";
            // 
            // LbToken
            // 
            this.LbToken.AutoSize = true;
            this.LbToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbToken.Location = new System.Drawing.Point(12, 86);
            this.LbToken.Name = "LbToken";
            this.LbToken.Size = new System.Drawing.Size(203, 18);
            this.LbToken.TabIndex = 2;
            this.LbToken.Text = "TOKEN DO GRUPO/CANAL:";
            // 
            // TxtToken
            // 
            this.TxtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtToken.Location = new System.Drawing.Point(229, 83);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(341, 24);
            this.TxtToken.TabIndex = 4;
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtualizar.Location = new System.Drawing.Point(172, 170);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(256, 36);
            this.BtAtualizar.TabIndex = 5;
            this.BtAtualizar.Text = "ATUALIZAR DADOS";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // FrmTelegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 219);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.TxtToken);
            this.Controls.Add(this.LbToken);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.TxtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelegram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR/ALTERAR DADOS TELEGRAM";
            this.Load += new System.EventHandler(this.FrmTelegram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label LbToken;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Button BtAtualizar;
    }
}