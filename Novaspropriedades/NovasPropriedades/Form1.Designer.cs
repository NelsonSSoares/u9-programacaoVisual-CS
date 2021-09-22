
namespace NovasPropriedades
{
    partial class Form1
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
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.lblPagto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblParcela = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPagamento
            // 
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(56, 107);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(121, 23);
            this.cboPagamento.TabIndex = 2;
            this.cboPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblPagto
            // 
            this.lblPagto.AutoSize = true;
            this.lblPagto.Location = new System.Drawing.Point(56, 89);
            this.lblPagto.Name = "lblPagto";
            this.lblPagto.Size = new System.Drawing.Size(124, 15);
            this.lblPagto.TabIndex = 2;
            this.lblPagto.Text = "Forma de Pagamento:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(59, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Valor Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(56, 41);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 23);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(56, 209);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(93, 15);
            this.lblParcela.TabIndex = 5;
            this.lblParcela.Text = "Valor da Parcela:";
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(56, 227);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(121, 23);
            this.txtParcela.TabIndex = 3;
            this.txtParcela.TextChanged += new System.EventHandler(this.txtParcela_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPagto);
            this.Controls.Add(this.cboPagamento);
            this.Name = "Form1";
            this.Text = "Calcular Desconto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPagamento;
        private System.Windows.Forms.Label lblPagto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Button button1;
    }
}

