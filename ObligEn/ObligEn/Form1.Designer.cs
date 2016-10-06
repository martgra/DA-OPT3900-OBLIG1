namespace ObligEn
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
            System.Windows.Forms.Label labRandomMethod;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numberOfCities = new System.Windows.Forms.TextBox();
            this.randomResult = new System.Windows.Forms.Label();
            this.itRandomResult = new System.Windows.Forms.Label();
            labRandomMethod = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labRandomMethod
            // 
            labRandomMethod.AutoSize = true;
            labRandomMethod.Location = new System.Drawing.Point(9, 44);
            labRandomMethod.Name = "labRandomMethod";
            labRandomMethod.Size = new System.Drawing.Size(89, 13);
            labRandomMethod.TabIndex = 2;
            labRandomMethod.Text = "Random Method:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 13);
            label2.TabIndex = 3;
            label2.Text = "Itterative Random:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 13);
            label3.TabIndex = 4;
            label3.Text = "Greedy Method:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.buttonCalculate.Location = new System.Drawing.Point(93, 9);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Beregn";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numberOfCities
            // 
            this.numberOfCities.Location = new System.Drawing.Point(12, 12);
            this.numberOfCities.Name = "numberOfCities";
            this.numberOfCities.Size = new System.Drawing.Size(75, 20);
            this.numberOfCities.TabIndex = 1;
            // 
            // randomResult
            // 
            this.randomResult.AutoSize = true;
            this.randomResult.Location = new System.Drawing.Point(180, 43);
            this.randomResult.Name = "randomResult";
            this.randomResult.Size = new System.Drawing.Size(0, 13);
            this.randomResult.TabIndex = 8;
            // 
            // itRandomResult
            // 
            this.itRandomResult.AutoSize = true;
            this.itRandomResult.Location = new System.Drawing.Point(180, 66);
            this.itRandomResult.Name = "itRandomResult";
            this.itRandomResult.Size = new System.Drawing.Size(0, 13);
            this.itRandomResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 273);
            this.Controls.Add(this.itRandomResult);
            this.Controls.Add(this.randomResult);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(labRandomMethod);
            this.Controls.Add(this.numberOfCities);
            this.Controls.Add(this.buttonCalculate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox numberOfCities;
        private System.Windows.Forms.Label randomResult;
        private System.Windows.Forms.Label itRandomResult;
    }
}

