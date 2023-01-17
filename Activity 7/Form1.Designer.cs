namespace Activity_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.resultMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of terms:";
            // 
            // tBInput
            // 
            this.tBInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBInput.Location = new System.Drawing.Point(557, 62);
            this.tBInput.Multiline = true;
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(175, 33);
            this.tBInput.TabIndex = 1;
            // 
            // bCalculate
            // 
            this.bCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.Location = new System.Drawing.Point(382, 130);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(228, 64);
            this.bCalculate.TabIndex = 2;
            this.bCalculate.Text = "Calulate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // resultMessage
            // 
            this.resultMessage.AutoSize = true;
            this.resultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMessage.Location = new System.Drawing.Point(59, 244);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(0, 33);
            this.resultMessage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label resultMessage;
    }
}

