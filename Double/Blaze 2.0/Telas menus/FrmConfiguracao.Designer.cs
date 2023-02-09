
namespace Blaze_2._0.Telas_menus {
    partial class FrmConfiguracao {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracao));
            this.CkSom = new System.Windows.Forms.CheckBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.TxtNumeroMartingale = new System.Windows.Forms.NumericUpDown();
            this.LbMartingale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroMartingale)).BeginInit();
            this.SuspendLayout();
            // 
            // CkSom
            // 
            this.CkSom.AutoSize = true;
            this.CkSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkSom.Location = new System.Drawing.Point(33, 19);
            this.CkSom.Name = "CkSom";
            this.CkSom.Size = new System.Drawing.Size(116, 22);
            this.CkSom.TabIndex = 0;
            this.CkSom.Text = "ATIVAR SOM";
            this.CkSom.UseVisualStyleBackColor = true;
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtualizar.Location = new System.Drawing.Point(33, 103);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(256, 36);
            this.BtAtualizar.TabIndex = 6;
            this.BtAtualizar.Text = "ATUALIZAR DADOS";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // TxtNumeroMartingale
            // 
            this.TxtNumeroMartingale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroMartingale.Location = new System.Drawing.Point(189, 56);
            this.TxtNumeroMartingale.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxtNumeroMartingale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtNumeroMartingale.Name = "TxtNumeroMartingale";
            this.TxtNumeroMartingale.Size = new System.Drawing.Size(55, 24);
            this.TxtNumeroMartingale.TabIndex = 7;
            this.TxtNumeroMartingale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbMartingale
            // 
            this.LbMartingale.AutoSize = true;
            this.LbMartingale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMartingale.Location = new System.Drawing.Point(31, 58);
            this.LbMartingale.Name = "LbMartingale";
            this.LbMartingale.Size = new System.Drawing.Size(147, 18);
            this.LbMartingale.TabIndex = 8;
            this.LbMartingale.Text = "QTD. MARTINGALE:";
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 163);
            this.Controls.Add(this.LbMartingale);
            this.Controls.Add(this.TxtNumeroMartingale);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.CkSom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÕES";
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroMartingale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkSom;
        private System.Windows.Forms.Button BtAtualizar;
        private System.Windows.Forms.NumericUpDown TxtNumeroMartingale;
        private System.Windows.Forms.Label LbMartingale;
    }
}