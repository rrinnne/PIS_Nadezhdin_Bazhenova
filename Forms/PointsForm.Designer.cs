using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class PointsForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxPoints;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelList;
        private Label labelMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button GetButton1()
        {
            return button1;
        }

        private void InitializeComponent()
        {
            listBoxPoints = new ListBox();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelList = new Label();
            labelMessage = new Label();
            button1 = new Button();
            textBoxMessage = new TextBox();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBoxPoints
            // 
            listBoxPoints.FormattingEnabled = true;
            listBoxPoints.Location = new Point(20, 50);
            listBoxPoints.Name = "listBoxPoints";
            listBoxPoints.Size = new Size(186, 184);
            listBoxPoints.TabIndex = 0;
            listBoxPoints.SelectedIndexChanged += listBoxPoints_SelectedIndexChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(56, 250);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(127, 58);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Добавить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(382, 250);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 58);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Location = new Point(20, 20);
            labelList.Name = "labelList";
            labelList.Size = new Size(121, 20);
            labelList.TabIndex = 4;
            labelList.Text = "Список пунктов:";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(235, 142);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(144, 20);
            labelMessage.TabIndex = 5;
            labelMessage.Text = "Заголовок правила:";
            labelMessage.Click += labelMessage_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 250);
            button1.Name = "button1";
            button1.Size = new Size(133, 58);
            button1.TabIndex = 6;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(235, 165);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(315, 69);
            textBoxMessage.TabIndex = 1;
            textBoxMessage.TextChanged += textBoxMessage_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(170, 325);
            button2.Name = "button2";
            button2.Size = new Size(229, 35);
            button2.TabIndex = 9;
            button2.Text = "Сохранить изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 20);
            label1.Name = "label1";
            label1.Size = new Size(295, 20);
            label1.TabIndex = 8;
            label1.Text = "Документ, который необходимо сделать:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 78);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PointsForm
            // 
            ClientSize = new Size(576, 372);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(labelMessage);
            Controls.Add(labelList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxMessage);
            Controls.Add(listBoxPoints);
            Name = "PointsForm";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private TextBox textBoxMessage;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
    }
}
