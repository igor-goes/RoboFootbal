
namespace Blaze_2._0.Telas_menus {
    partial class FrmPlacar {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlacar));
            this.CbEstrategia = new System.Windows.Forms.ComboBox();
            this.DtInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtFinal = new System.Windows.Forms.DateTimePicker();
            this.GbEstrategias = new System.Windows.Forms.GroupBox();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.DgDados = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.esconderInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.GbEstrategias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbEstrategia
            // 
            this.CbEstrategia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstrategia.FormattingEnabled = true;
            this.CbEstrategia.Location = new System.Drawing.Point(6, 26);
            this.CbEstrategia.Name = "CbEstrategia";
            this.CbEstrategia.Size = new System.Drawing.Size(262, 24);
            this.CbEstrategia.TabIndex = 0;
            // 
            // DtInicial
            // 
            this.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicial.Location = new System.Drawing.Point(11, 28);
            this.DtInicial.Name = "DtInicial";
            this.DtInicial.Size = new System.Drawing.Size(101, 22);
            this.DtInicial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Até";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtFinal);
            this.groupBox1.Controls.Add(this.DtInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o período";
            // 
            // DtFinal
            // 
            this.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFinal.Location = new System.Drawing.Point(158, 28);
            this.DtFinal.Name = "DtFinal";
            this.DtFinal.Size = new System.Drawing.Size(101, 22);
            this.DtFinal.TabIndex = 4;
            // 
            // GbEstrategias
            // 
            this.GbEstrategias.Controls.Add(this.CbEstrategia);
            this.GbEstrategias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEstrategias.Location = new System.Drawing.Point(325, 12);
            this.GbEstrategias.Name = "GbEstrategias";
            this.GbEstrategias.Size = new System.Drawing.Size(274, 63);
            this.GbEstrategias.TabIndex = 5;
            this.GbEstrategias.TabStop = false;
            this.GbEstrategias.Text = "Selecione a estratégia";
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Location = new System.Drawing.Point(648, 12);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(114, 63);
            this.BtAtualizar.TabIndex = 6;
            this.BtAtualizar.Text = "ATUALIZAR";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // DgDados
            // 
            this.DgDados.AllowUserToAddRows = false;
            this.DgDados.AllowUserToDeleteRows = false;
            this.DgDados.AllowUserToResizeColumns = false;
            this.DgDados.AllowUserToResizeRows = false;
            this.DgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDados.ContextMenuStrip = this.Menu;
            this.DgDados.Location = new System.Drawing.Point(11, 97);
            this.DgDados.Name = "DgDados";
            this.DgDados.ReadOnly = true;
            this.DgDados.RowHeadersVisible = false;
            this.DgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgDados.Size = new System.Drawing.Size(751, 349);
            this.DgDados.TabIndex = 7;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esconderInformaçõesToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(192, 26);
            // 
            // esconderInformaçõesToolStripMenuItem
            // 
            this.esconderInformaçõesToolStripMenuItem.Name = "esconderInformaçõesToolStripMenuItem";
            this.esconderInformaçõesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.esconderInformaçõesToolStripMenuItem.Text = "Esconder informações";
            this.esconderInformaçõesToolStripMenuItem.Click += new System.EventHandler(this.esconderInformaçõesToolStripMenuItem_Click);
            // 
            // FrmPlacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 458);
            this.Controls.Add(this.DgDados);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.GbEstrategias);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLACAR- DOUBLE";
            this.Load += new System.EventHandler(this.FrmPlacar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbEstrategias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgDados)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbEstrategia;
        private System.Windows.Forms.DateTimePicker DtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtFinal;
        private System.Windows.Forms.GroupBox GbEstrategias;
        private System.Windows.Forms.Button BtAtualizar;
        private System.Windows.Forms.DataGridView DgDados;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem esconderInformaçõesToolStripMenuItem;
    }
}