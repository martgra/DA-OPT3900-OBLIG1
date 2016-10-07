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
            this.greedyItterative = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numberOfCities = new System.Windows.Forms.TextBox();
            this.randomResult = new System.Windows.Forms.Label();
            this.itRandomResult = new System.Windows.Forms.Label();
            this.greedyResult = new System.Windows.Forms.Label();
            this.GreedyItterativeResult = new System.Windows.Forms.Label();
            this.GRandomInput = new System.Windows.Forms.Label();
            this.GRandomInputResult = new System.Windows.Forms.Label();
            this.GRandomItterativeInput = new System.Windows.Forms.Label();
            this.GRandomItterativeResult = new System.Windows.Forms.Label();
            this.RandomMean = new System.Windows.Forms.Label();
            this.RandomItterativeMean = new System.Windows.Forms.Label();
            this.GreedyMean = new System.Windows.Forms.Label();
            this.GreedyItterativeGreedyMean = new System.Windows.Forms.Label();
            this.GreedyItterativeRandomMean = new System.Windows.Forms.Label();
            this.GreedyItterativeRandomItterativeMean = new System.Windows.Forms.Label();
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
            // greedyItterative
            // 
            this.greedyItterative.AutoSize = true;
            this.greedyItterative.Location = new System.Drawing.Point(9, 112);
            this.greedyItterative.Name = "greedyItterative";
            this.greedyItterative.Size = new System.Drawing.Size(146, 13);
            this.greedyItterative.TabIndex = 4;
            this.greedyItterative.Text = "Greedy Itterative Greey Input:";
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
            this.randomResult.Location = new System.Drawing.Point(266, 44);
            this.randomResult.Name = "randomResult";
            this.randomResult.Size = new System.Drawing.Size(0, 13);
            this.randomResult.TabIndex = 8;
            // 
            // itRandomResult
            // 
            this.itRandomResult.AutoSize = true;
            this.itRandomResult.Location = new System.Drawing.Point(266, 67);
            this.itRandomResult.Name = "itRandomResult";
            this.itRandomResult.Size = new System.Drawing.Size(0, 13);
            this.itRandomResult.TabIndex = 9;
            // 
            // greedyResult
            // 
            this.greedyResult.AutoSize = true;
            this.greedyResult.Location = new System.Drawing.Point(266, 91);
            this.greedyResult.Name = "greedyResult";
            this.greedyResult.Size = new System.Drawing.Size(0, 13);
            this.greedyResult.TabIndex = 10;
            // 
            // GreedyItterativeResult
            // 
            this.GreedyItterativeResult.AutoSize = true;
            this.GreedyItterativeResult.Location = new System.Drawing.Point(266, 113);
            this.GreedyItterativeResult.Name = "GreedyItterativeResult";
            this.GreedyItterativeResult.Size = new System.Drawing.Size(0, 13);
            this.GreedyItterativeResult.TabIndex = 10;
            // 
            // GRandomInput
            // 
            this.GRandomInput.AutoSize = true;
            this.GRandomInput.Location = new System.Drawing.Point(9, 135);
            this.GRandomInput.Name = "GRandomInput";
            this.GRandomInput.Size = new System.Drawing.Size(158, 13);
            this.GRandomInput.TabIndex = 4;
            this.GRandomInput.Text = "Greedy Itterative Random Input:";
            this.GRandomInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // GRandomInputResult
            // 
            this.GRandomInputResult.AutoSize = true;
            this.GRandomInputResult.Location = new System.Drawing.Point(266, 136);
            this.GRandomInputResult.Name = "GRandomInputResult";
            this.GRandomInputResult.Size = new System.Drawing.Size(0, 13);
            this.GRandomInputResult.TabIndex = 10;
            this.GRandomInputResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // GRandomItterativeInput
            // 
            this.GRandomItterativeInput.AutoSize = true;
            this.GRandomItterativeInput.Location = new System.Drawing.Point(9, 161);
            this.GRandomItterativeInput.Name = "GRandomItterativeInput";
            this.GRandomItterativeInput.Size = new System.Drawing.Size(199, 13);
            this.GRandomItterativeInput.TabIndex = 4;
            this.GRandomItterativeInput.Text = "Greedy Itterative Random Itterative Input";
            this.GRandomItterativeInput.Click += new System.EventHandler(this.label5_Click);
            // 
            // GRandomItterativeResult
            // 
            this.GRandomItterativeResult.AutoSize = true;
            this.GRandomItterativeResult.Location = new System.Drawing.Point(266, 161);
            this.GRandomItterativeResult.Name = "GRandomItterativeResult";
            this.GRandomItterativeResult.Size = new System.Drawing.Size(0, 13);
            this.GRandomItterativeResult.TabIndex = 10;
            this.GRandomItterativeResult.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.RandomMean.AutoSize = true;
            this.RandomMean.Location = new System.Drawing.Point(377, 44);
            this.RandomMean.Name = "label1";
            this.RandomMean.Size = new System.Drawing.Size(0, 13);
            this.RandomMean.TabIndex = 8;
            // 
            // label4
            // 
            this.RandomItterativeMean.AutoSize = true;
            this.RandomItterativeMean.Location = new System.Drawing.Point(377, 67);
            this.RandomItterativeMean.Name = "label4";
            this.RandomItterativeMean.Size = new System.Drawing.Size(0, 13);
            this.RandomItterativeMean.TabIndex = 9;
            // 
            // label5
            // 
            this.GreedyMean.AutoSize = true;
            this.GreedyMean.Location = new System.Drawing.Point(377, 91);
            this.GreedyMean.Name = "label5";
            this.GreedyMean.Size = new System.Drawing.Size(0, 13);
            this.GreedyMean.TabIndex = 10;
            // 
            // label6
            // 
            this.GreedyItterativeGreedyMean.AutoSize = true;
            this.GreedyItterativeGreedyMean.Location = new System.Drawing.Point(377, 112);
            this.GreedyItterativeGreedyMean.Name = "label6";
            this.GreedyItterativeGreedyMean.Size = new System.Drawing.Size(0, 13);
            this.GreedyItterativeGreedyMean.TabIndex = 10;
            // 
            // label7
            // 
            this.GreedyItterativeRandomMean.AutoSize = true;
            this.GreedyItterativeRandomMean.Location = new System.Drawing.Point(377, 135);
            this.GreedyItterativeRandomMean.Name = "label7";
            this.GreedyItterativeRandomMean.Size = new System.Drawing.Size(0, 13);
            this.GreedyItterativeRandomMean.TabIndex = 10;
            this.GreedyItterativeRandomMean.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.GreedyItterativeRandomItterativeMean.AutoSize = true;
            this.GreedyItterativeRandomItterativeMean.Location = new System.Drawing.Point(377, 161);
            this.GreedyItterativeRandomItterativeMean.Name = "label8";
            this.GreedyItterativeRandomItterativeMean.Size = new System.Drawing.Size(0, 13);
            this.GreedyItterativeRandomItterativeMean.TabIndex = 10;
            this.GreedyItterativeRandomItterativeMean.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 273);
            this.Controls.Add(this.GreedyItterativeRandomItterativeMean);
            this.Controls.Add(this.GRandomItterativeResult);
            this.Controls.Add(this.GreedyItterativeRandomMean);
            this.Controls.Add(this.GRandomInputResult);
            this.Controls.Add(this.GreedyItterativeGreedyMean);
            this.Controls.Add(this.GreedyItterativeResult);
            this.Controls.Add(this.GreedyMean);
            this.Controls.Add(this.greedyResult);
            this.Controls.Add(this.RandomItterativeMean);
            this.Controls.Add(this.itRandomResult);
            this.Controls.Add(this.RandomMean);
            this.Controls.Add(this.randomResult);
            this.Controls.Add(this.GRandomItterativeInput);
            this.Controls.Add(this.GRandomInput);
            this.Controls.Add(this.greedyItterative);
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
        private System.Windows.Forms.Label greedyResult;
        private System.Windows.Forms.Label GreedyItterativeResult;
        private System.Windows.Forms.Label greedyItterative;
        private System.Windows.Forms.Label GRandomInput;
        private System.Windows.Forms.Label GRandomInputResult;
        private System.Windows.Forms.Label GRandomItterativeInput;
        private System.Windows.Forms.Label GRandomItterativeResult;
        private System.Windows.Forms.Label RandomMean;
        private System.Windows.Forms.Label RandomItterativeMean;
        private System.Windows.Forms.Label GreedyMean;
        private System.Windows.Forms.Label GreedyItterativeGreedyMean;
        private System.Windows.Forms.Label GreedyItterativeRandomMean;
        private System.Windows.Forms.Label GreedyItterativeRandomItterativeMean;
    }
}

