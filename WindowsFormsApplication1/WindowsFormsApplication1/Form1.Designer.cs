namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.totalCost = new System.Windows.Forms.Label();
            this.minCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numbTries = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.greedy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(137, 19);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(0, 13);
            this.totalCost.TabIndex = 2;
            // 
            // minCost
            // 
            this.minCost.AutoSize = true;
            this.minCost.Location = new System.Drawing.Point(175, 49);
            this.minCost.Name = "minCost";
            this.minCost.Size = new System.Drawing.Size(0, 13);
            this.minCost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Random Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Iterative Random Method:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numbTries
            // 
            this.numbTries.Location = new System.Drawing.Point(196, 137);
            this.numbTries.Name = "numbTries";
            this.numbTries.Size = new System.Drawing.Size(100, 20);
            this.numbTries.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of cities:";
            // 
            // greedy
            // 
            this.greedy.AutoSize = true;
            this.greedy.Location = new System.Drawing.Point(18, 76);
            this.greedy.Name = "greedy";
            this.greedy.Size = new System.Drawing.Size(39, 13);
            this.greedy.TabIndex = 8;
            this.greedy.Text = "greedy";
            this.greedy.Click += new System.EventHandler(this.greedy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.greedy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numbTries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minCost);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label minCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbTries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label greedy;
        private System.Windows.Forms.Label label4;
    }
}