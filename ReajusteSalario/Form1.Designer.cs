
namespace ReajusteSalario
{
    partial class LeituraArquivo
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
            this.txtarquivo = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.dgvleitura = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSemReajuste = new System.Windows.Forms.Label();
            this.lblComReajuste = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvleitura)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtarquivo
            // 
            this.txtarquivo.Enabled = false;
            this.txtarquivo.Location = new System.Drawing.Point(22, 10);
            this.txtarquivo.Name = "txtarquivo";
            this.txtarquivo.Size = new System.Drawing.Size(464, 20);
            this.txtarquivo.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(513, 10);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(44, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "...";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dgvleitura
            // 
            this.dgvleitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvleitura.Location = new System.Drawing.Point(18, 109);
            this.dgvleitura.Name = "dgvleitura";
            this.dgvleitura.Size = new System.Drawing.Size(536, 211);
            this.dgvleitura.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(18, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 64);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.lblSemReajuste, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblComReajuste, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentual, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSemReajuste
            // 
            this.lblSemReajuste.AutoSize = true;
            this.lblSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblSemReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemReajuste.Location = new System.Drawing.Point(3, 0);
            this.lblSemReajuste.Name = "lblSemReajuste";
            this.lblSemReajuste.Size = new System.Drawing.Size(175, 30);
            this.lblSemReajuste.TabIndex = 0;
            this.lblSemReajuste.Text = "Total sem reajuste";
            this.lblSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComReajuste
            // 
            this.lblComReajuste.AutoSize = true;
            this.lblComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblComReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComReajuste.Location = new System.Drawing.Point(184, 0);
            this.lblComReajuste.Name = "lblComReajuste";
            this.lblComReajuste.Size = new System.Drawing.Size(175, 30);
            this.lblComReajuste.TabIndex = 1;
            this.lblComReajuste.Text = "Total Com Reajuste";
            this.lblComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.Location = new System.Drawing.Point(365, 0);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(164, 30);
            this.lblPercentual.TabIndex = 2;
            this.lblPercentual.Text = "Percentual Reajuste";
            this.lblPercentual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt:";
            this.ofdListaFuncionarios.FileName = "listaFuncionarios";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt:";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // LeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvleitura);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtarquivo);
            this.MaximizeBox = false;
            this.Name = "LeituraArquivo";
            this.Text = "Reajuste de folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvleitura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarquivo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvleitura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSemReajuste;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.Label lblComReajuste;
        private System.Windows.Forms.Label lblPercentual;
    }
}

