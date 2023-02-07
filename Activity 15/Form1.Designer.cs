namespace Activity_15
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.CB_Day = new System.Windows.Forms.ComboBox();
            this.CB_Color = new System.Windows.Forms.ComboBox();
            this.BTN_Lucky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your favorite color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your birth day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your birth month:";
            // 
            // CB_Year
            // 
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Location = new System.Drawing.Point(353, 101);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(192, 21);
            this.CB_Year.TabIndex = 4;
            this.CB_Year.SelectedIndexChanged += new System.EventHandler(this.CB_Year_SelectedIndexChanged);
            // 
            // CB_Month
            // 
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Location = new System.Drawing.Point(353, 144);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(192, 21);
            this.CB_Month.TabIndex = 5;
            this.CB_Month.SelectedIndexChanged += new System.EventHandler(this.CB_Month_SelectedIndexChanged);
            // 
            // CB_Day
            // 
            this.CB_Day.FormattingEnabled = true;
            this.CB_Day.Location = new System.Drawing.Point(353, 184);
            this.CB_Day.Name = "CB_Day";
            this.CB_Day.Size = new System.Drawing.Size(192, 21);
            this.CB_Day.TabIndex = 6;
            // 
            // CB_Color
            // 
            this.CB_Color.FormattingEnabled = true;
            this.CB_Color.Items.AddRange(new object[] {
            "Red",
            "White",
            "Blue",
            "Green",
            "Black",
            "Yellow"});
            this.CB_Color.Location = new System.Drawing.Point(353, 224);
            this.CB_Color.Name = "CB_Color";
            this.CB_Color.Size = new System.Drawing.Size(192, 21);
            this.CB_Color.TabIndex = 7;
            // 
            // BTN_Lucky
            // 
            this.BTN_Lucky.Location = new System.Drawing.Point(240, 291);
            this.BTN_Lucky.Name = "BTN_Lucky";
            this.BTN_Lucky.Size = new System.Drawing.Size(170, 50);
            this.BTN_Lucky.TabIndex = 8;
            this.BTN_Lucky.Text = "Get your lucky number";
            this.BTN_Lucky.UseVisualStyleBackColor = true;
            this.BTN_Lucky.Click += new System.EventHandler(this.BTN_Lucky_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Lucky);
            this.Controls.Add(this.CB_Color);
            this.Controls.Add(this.CB_Day);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.CB_Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.ComboBox CB_Day;
        private System.Windows.Forms.ComboBox CB_Color;
        private System.Windows.Forms.Button BTN_Lucky;
    }
}

