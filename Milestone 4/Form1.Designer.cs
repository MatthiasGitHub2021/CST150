namespace Milestone_4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.TB_Qty = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Autofill = new System.Windows.Forms.Button();
            this.RB_On = new System.Windows.Forms.RadioButton();
            this.RB_Off = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(168, 183);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(155, 57);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 23);
            this.TB_Name.TabIndex = 3;
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(155, 86);
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(100, 23);
            this.TB_Description.TabIndex = 4;
            // 
            // TB_Qty
            // 
            this.TB_Qty.Location = new System.Drawing.Point(155, 115);
            this.TB_Qty.Name = "TB_Qty";
            this.TB_Qty.Size = new System.Drawing.Size(100, 23);
            this.TB_Qty.TabIndex = 5;
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(155, 144);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(100, 23);
            this.TB_Price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price:";
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(168, 218);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 12;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Autofill
            // 
            this.BTN_Autofill.Location = new System.Drawing.Point(43, 183);
            this.BTN_Autofill.Name = "BTN_Autofill";
            this.BTN_Autofill.Size = new System.Drawing.Size(75, 23);
            this.BTN_Autofill.TabIndex = 13;
            this.BTN_Autofill.Text = "Autofill";
            this.BTN_Autofill.UseVisualStyleBackColor = true;
            this.BTN_Autofill.Click += new System.EventHandler(this.BTN_Autofill_Click);
            // 
            // RB_On
            // 
            this.RB_On.AutoSize = true;
            this.RB_On.Location = new System.Drawing.Point(63, 346);
            this.RB_On.Name = "RB_On";
            this.RB_On.Size = new System.Drawing.Size(41, 19);
            this.RB_On.TabIndex = 14;
            this.RB_On.TabStop = true;
            this.RB_On.Text = "On";
            this.RB_On.UseVisualStyleBackColor = true;
            // 
            // RB_Off
            // 
            this.RB_Off.AutoSize = true;
            this.RB_Off.Location = new System.Drawing.Point(63, 371);
            this.RB_Off.Name = "RB_Off";
            this.RB_Off.Size = new System.Drawing.Size(42, 19);
            this.RB_Off.TabIndex = 15;
            this.RB_Off.TabStop = true;
            this.RB_Off.Text = "Off";
            this.RB_Off.UseVisualStyleBackColor = true;
            this.RB_Off.CheckedChanged += new System.EventHandler(this.RB_Off_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Edit item:";
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(170, 253);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 23);
            this.BTN_Search.TabIndex = 17;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // BTN_Display
            // 
            this.BTN_Display.Location = new System.Drawing.Point(168, 288);
            this.BTN_Display.Name = "BTN_Display";
            this.BTN_Display.Size = new System.Drawing.Size(75, 23);
            this.BTN_Display.TabIndex = 18;
            this.BTN_Display.Text = "Display";
            this.BTN_Display.UseVisualStyleBackColor = true;
            this.BTN_Display.Click += new System.EventHandler(this.BTN_Display_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Display);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RB_Off);
            this.Controls.Add(this.RB_On);
            this.Controls.Add(this.BTN_Autofill);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_Qty);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button BTN_Add;
        private TextBox TB_Name;
        private TextBox TB_Description;
        private TextBox TB_Qty;
        private TextBox TB_Price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BTN_Delete;
        private Button BTN_Autofill;
        private RadioButton RB_On;
        private RadioButton RB_Off;
        private Label label5;
        private Button BTN_Search;
        private Button BTN_Display;
    }
}