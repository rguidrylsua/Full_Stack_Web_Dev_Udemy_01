namespace Learning_Classes
{
    partial class SelectScreen
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
            this.btnClassObject = new System.Windows.Forms.Button();
            this.btnUsingListClass = new System.Windows.Forms.Button();
            this.btnUsingRandomClass = new System.Windows.Forms.Button();
            this.btnUsingTimerClass = new System.Windows.Forms.Button();
            this.btnUsingMathClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassObject
            // 
            this.btnClassObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassObject.Location = new System.Drawing.Point(12, 12);
            this.btnClassObject.Name = "btnClassObject";
            this.btnClassObject.Size = new System.Drawing.Size(126, 57);
            this.btnClassObject.TabIndex = 0;
            this.btnClassObject.Text = "Classes and Objects";
            this.btnClassObject.UseVisualStyleBackColor = true;
            this.btnClassObject.Click += new System.EventHandler(this.btnClassObject_Click);
            // 
            // btnUsingListClass
            // 
            this.btnUsingListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingListClass.Location = new System.Drawing.Point(144, 12);
            this.btnUsingListClass.Name = "btnUsingListClass";
            this.btnUsingListClass.Size = new System.Drawing.Size(126, 57);
            this.btnUsingListClass.TabIndex = 1;
            this.btnUsingListClass.Text = "Using List Class";
            this.btnUsingListClass.UseVisualStyleBackColor = true;
            this.btnUsingListClass.Click += new System.EventHandler(this.btnUsingListClass_Click);
            // 
            // btnUsingRandomClass
            // 
            this.btnUsingRandomClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingRandomClass.Location = new System.Drawing.Point(276, 12);
            this.btnUsingRandomClass.Name = "btnUsingRandomClass";
            this.btnUsingRandomClass.Size = new System.Drawing.Size(126, 57);
            this.btnUsingRandomClass.TabIndex = 2;
            this.btnUsingRandomClass.Text = "Using Random Class";
            this.btnUsingRandomClass.UseVisualStyleBackColor = true;
            this.btnUsingRandomClass.Click += new System.EventHandler(this.btnUsingRandomClass_Click);
            // 
            // btnUsingTimerClass
            // 
            this.btnUsingTimerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingTimerClass.Location = new System.Drawing.Point(12, 75);
            this.btnUsingTimerClass.Name = "btnUsingTimerClass";
            this.btnUsingTimerClass.Size = new System.Drawing.Size(126, 57);
            this.btnUsingTimerClass.TabIndex = 3;
            this.btnUsingTimerClass.Text = "Using Timer Class";
            this.btnUsingTimerClass.UseVisualStyleBackColor = true;
            this.btnUsingTimerClass.Click += new System.EventHandler(this.btnUsingTimerClass_Click);
            // 
            // btnUsingMathClass
            // 
            this.btnUsingMathClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingMathClass.Location = new System.Drawing.Point(144, 75);
            this.btnUsingMathClass.Name = "btnUsingMathClass";
            this.btnUsingMathClass.Size = new System.Drawing.Size(126, 57);
            this.btnUsingMathClass.TabIndex = 4;
            this.btnUsingMathClass.Text = "Using Math Class";
            this.btnUsingMathClass.UseVisualStyleBackColor = true;
            this.btnUsingMathClass.Click += new System.EventHandler(this.btnUsingMathClass_Click);
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 311);
            this.Controls.Add(this.btnUsingMathClass);
            this.Controls.Add(this.btnUsingTimerClass);
            this.Controls.Add(this.btnUsingRandomClass);
            this.Controls.Add(this.btnUsingListClass);
            this.Controls.Add(this.btnClassObject);
            this.Name = "SelectScreen";
            this.Text = "Select Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassObject;
        private System.Windows.Forms.Button btnUsingListClass;
        private System.Windows.Forms.Button btnUsingRandomClass;
        private System.Windows.Forms.Button btnUsingTimerClass;
        private System.Windows.Forms.Button btnUsingMathClass;
    }
}