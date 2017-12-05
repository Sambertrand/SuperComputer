namespace SuperComputer
{
    partial class SuperComputer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Help = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Compute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 12);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(750, 495);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 513);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(750, 96);
            this.Input.TabIndex = 1;
            this.Input.Text = "";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(768, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(117, 47);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(768, 577);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 32);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(768, 513);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(117, 58);
            this.Compute.TabIndex = 4;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // SuperComputer
            // 
            this.AcceptButton = this.Compute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 621);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.KeyPreview = true;
            this.Name = "SuperComputer";
            this.Text = "Super Computer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Compute;
    }
}

