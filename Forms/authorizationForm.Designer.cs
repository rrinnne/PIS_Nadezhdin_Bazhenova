namespace WinFormsApp1
{
    partial class authorizationForm
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


        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 184);
            button1.Name = "button1";
            button1.Size = new Size(182, 56);
            button1.TabIndex = 0;
            button1.Text = "Мигрант";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 264);
            button2.Name = "button2";
            button2.Size = new Size(182, 56);
            button2.TabIndex = 1;
            button2.Text = "Оператор";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(75, 124);
            label1.Name = "label1";
            label1.Size = new Size(245, 21);
            label1.TabIndex = 2;
            label1.Text = "Выберите роль пользователя";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 397);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "authorizationForm";
            Text = "authorizationForm";
            Load += authorizationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Label label1;

    }
}