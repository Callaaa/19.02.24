namespace Podgotvitelna_zadacha
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.rdChistach = new System.Windows.Forms.RadioButton();
            this.rdProdavach = new System.Windows.Forms.RadioButton();
            this.rdShofyor = new System.Windows.Forms.RadioButton();
            this.rdServivitor = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.grB = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grB.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 39);
            this.txtName.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(12, 130);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(219, 39);
            this.txtLname.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(428, 18);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 39);
            this.txtAge.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(106, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 36);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Woman";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Nachinaesht",
            "sreden",
            "Nachalnik"});
            this.cmb.Location = new System.Drawing.Point(293, 88);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(216, 39);
            this.cmb.TabIndex = 4;
            this.cmb.Text = "Position";
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // rdChistach
            // 
            this.rdChistach.AutoSize = true;
            this.rdChistach.Location = new System.Drawing.Point(6, 35);
            this.rdChistach.Name = "rdChistach";
            this.rdChistach.Size = new System.Drawing.Size(142, 36);
            this.rdChistach.TabIndex = 5;
            this.rdChistach.TabStop = true;
            this.rdChistach.Text = "Chistach";
            this.rdChistach.UseVisualStyleBackColor = true;
            // 
            // rdProdavach
            // 
            this.rdProdavach.AutoSize = true;
            this.rdProdavach.Location = new System.Drawing.Point(6, 73);
            this.rdProdavach.Name = "rdProdavach";
            this.rdProdavach.Size = new System.Drawing.Size(164, 36);
            this.rdProdavach.TabIndex = 6;
            this.rdProdavach.TabStop = true;
            this.rdProdavach.Text = "Prodavach";
            this.rdProdavach.UseVisualStyleBackColor = true;
            // 
            // rdShofyor
            // 
            this.rdShofyor.AutoSize = true;
            this.rdShofyor.Location = new System.Drawing.Point(6, 115);
            this.rdShofyor.Name = "rdShofyor";
            this.rdShofyor.Size = new System.Drawing.Size(131, 36);
            this.rdShofyor.TabIndex = 7;
            this.rdShofyor.TabStop = true;
            this.rdShofyor.Text = "Shofyor";
            this.rdShofyor.UseVisualStyleBackColor = true;
            // 
            // rdServivitor
            // 
            this.rdServivitor.AutoSize = true;
            this.rdServivitor.Location = new System.Drawing.Point(6, 157);
            this.rdServivitor.Name = "rdServivitor";
            this.rdServivitor.Size = new System.Drawing.Size(141, 36);
            this.rdServivitor.TabIndex = 8;
            this.rdServivitor.TabStop = true;
            this.rdServivitor.Text = "Servitior";
            this.rdServivitor.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(263, 277);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(213, 116);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // grB
            // 
            this.grB.Controls.Add(this.rdServivitor);
            this.grB.Controls.Add(this.rdShofyor);
            this.grB.Controls.Add(this.rdChistach);
            this.grB.Controls.Add(this.rdProdavach);
            this.grB.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB.Location = new System.Drawing.Point(19, 187);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(194, 206);
            this.grB.TabIndex = 10;
            this.grB.TabStop = false;
            this.grB.Text = "Job";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 32);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(13, 95);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(141, 32);
            this.lblLname.TabIndex = 12;
            this.lblLname.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grB.ResumeLayout(false);
            this.grB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.RadioButton rdChistach;
        private System.Windows.Forms.RadioButton rdProdavach;
        private System.Windows.Forms.RadioButton rdShofyor;
        private System.Windows.Forms.RadioButton rdServivitor;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label label3;
    }
}

