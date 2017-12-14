namespace SuperCalculator
{
    partial class Helpform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helpform));
            this.Close = new System.Windows.Forms.Button();
            this.ComboFunctions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Location = new System.Drawing.Point(216, 494);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(82, 21);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ComboFunctions
            // 
            this.ComboFunctions.FormattingEnabled = true;
            this.ComboFunctions.Location = new System.Drawing.Point(12, 31);
            this.ComboFunctions.Name = "ComboFunctions";
            this.ComboFunctions.Size = new System.Drawing.Size(196, 21);
            this.ComboFunctions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the function you want help for :";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Output.Location = new System.Drawing.Point(12, 58);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(286, 430);
            this.Output.TabIndex = 3;
            this.Output.Text = "";
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(214, 30);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(82, 21);
            this.Select.TabIndex = 4;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(310, 527);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboFunctions);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Helpform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Helpform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        new private System.Windows.Forms.Button Close;

        
        private System.Windows.Forms.ComboBox ComboFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Output;
        new private System.Windows.Forms.Button Select;

    }
}