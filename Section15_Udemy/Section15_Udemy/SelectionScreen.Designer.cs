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
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnPolymorphism = new System.Windows.Forms.Button();
            this.btnAbstract = new System.Windows.Forms.Button();
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
            // btnInterface
            // 
            this.btnInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterface.Location = new System.Drawing.Point(156, 58);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(138, 40);
            this.btnInterface.TabIndex = 3;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnPolymorphism
            // 
            this.btnPolymorphism.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolymorphism.Location = new System.Drawing.Point(12, 104);
            this.btnPolymorphism.Name = "btnPolymorphism";
            this.btnPolymorphism.Size = new System.Drawing.Size(138, 40);
            this.btnPolymorphism.TabIndex = 4;
            this.btnPolymorphism.Text = "Polymorphism";
            this.btnPolymorphism.UseVisualStyleBackColor = true;
            this.btnPolymorphism.Click += new System.EventHandler(this.btnPolymorphism_Click);
            // 
            // btnAbstract
            // 
            this.btnAbstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbstract.Location = new System.Drawing.Point(156, 104);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(138, 40);
            this.btnAbstract.TabIndex = 5;
            this.btnAbstract.Text = "Abstract";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 202);
            this.Controls.Add(this.btnAbstract);
            this.Controls.Add(this.btnPolymorphism);
            this.Controls.Add(this.btnInterface);
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
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnPolymorphism;
        private System.Windows.Forms.Button btnAbstract;
    }
}

