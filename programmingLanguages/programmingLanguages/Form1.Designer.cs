namespace programmingLanguages
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
            System.Windows.Forms.RadioButton rdbDev;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.rdbEnt = new System.Windows.Forms.RadioButton();
            this.rdbInfra = new System.Windows.Forms.RadioButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            rdbDev = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbDev
            // 
            rdbDev.AutoSize = true;
            rdbDev.Location = new System.Drawing.Point(23, 38);
            rdbDev.Name = "rdbDev";
            rdbDev.Size = new System.Drawing.Size(145, 24);
            rdbDev.TabIndex = 0;
            rdbDev.TabStop = true;
            rdbDev.Text = "Desenvolvimento";
            rdbDev.UseVisualStyleBackColor = true;
            rdbDev.CheckedChanged += new System.EventHandler(this.rdbDev_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboList);
            this.groupBox1.Controls.Add(this.rdbEnt);
            this.groupBox1.Controls.Add(this.rdbInfra);
            this.groupBox1.Controls.Add(rdbDev);
            this.groupBox1.Location = new System.Drawing.Point(534, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setores";
            // 
            // cboList
            // 
            this.cboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(35, 169);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(151, 28);
            this.cboList.TabIndex = 3;
            this.cboList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // rdbEnt
            // 
            this.rdbEnt.AutoSize = true;
            this.rdbEnt.Location = new System.Drawing.Point(23, 119);
            this.rdbEnt.Name = "rdbEnt";
            this.rdbEnt.Size = new System.Drawing.Size(129, 24);
            this.rdbEnt.TabIndex = 2;
            this.rdbEnt.TabStop = true;
            this.rdbEnt.Text = "Entreterimento";
            this.rdbEnt.UseVisualStyleBackColor = true;
            this.rdbEnt.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbInfra
            // 
            this.rdbInfra.AutoSize = true;
            this.rdbInfra.Location = new System.Drawing.Point(23, 79);
            this.rdbInfra.Name = "rdbInfra";
            this.rdbInfra.Size = new System.Drawing.Size(110, 24);
            this.rdbInfra.TabIndex = 1;
            this.rdbInfra.TabStop = true;
            this.rdbInfra.Text = "Infraestrtura";
            this.rdbInfra.UseVisualStyleBackColor = true;
            this.rdbInfra.CheckedChanged += new System.EventHandler(this.rdbInfra_CheckedChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(36, 33);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(441, 391);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboList;
        private RadioButton rdbEnt;
        private RadioButton rdbInfra;
        private RadioButton rdbDev;
        private PictureBox picBox;
    }
}