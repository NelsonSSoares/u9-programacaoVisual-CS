
namespace Holerite
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFGTS = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRRF = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDep = new System.Windows.Forms.Label();
            this.lvlVT = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.txtSaliq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.cboDEP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(41, 50);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 15);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salario Base:";
            // 
            // lblFGTS
            // 
            this.lblFGTS.AutoSize = true;
            this.lblFGTS.Location = new System.Drawing.Point(7, 193);
            this.lblFGTS.Name = "lblFGTS";
            this.lblFGTS.Size = new System.Drawing.Size(33, 15);
            this.lblFGTS.TabIndex = 1;
            this.lblFGTS.Text = "FGTS";
            this.lblFGTS.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(226, 193);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(31, 15);
            this.lblINSS.TabIndex = 2;
            this.lblINSS.Text = "INSS";
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Location = new System.Drawing.Point(7, 242);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(30, 15);
            this.lblIRRF.TabIndex = 3;
            this.lblIRRF.Text = "IRRF";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(41, 68);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 23);
            this.txtSal.TabIndex = 4;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Enabled = false;
            this.txtFGTS.Location = new System.Drawing.Point(7, 211);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.Size = new System.Drawing.Size(100, 23);
            this.txtFGTS.TabIndex = 5;
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(226, 211);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(100, 23);
            this.txtINSS.TabIndex = 6;
            // 
            // txtIRRF
            // 
            this.txtIRRF.Enabled = false;
            this.txtIRRF.Location = new System.Drawing.Point(7, 260);
            this.txtIRRF.Name = "txtIRRF";
            this.txtIRRF.Size = new System.Drawing.Size(102, 23);
            this.txtIRRF.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(44, 112);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(238, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(180, 50);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(72, 15);
            this.lblDep.TabIndex = 9;
            this.lblDep.Text = "Depedentes:";
            // 
            // lvlVT
            // 
            this.lvlVT.AutoSize = true;
            this.lvlVT.Location = new System.Drawing.Point(223, 242);
            this.lvlVT.Name = "lvlVT";
            this.lvlVT.Size = new System.Drawing.Size(23, 15);
            this.lvlVT.TabIndex = 11;
            this.lvlVT.Text = "VT:";
            // 
            // txtVT
            // 
            this.txtVT.Enabled = false;
            this.txtVT.Location = new System.Drawing.Point(226, 260);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(100, 23);
            this.txtVT.TabIndex = 12;
            // 
            // txtSaliq
            // 
            this.txtSaliq.Enabled = false;
            this.txtSaliq.Location = new System.Drawing.Point(120, 341);
            this.txtSaliq.Name = "txtSaliq";
            this.txtSaliq.Size = new System.Drawing.Size(100, 23);
            this.txtSaliq.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salario liquido:";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Checked = true;
            this.rbtnSim.Location = new System.Drawing.Point(226, 289);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(45, 19);
            this.rbtnSim.TabIndex = 15;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(277, 289);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(47, 19);
            this.rbtnNao.TabIndex = 16;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // cboDEP
            // 
            this.cboDEP.FormattingEnabled = true;
            this.cboDEP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboDEP.Location = new System.Drawing.Point(180, 68);
            this.cboDEP.Name = "cboDEP";
            this.cboDEP.Size = new System.Drawing.Size(102, 23);
            this.cboDEP.TabIndex = 17;
            this.cboDEP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.cboDEP);
            this.Controls.Add(this.rbtnNao);
            this.Controls.Add(this.rbtnSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaliq);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.lvlVT);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIRRF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFGTS);
            this.Controls.Add(this.lblSalario);
            this.Name = "Form1";
            this.Text = "Holerite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFGTS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRRF;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtFGTS;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRRF;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lvlVT;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.TextBox txtSaliq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.ComboBox cboDEP;
    }
}

