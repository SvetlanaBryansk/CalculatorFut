namespace FirstWindowsWormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloWorldButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloWorldButton
            // 
            this.HelloWorldButton.Location = new System.Drawing.Point(278, 102);
            this.HelloWorldButton.Name = "HelloWorldButton";
            this.HelloWorldButton.Size = new System.Drawing.Size(200, 200);
            this.HelloWorldButton.TabIndex = 0;
            this.HelloWorldButton.Text = "Say Hello World";
            this.HelloWorldButton.UseVisualStyleBackColor = true;
            this.HelloWorldButton.Click += new System.EventHandler(this.HelloWorldButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloWorldButton);
            this.Name = "Form1";
            this.Text = "Hello World App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloWorldButton;
    }
}

