namespace Activity_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FatResults = new System.Windows.Forms.TextBox();
            this.CarbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Fat grams and Carbohydrate grams consumed in a day:";
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(561, 26);
            this.UserInput.Multiline = true;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(182, 50);
            this.UserInput.TabIndex = 1;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCalculate
            // 
            this.bCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.Location = new System.Drawing.Point(561, 146);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(182, 50);
            this.bCalculate.TabIndex = 2;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = false;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.IndianRed;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(95, 146);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(182, 50);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calories from fat:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calories from carbs:";
            // 
            // FatResults
            // 
            this.FatResults.BackColor = System.Drawing.SystemColors.Menu;
            this.FatResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FatResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatResults.Location = new System.Drawing.Point(561, 257);
            this.FatResults.Multiline = true;
            this.FatResults.Name = "FatResults";
            this.FatResults.Size = new System.Drawing.Size(182, 50);
            this.FatResults.TabIndex = 6;
            this.FatResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarbResults
            // 
            this.CarbResults.BackColor = System.Drawing.SystemColors.Menu;
            this.CarbResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbResults.Location = new System.Drawing.Point(561, 354);
            this.CarbResults.Multiline = true;
            this.CarbResults.Name = "CarbResults";
            this.CarbResults.Size = new System.Drawing.Size(182, 50);
            this.CarbResults.TabIndex = 7;
            this.CarbResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarbResults);
            this.Controls.Add(this.FatResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FatResults;
        private System.Windows.Forms.TextBox CarbResults;
    }
}

