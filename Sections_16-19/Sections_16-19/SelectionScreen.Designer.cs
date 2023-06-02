namespace Sections_16_19
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
            this.btnEnumUsing = new System.Windows.Forms.Button();
            this.btnDelegateUsing = new System.Windows.Forms.Button();
            this.btnExceptionHandling = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFileAndFileInfo = new System.Windows.Forms.Button();
            this.btnPathClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnumUsing
            // 
            this.btnEnumUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumUsing.Location = new System.Drawing.Point(12, 12);
            this.btnEnumUsing.Name = "btnEnumUsing";
            this.btnEnumUsing.Size = new System.Drawing.Size(116, 47);
            this.btnEnumUsing.TabIndex = 0;
            this.btnEnumUsing.Text = "Enum Using";
            this.btnEnumUsing.UseVisualStyleBackColor = true;
            this.btnEnumUsing.Click += new System.EventHandler(this.btnEnumUsing_Click);
            // 
            // btnDelegateUsing
            // 
            this.btnDelegateUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelegateUsing.Location = new System.Drawing.Point(134, 12);
            this.btnDelegateUsing.Name = "btnDelegateUsing";
            this.btnDelegateUsing.Size = new System.Drawing.Size(144, 47);
            this.btnDelegateUsing.TabIndex = 1;
            this.btnDelegateUsing.Text = "Delegate Using";
            this.btnDelegateUsing.UseVisualStyleBackColor = true;
            this.btnDelegateUsing.Click += new System.EventHandler(this.btnDelegateUsing_Click);
            // 
            // btnExceptionHandling
            // 
            this.btnExceptionHandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExceptionHandling.Location = new System.Drawing.Point(12, 65);
            this.btnExceptionHandling.Name = "btnExceptionHandling";
            this.btnExceptionHandling.Size = new System.Drawing.Size(266, 47);
            this.btnExceptionHandling.TabIndex = 2;
            this.btnExceptionHandling.Text = "Exception Handling";
            this.btnExceptionHandling.UseVisualStyleBackColor = true;
            this.btnExceptionHandling.Click += new System.EventHandler(this.btnExceptionHandling_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Directory and DirectoryInfo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileAndFileInfo
            // 
            this.btnFileAndFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileAndFileInfo.Location = new System.Drawing.Point(12, 171);
            this.btnFileAndFileInfo.Name = "btnFileAndFileInfo";
            this.btnFileAndFileInfo.Size = new System.Drawing.Size(266, 47);
            this.btnFileAndFileInfo.TabIndex = 4;
            this.btnFileAndFileInfo.Text = "File and FileInfo";
            this.btnFileAndFileInfo.UseVisualStyleBackColor = true;
            this.btnFileAndFileInfo.Click += new System.EventHandler(this.btnFileAndFileInfo_Click);
            // 
            // btnPathClass
            // 
            this.btnPathClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathClass.Location = new System.Drawing.Point(12, 224);
            this.btnPathClass.Name = "btnPathClass";
            this.btnPathClass.Size = new System.Drawing.Size(266, 47);
            this.btnPathClass.TabIndex = 5;
            this.btnPathClass.Text = "Path Class";
            this.btnPathClass.UseVisualStyleBackColor = true;
            this.btnPathClass.Click += new System.EventHandler(this.btnPathClass_Click);
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 296);
            this.Controls.Add(this.btnPathClass);
            this.Controls.Add(this.btnFileAndFileInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExceptionHandling);
            this.Controls.Add(this.btnDelegateUsing);
            this.Controls.Add(this.btnEnumUsing);
            this.Name = "SelectionScreen";
            this.Text = "SelectionScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnumUsing;
        private System.Windows.Forms.Button btnDelegateUsing;
        private System.Windows.Forms.Button btnExceptionHandling;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFileAndFileInfo;
        private System.Windows.Forms.Button btnPathClass;
    }
}

