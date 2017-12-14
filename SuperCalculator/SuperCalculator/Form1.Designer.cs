namespace SuperCalculator
{
    partial class SuperCalculator3000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperCalculator3000));
            this.Compute = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Compute
            // 
            this.Compute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Compute.Location = new System.Drawing.Point(648, 553);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(124, 55);
            this.Compute.TabIndex = 0;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Load
            // 
            this.Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load.Location = new System.Drawing.Point(648, 72);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(124, 35);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load Function";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(648, 614);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 35);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Help
            // 
            this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Help.Location = new System.Drawing.Point(648, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(124, 54);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click_1);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(648, 512);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 35);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Output.Location = new System.Drawing.Point(12, 12);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(630, 535);
            this.Output.TabIndex = 5;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Ouput_TextChanged);
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(12, 553);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(630, 96);
            this.Input.TabIndex = 4;
            this.Input.Text = "";
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged_1);
            // 
            // SuperCalculator3000
            // 
            this.AcceptButton = this.Compute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Compute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(466, 296);
            this.Name = "SuperCalculator3000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperCalculator3000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Compute;
        new private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
    }
}

