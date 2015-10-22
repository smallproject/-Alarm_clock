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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbReverse = new System.Windows.Forms.TextBox();
            this.tbNoVowels = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.cbNoVowels = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisplay.Enabled = false;
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.Location = new System.Drawing.Point(32, 3);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDisplay.Size = new System.Drawing.Size(260, 51);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TabStop = false;
            this.tbDisplay.Text = "tbDisplay";
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(363, 460);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(135, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "tbInput";
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbReverse
            // 
            this.tbReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReverse.Enabled = false;
            this.tbReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReverse.Location = new System.Drawing.Point(32, 58);
            this.tbReverse.Multiline = true;
            this.tbReverse.Name = "tbReverse";
            this.tbReverse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReverse.Size = new System.Drawing.Size(260, 51);
            this.tbReverse.TabIndex = 2;
            this.tbReverse.TabStop = false;
            this.tbReverse.Text = "tbReverse";
            this.tbReverse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNoVowels
            // 
            this.tbNoVowels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNoVowels.Enabled = false;
            this.tbNoVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoVowels.Location = new System.Drawing.Point(32, 113);
            this.tbNoVowels.Multiline = true;
            this.tbNoVowels.Name = "tbNoVowels";
            this.tbNoVowels.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNoVowels.Size = new System.Drawing.Size(260, 51);
            this.tbNoVowels.TabIndex = 3;
            this.tbNoVowels.TabStop = false;
            this.tbNoVowels.Text = "tbNoVowels";
            this.tbNoVowels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbNoVowels);
            this.splitContainer1.Panel1.Controls.Add(this.cbReverse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbDisplay);
            this.splitContainer1.Panel2.Controls.Add(this.tbNoVowels);
            this.splitContainer1.Panel2.Controls.Add(this.tbReverse);
            this.splitContainer1.Size = new System.Drawing.Size(485, 423);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 4;
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(22, 69);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(78, 17);
            this.cbReverse.TabIndex = 0;
            this.cbReverse.Text = "cbReverse";
            this.cbReverse.UseVisualStyleBackColor = true;
            this.cbReverse.CheckedChanged += new System.EventHandler(this.cbReverse_CheckedChanged);
            // 
            // cbNoVowels
            // 
            this.cbNoVowels.AutoSize = true;
            this.cbNoVowels.Location = new System.Drawing.Point(22, 124);
            this.cbNoVowels.Name = "cbNoVowels";
            this.cbNoVowels.Size = new System.Drawing.Size(86, 17);
            this.cbNoVowels.TabIndex = 1;
            this.cbNoVowels.Text = "cbNoVowels";
            this.cbNoVowels.UseVisualStyleBackColor = true;
            this.cbNoVowels.CheckedChanged += new System.EventHandler(this.cbNoVowels_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 492);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbReverse;
        private System.Windows.Forms.TextBox tbNoVowels;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbNoVowels;
        private System.Windows.Forms.CheckBox cbReverse;
    }
}

