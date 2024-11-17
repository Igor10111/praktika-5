namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bClick
            // 
            this.bClick.Image = ((System.Drawing.Image)(resources.GetObject("bClick.Image")));
            this.bClick.Location = new System.Drawing.Point(234, 186);
            this.bClick.Name = "bClick";
            this.bClick.Size = new System.Drawing.Size(302, 88);
            this.bClick.TabIndex = 0;
            this.bClick.UseVisualStyleBackColor = true;
            this.bClick.Click += new System.EventHandler(this.button1_Click);
            this.bClick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            this.bClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClick;
    }
}

