
namespace Portscan
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFerramentas = new System.Windows.Forms.TableLayoutPanel();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPortas = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.dgvPortas = new System.Windows.Forms.DataGridView();
            this.col_porta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status_porta = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAtivas = new System.Windows.Forms.RadioButton();
            this.rbInativas = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortaInicial = new System.Windows.Forms.TextBox();
            this.txtPortaFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPortas = new System.Windows.Forms.Panel();
            this.tlpFerramentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPortas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFerramentas
            // 
            this.tlpFerramentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpFerramentas.AutoScroll = true;
            this.tlpFerramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tlpFerramentas.ColumnCount = 1;
            this.tlpFerramentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFerramentas.Controls.Add(this.pnlPortas, 0, 3);
            this.tlpFerramentas.Controls.Add(this.lblIp, 0, 0);
            this.tlpFerramentas.Controls.Add(this.lblPortas, 0, 2);
            this.tlpFerramentas.Controls.Add(this.txtIp, 0, 1);
            this.tlpFerramentas.Controls.Add(this.label1, 0, 4);
            this.tlpFerramentas.Controls.Add(this.panel1, 0, 5);
            this.tlpFerramentas.Location = new System.Drawing.Point(12, 12);
            this.tlpFerramentas.Name = "tlpFerramentas";
            this.tlpFerramentas.RowCount = 6;
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFerramentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFerramentas.Size = new System.Drawing.Size(118, 245);
            this.tlpFerramentas.TabIndex = 0;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(3, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(17, 13);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "Ip";
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(3, 55);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(47, 13);
            this.lblPortas.TabIndex = 2;
            this.lblPortas.Text = "Porta(s)";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(3, 23);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(112, 22);
            this.txtIp.TabIndex = 1;
            // 
            // dgvPortas
            // 
            this.dgvPortas.AllowUserToAddRows = false;
            this.dgvPortas.AllowUserToDeleteRows = false;
            this.dgvPortas.AllowUserToResizeRows = false;
            this.dgvPortas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPortas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPortas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPortas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPortas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPortas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPortas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPortas.ColumnHeadersHeight = 30;
            this.dgvPortas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPortas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_porta,
            this.col_status_porta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPortas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPortas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPortas.EnableHeadersVisualStyles = false;
            this.dgvPortas.Location = new System.Drawing.Point(136, 12);
            this.dgvPortas.MultiSelect = false;
            this.dgvPortas.Name = "dgvPortas";
            this.dgvPortas.ReadOnly = true;
            this.dgvPortas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPortas.RowHeadersVisible = false;
            this.dgvPortas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPortas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortas.Size = new System.Drawing.Size(320, 245);
            this.dgvPortas.TabIndex = 3;
            // 
            // col_porta
            // 
            this.col_porta.HeaderText = "Porta";
            this.col_porta.Name = "col_porta";
            this.col_porta.ReadOnly = true;
            // 
            // col_status_porta
            // 
            this.col_status_porta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_status_porta.HeaderText = "Status";
            this.col_status_porta.Image = global::Portscan.Properties.Resources.refresh_16px;
            this.col_status_porta.Name = "col_status_porta";
            this.col_status_porta.ReadOnly = true;
            this.col_status_porta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_status_porta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_status_porta.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = global::Portscan.Properties.Resources.refresh_16px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = global::Portscan.Properties.Resources.search_16px_black;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(12, 263);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 32);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.rbTodas);
            this.panel1.Controls.Add(this.rbInativas);
            this.panel1.Controls.Add(this.rbAtivas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 102);
            this.panel1.TabIndex = 6;
            // 
            // rbAtivas
            // 
            this.rbAtivas.AutoSize = true;
            this.rbAtivas.Location = new System.Drawing.Point(4, 0);
            this.rbAtivas.Name = "rbAtivas";
            this.rbAtivas.Size = new System.Drawing.Size(56, 17);
            this.rbAtivas.TabIndex = 0;
            this.rbAtivas.Text = "Ativas";
            this.rbAtivas.UseVisualStyleBackColor = true;
            // 
            // rbInativas
            // 
            this.rbInativas.AutoSize = true;
            this.rbInativas.Location = new System.Drawing.Point(4, 24);
            this.rbInativas.Name = "rbInativas";
            this.rbInativas.Size = new System.Drawing.Size(64, 17);
            this.rbInativas.TabIndex = 1;
            this.rbInativas.Text = "Inativas";
            this.rbInativas.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(4, 48);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 2;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar por portas: ";
            // 
            // txtPortaInicial
            // 
            this.txtPortaInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPortaInicial.Location = new System.Drawing.Point(3, 4);
            this.txtPortaInicial.Name = "txtPortaInicial";
            this.txtPortaInicial.Size = new System.Drawing.Size(46, 22);
            this.txtPortaInicial.TabIndex = 2;
            // 
            // txtPortaFinal
            // 
            this.txtPortaFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPortaFinal.Location = new System.Drawing.Point(63, 4);
            this.txtPortaFinal.Name = "txtPortaFinal";
            this.txtPortaFinal.Size = new System.Drawing.Size(46, 22);
            this.txtPortaFinal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // pnlPortas
            // 
            this.pnlPortas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.pnlPortas.Controls.Add(this.label3);
            this.pnlPortas.Controls.Add(this.txtPortaFinal);
            this.pnlPortas.Controls.Add(this.txtPortaInicial);
            this.pnlPortas.Location = new System.Drawing.Point(3, 78);
            this.pnlPortas.Name = "pnlPortas";
            this.pnlPortas.Size = new System.Drawing.Size(112, 30);
            this.pnlPortas.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 307);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvPortas);
            this.Controls.Add(this.tlpFerramentas);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
            this.tlpFerramentas.ResumeLayout(false);
            this.tlpFerramentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPortas.ResumeLayout(false);
            this.pnlPortas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFerramentas;
        private System.Windows.Forms.DataGridView dgvPortas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porta;
        private System.Windows.Forms.DataGridViewImageColumn col_status_porta;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbInativas;
        private System.Windows.Forms.RadioButton rbAtivas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPortas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortaFinal;
        private System.Windows.Forms.TextBox txtPortaInicial;
    }
}

