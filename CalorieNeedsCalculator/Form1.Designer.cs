namespace CalorieNeedsCalculator
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
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAct0 = new System.Windows.Forms.RadioButton();
            this.btnAct1 = new System.Windows.Forms.RadioButton();
            this.btnAct2 = new System.Windows.Forms.RadioButton();
            this.btnAct3 = new System.Windows.Forms.RadioButton();
            this.btnAct4 = new System.Windows.Forms.RadioButton();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(90, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 0;
            this.txtHeight.Text = "0";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(34, 69);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(34, 95);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(90, 92);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.Text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(34, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 119);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.Text = "0";
            // 
            // btnAct0
            // 
            this.btnAct0.AutoSize = true;
            this.btnAct0.Location = new System.Drawing.Point(37, 162);
            this.btnAct0.Name = "btnAct0";
            this.btnAct0.Size = new System.Drawing.Size(73, 17);
            this.btnAct0.TabIndex = 8;
            this.btnAct0.Text = "Sedentary";
            this.btnAct0.UseVisualStyleBackColor = true;
            // 
            // btnAct1
            // 
            this.btnAct1.AutoSize = true;
            this.btnAct1.Location = new System.Drawing.Point(37, 186);
            this.btnAct1.Name = "btnAct1";
            this.btnAct1.Size = new System.Drawing.Size(174, 17);
            this.btnAct1.TabIndex = 9;
            this.btnAct1.Text = "Walking/Standing. No Exercise";
            this.btnAct1.UseVisualStyleBackColor = true;
            // 
            // btnAct2
            // 
            this.btnAct2.AutoSize = true;
            this.btnAct2.Location = new System.Drawing.Point(37, 210);
            this.btnAct2.Name = "btnAct2";
            this.btnAct2.Size = new System.Drawing.Size(91, 17);
            this.btnAct2.TabIndex = 10;
            this.btnAct2.Text = "Light Exercise";
            this.btnAct2.UseVisualStyleBackColor = true;
            // 
            // btnAct3
            // 
            this.btnAct3.AutoSize = true;
            this.btnAct3.Location = new System.Drawing.Point(37, 234);
            this.btnAct3.Name = "btnAct3";
            this.btnAct3.Size = new System.Drawing.Size(113, 17);
            this.btnAct3.TabIndex = 11;
            this.btnAct3.Text = "Moderate Exercise";
            this.btnAct3.UseVisualStyleBackColor = true;
            // 
            // btnAct4
            // 
            this.btnAct4.AutoSize = true;
            this.btnAct4.Location = new System.Drawing.Point(37, 258);
            this.btnAct4.Name = "btnAct4";
            this.btnAct4.Size = new System.Drawing.Size(103, 17);
            this.btnAct4.TabIndex = 12;
            this.btnAct4.Text = "Intense Exercise";
            this.btnAct4.UseVisualStyleBackColor = true;
            // 
            // cboxGender
            // 
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboxGender.Location = new System.Drawing.Point(90, 12);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(100, 21);
            this.cboxGender.TabIndex = 13;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 15);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(35, 301);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboxGender);
            this.Controls.Add(this.btnAct4);
            this.Controls.Add(this.btnAct3);
            this.Controls.Add(this.btnAct2);
            this.Controls.Add(this.btnAct1);
            this.Controls.Add(this.btnAct0);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Name = "Form1";
            this.Text = "Calorie Needs Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton btnAct0;
        private System.Windows.Forms.RadioButton btnAct1;
        private System.Windows.Forms.RadioButton btnAct2;
        private System.Windows.Forms.RadioButton btnAct3;
        private System.Windows.Forms.RadioButton btnAct4;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCalc;
    }
}

