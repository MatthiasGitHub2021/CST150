namespace Activity_14
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
            this.LB_Friends = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RB_Yes = new System.Windows.Forms.RadioButton();
            this.RB_No = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_State = new System.Windows.Forms.CheckBox();
            this.CB_TZ = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TimeDisplay = new System.Windows.Forms.TextBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LB_Details = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select friend:";
            // 
            // LB_Friends
            // 
            this.LB_Friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Friends.FormattingEnabled = true;
            this.LB_Friends.ItemHeight = 24;
            this.LB_Friends.Items.AddRange(new object[] {
            "Chris/Darbie",
            "Dustin/Katey",
            "Aunt Sam",
            "Mark/Misty",
            "Dave"});
            this.LB_Friends.Location = new System.Drawing.Point(51, 58);
            this.LB_Friends.Name = "LB_Friends";
            this.LB_Friends.Size = new System.Drawing.Size(201, 148);
            this.LB_Friends.TabIndex = 1;
            this.LB_Friends.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.LB_Friends.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Military Time:";
            // 
            // RB_Yes
            // 
            this.RB_Yes.AutoSize = true;
            this.RB_Yes.Enabled = false;
            this.RB_Yes.Location = new System.Drawing.Point(51, 245);
            this.RB_Yes.Name = "RB_Yes";
            this.RB_Yes.Size = new System.Drawing.Size(43, 17);
            this.RB_Yes.TabIndex = 3;
            this.RB_Yes.TabStop = true;
            this.RB_Yes.Text = "Yes";
            this.RB_Yes.UseVisualStyleBackColor = true;
            this.RB_Yes.CheckedChanged += new System.EventHandler(this.RB_Yes_CheckedChanged);
            // 
            // RB_No
            // 
            this.RB_No.AutoSize = true;
            this.RB_No.Enabled = false;
            this.RB_No.Location = new System.Drawing.Point(51, 269);
            this.RB_No.Name = "RB_No";
            this.RB_No.Size = new System.Drawing.Size(39, 17);
            this.RB_No.TabIndex = 4;
            this.RB_No.TabStop = true;
            this.RB_No.Text = "No";
            this.RB_No.UseVisualStyleBackColor = true;
            this.RB_No.CheckedChanged += new System.EventHandler(this.RB_No_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display details:";
            // 
            // CB_State
            // 
            this.CB_State.AutoSize = true;
            this.CB_State.Enabled = false;
            this.CB_State.Location = new System.Drawing.Point(51, 338);
            this.CB_State.Name = "CB_State";
            this.CB_State.Size = new System.Drawing.Size(51, 17);
            this.CB_State.TabIndex = 6;
            this.CB_State.Text = "State";
            this.CB_State.UseVisualStyleBackColor = true;
            this.CB_State.CheckedChanged += new System.EventHandler(this.CB_State_CheckedChanged);
            // 
            // CB_TZ
            // 
            this.CB_TZ.AutoSize = true;
            this.CB_TZ.Enabled = false;
            this.CB_TZ.Location = new System.Drawing.Point(51, 361);
            this.CB_TZ.Name = "CB_TZ";
            this.CB_TZ.Size = new System.Drawing.Size(77, 17);
            this.CB_TZ.TabIndex = 7;
            this.CB_TZ.Text = "Time Zone";
            this.CB_TZ.UseVisualStyleBackColor = true;
            this.CB_TZ.CheckedChanged += new System.EventHandler(this.CB_TZ_Checked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Time of selected friend:";
            // 
            // TB_TimeDisplay
            // 
            this.TB_TimeDisplay.Enabled = false;
            this.TB_TimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TimeDisplay.Location = new System.Drawing.Point(401, 109);
            this.TB_TimeDisplay.Name = "TB_TimeDisplay";
            this.TB_TimeDisplay.Size = new System.Drawing.Size(269, 29);
            this.TB_TimeDisplay.TabIndex = 10;
            this.TB_TimeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(473, 295);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(109, 38);
            this.BTN_Exit.TabIndex = 11;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LB_Details
            // 
            this.LB_Details.BackColor = System.Drawing.SystemColors.Menu;
            this.LB_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_Details.Enabled = false;
            this.LB_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Details.ItemHeight = 24;
            this.LB_Details.Location = new System.Drawing.Point(401, 157);
            this.LB_Details.Name = "LB_Details";
            this.LB_Details.Size = new System.Drawing.Size(264, 120);
            this.LB_Details.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Details);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.TB_TimeDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_TZ);
            this.Controls.Add(this.CB_State);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RB_No);
            this.Controls.Add(this.RB_Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Friends);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Friend Time Zones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Friends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_Yes;
        private System.Windows.Forms.RadioButton RB_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_State;
        private System.Windows.Forms.CheckBox CB_TZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_TimeDisplay;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.ListBox LB_Details;
    }
}

