
namespace Blaze_2._0.Telas_menus {
    partial class FrmTimeLine {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimeLine));
            this.DgDados = new System.Windows.Forms.DataGridView();
            this.DtData = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgDados
            // 
            this.DgDados.AllowUserToAddRows = false;
            this.DgDados.AllowUserToDeleteRows = false;
            this.DgDados.AllowUserToResizeColumns = false;
            this.DgDados.AllowUserToResizeRows = false;
            this.DgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDados.Location = new System.Drawing.Point(12, 94);
            this.DgDados.Name = "DgDados";
            this.DgDados.ReadOnly = true;
            this.DgDados.RowHeadersVisible = false;
            this.DgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgDados.Size = new System.Drawing.Size(247, 588);
            this.DgDados.TabIndex = 0;
            // 
            // DtData
            // 
            this.DtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtData.Location = new System.Drawing.Point(10, 34);
            this.DtData.Name = "DtData";
            this.DtData.Size = new System.Drawing.Size(113, 24);
            this.DtData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a data";
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Location = new System.Drawing.Point(163, 14);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(96, 68);
            this.BtAtualizar.TabIndex = 7;
            this.BtAtualizar.Text = "ATUALIZAR";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // FrmTimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 693);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTimeLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIME LINE";
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgDados;
        private System.Windows.Forms.DateTimePicker DtData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtAtualizar;
    }
}