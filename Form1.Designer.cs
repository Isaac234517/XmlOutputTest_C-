namespace XmlOutputTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.xmlNodeBtn = new System.Windows.Forms.Button();
            this.xmlWriterBtn = new System.Windows.Forms.Button();
            this.xmlSerializerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xmlNodeBtn
            // 
            this.xmlNodeBtn.Location = new System.Drawing.Point(120, 127);
            this.xmlNodeBtn.Name = "xmlNodeBtn";
            this.xmlNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.xmlNodeBtn.TabIndex = 0;
            this.xmlNodeBtn.Text = "node";
            this.xmlNodeBtn.UseVisualStyleBackColor = true;
            this.xmlNodeBtn.Click += new System.EventHandler(this.xmlNodeBtn_Click);
            // 
            // xmlWriterBtn
            // 
            this.xmlWriterBtn.Location = new System.Drawing.Point(120, 175);
            this.xmlWriterBtn.Name = "xmlWriterBtn";
            this.xmlWriterBtn.Size = new System.Drawing.Size(75, 23);
            this.xmlWriterBtn.TabIndex = 1;
            this.xmlWriterBtn.Text = "writer";
            this.xmlWriterBtn.UseVisualStyleBackColor = true;
            this.xmlWriterBtn.Click += new System.EventHandler(this.xmlWriterBtn_Click);
            // 
            // xmlSerializerBtn
            // 
            this.xmlSerializerBtn.Location = new System.Drawing.Point(120, 227);
            this.xmlSerializerBtn.Name = "xmlSerializerBtn";
            this.xmlSerializerBtn.Size = new System.Drawing.Size(75, 23);
            this.xmlSerializerBtn.TabIndex = 2;
            this.xmlSerializerBtn.Text = "serializer";
            this.xmlSerializerBtn.UseVisualStyleBackColor = true;
            this.xmlSerializerBtn.Click += new System.EventHandler(this.xmlSerializerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 286);
            this.Controls.Add(this.xmlSerializerBtn);
            this.Controls.Add(this.xmlWriterBtn);
            this.Controls.Add(this.xmlNodeBtn);
            this.Name = "Form1";
            this.Text = "XmlForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xmlNodeBtn;
        private System.Windows.Forms.Button xmlWriterBtn;
        private System.Windows.Forms.Button xmlSerializerBtn;
    }
}

