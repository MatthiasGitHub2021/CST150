namespace Milestone_4
{
    partial class DisplayForm
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
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TB_NameSearch = new System.Windows.Forms.TextBox();
            this.TB_DescriptionSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(365, 275);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 23);
            this.BTN_Search.TabIndex = 0;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TB_NameSearch
            // 
            this.TB_NameSearch.Location = new System.Drawing.Point(352, 137);
            this.TB_NameSearch.Name = "TB_NameSearch";
            this.TB_NameSearch.Size = new System.Drawing.Size(100, 23);
            this.TB_NameSearch.TabIndex = 1;
            // 
            // TB_DescriptionSearch
            // 
            this.TB_DescriptionSearch.Location = new System.Drawing.Point(352, 190);
            this.TB_DescriptionSearch.Name = "TB_DescriptionSearch";
            this.TB_DescriptionSearch.Size = new System.Drawing.Size(100, 23);
            this.TB_DescriptionSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_DescriptionSearch);
            this.Controls.Add(this.TB_NameSearch);
            this.Controls.Add(this.BTN_Search);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Search;
        private TextBox TB_NameSearch;
        private TextBox TB_DescriptionSearch;
        private Label label1;
        private Label label2;
    }
}