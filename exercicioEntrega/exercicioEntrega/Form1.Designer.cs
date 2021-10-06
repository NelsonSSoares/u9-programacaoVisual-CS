
namespace exercicioEntrega
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
            this.listTabuada = new System.Windows.Forms.ListBox();
            this.lblTabuada = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTabuada
            // 
            this.listTabuada.FormattingEnabled = true;
            this.listTabuada.ItemHeight = 15;
            this.listTabuada.Location = new System.Drawing.Point(247, 24);
            this.listTabuada.Name = "listTabuada";
            this.listTabuada.Size = new System.Drawing.Size(135, 289);
            this.listTabuada.TabIndex = 0;
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Location = new System.Drawing.Point(56, 55);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(54, 15);
            this.lblTabuada.TabIndex = 1;
            this.lblTabuada.Text = "Tabuada:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(33, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(22, 102);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 337);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTabuada);
            this.Controls.Add(this.listTabuada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTabuada;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
    }
}

