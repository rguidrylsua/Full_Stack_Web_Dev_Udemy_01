namespace Section15_Udemy
{
    partial class SelectionScreen
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
            this.btnEncapsulation = new System.Windows.Forms.Button();
            this.btnStaticUsing = new System.Windows.Forms.Button();
            this.btnInheritance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncapsulation
            // 
            this.btnEncapsulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncapsulation.Location = new System.Drawing.Point(12, 12);
            this.btnEncapsulation.Name = "btnEncapsulation";
            this.btnEncapsulation.Size = new System.Drawing.Size(138, 40);
            this.btnEncapsulation.TabIndex = 0;
            this.btnEncapsulation.Text = "Encapsulation";
            this.btnEncapsulation.UseVisualStyleBackColor = true;
            this.btnEncapsulation.Click += new System.EventHandler(this.btnEncapsulation_Click);
            // 
            // btnStaticUsing
            // 
            this.btnStaticUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaticUsing.Location = new System.Drawing.Point(156, 12);
            this.btnStaticUsing.Name = "btnStaticUsing";
            this.btnStaticUsing.Size = new System.Drawing.Size(138, 40);
            this.btnStaticUsing.TabIndex = 1;
            this.btnStaticUsing.Text = "Static Using";
            this.btnStaticUsing.UseVisualStyleBackColor = true;
            this.btnStaticUsing.Click += new System.EventHandler(this.btnStaticUsing_Click);
            // 
            // btnInheritance
            // 
            this.btnInheritance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInheritance.Location = new System.Drawing.Point(12, 58);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(138, 40);
            this.btnInheritance.TabIndex = 2;
            this.btnInheritance.Text = "Inheritance";
            this.btnInheritance.UseVisualStyleBackColor = true;
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 202);
            this.Controls.Add(this.btnInheritance);
            this.Controls.Add(this.btnStaticUsing);
            this.Controls.Add(this.btnEncapsulation);
            this.Name = "SelectionScreen";
            this.Text = "SelectIon Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncapsulation;
        private System.Windows.Forms.Button btnStaticUsing;
        private System.Windows.Forms.Button btnInheritance;
    }
}

