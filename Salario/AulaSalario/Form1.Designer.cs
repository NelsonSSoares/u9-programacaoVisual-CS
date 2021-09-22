
namespace AulaSalario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblfgts = new System.Windows.Forms.Label();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Salario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(12, 45);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 23);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // btnVerifica
            // 
            this.btnVerifica.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnVerifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifica.Location = new System.Drawing.Point(182, 39);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(114, 28);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "&Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblfgts
            // 
            this.lblfgts.AutoSize = true;
            this.lblfgts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfgts.Location = new System.Drawing.Point(9, 90);
            this.lblfgts.Name = "lblfgts";
            this.lblfgts.Size = new System.Drawing.Size(46, 21);
            this.lblfgts.TabIndex = 3;
            this.lblfgts.Text = "FGTS";
            // 
            // txtFGTS
            // 
            this.txtFGTS.Enabled = false;
            this.txtFGTS.Location = new System.Drawing.Point(10, 114);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.Size = new System.Drawing.Size(133, 23);
            this.txtFGTS.TabIndex = 4;
            this.txtFGTS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 300);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.lblfgts);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Verifica FGTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblfgts;
        private System.Windows.Forms.TextBox txtFGTS;
    }
}

