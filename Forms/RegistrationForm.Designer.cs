namespace WinFormsApp1
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

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
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            buttonAuth = new Button();
            labelInfo = new Label();
            SuspendLayout();
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(159, 77);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(252, 27);
            textBoxPhone.TabIndex = 1;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(23, 77);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(130, 20);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Номер телефона:";
            // 
            // buttonAuth
            // 
            buttonAuth.Location = new Point(90, 128);
            buttonAuth.Margin = new Padding(3, 4, 3, 4);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(231, 40);
            buttonAuth.TabIndex = 3;
            buttonAuth.Text = "Войти / Зарегистрироваться";
            buttonAuth.UseVisualStyleBackColor = true;
            buttonAuth.Click += buttonAuth_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(23, 28);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(388, 20);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "Введите Ваш номер телефона для входа/регистрации:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 196);
            Controls.Add(labelInfo);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(buttonAuth);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "Аутентификация пользователя";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Label labelInfo;
        private TextBox textBox1;
        private Label label1;
    }
}
