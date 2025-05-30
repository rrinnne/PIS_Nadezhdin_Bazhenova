using System;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    partial class RuleForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownDocumentDuration = new NumericUpDown();
            checkedListBoxVisitPurpose = new CheckedListBox();
            checkedListBoxCitizenship = new CheckedListBox();
            checkBoxInsurance = new CheckBox();
            checkBoxINN = new CheckBox();
            checkBoxLongTerm = new CheckBox();
            checkBoxHighlyQualified = new CheckBox();
            checkBoxResettlementProgram = new CheckBox();
            checkBoxPreviouslyRegistered = new CheckBox();
            checkBoxFingerprinting = new CheckBox();
            checkBoxLanguageDocument = new CheckBox();
            checkBoxPatent = new CheckBox();
            labelDocumentDuration = new Label();
            labelVisitPurpose = new Label();
            labelCitizenship = new Label();
            buttonSubmit = new Button();
            labelRuleName = new Label();
            labelUserMessage = new Label();
            textBoxUserMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDocumentDuration).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownDocumentDuration
            // 
            numericUpDownDocumentDuration.Location = new Point(334, 89);
            numericUpDownDocumentDuration.Name = "numericUpDownDocumentDuration";
            numericUpDownDocumentDuration.Size = new Size(120, 27);
            numericUpDownDocumentDuration.TabIndex = 0;
            // 
            // checkedListBoxVisitPurpose
            // 
            checkedListBoxVisitPurpose.FormattingEnabled = true;
            checkedListBoxVisitPurpose.Items.AddRange(new object[] { "Работа", "Учеба", "Лечение", "Туризм", "Получение паттента" });
            checkedListBoxVisitPurpose.Location = new Point(300, 126);
            checkedListBoxVisitPurpose.Name = "checkedListBoxVisitPurpose";
            checkedListBoxVisitPurpose.Size = new Size(200, 70);
            checkedListBoxVisitPurpose.TabIndex = 1;
            checkedListBoxVisitPurpose.SelectedIndexChanged += checkedListBoxVisitPurpose_SelectedIndexChanged;
            // 
            // checkedListBoxCitizenship
            // 
            checkedListBoxCitizenship.FormattingEnabled = true;
            checkedListBoxCitizenship.Items.AddRange(new object[] { "Россия", "Беларусь", "Казахстан", "Узбекистан", "Украина", "Киргизия", "Армения", "Таджикистан", "Азербайджан", "Молдова" });
            checkedListBoxCitizenship.Location = new Point(300, 224);
            checkedListBoxCitizenship.Name = "checkedListBoxCitizenship";
            checkedListBoxCitizenship.Size = new Size(200, 70);
            checkedListBoxCitizenship.TabIndex = 2;
            // 
            // checkBoxInsurance
            // 
            checkBoxInsurance.AutoSize = true;
            checkBoxInsurance.Location = new Point(30, 320);
            checkBoxInsurance.Name = "checkBoxInsurance";
            checkBoxInsurance.Size = new Size(251, 24);
            checkBoxInsurance.TabIndex = 3;
            checkBoxInsurance.Text = "Наличие медицинского полиса";
            // 
            // checkBoxINN
            // 
            checkBoxINN.AutoSize = true;
            checkBoxINN.Location = new Point(30, 350);
            checkBoxINN.Name = "checkBoxINN";
            checkBoxINN.Size = new Size(129, 24);
            checkBoxINN.TabIndex = 4;
            checkBoxINN.Text = "Наличие ИНН";
            // 
            // checkBoxLongTerm
            // 
            checkBoxLongTerm.AutoSize = true;
            checkBoxLongTerm.Location = new Point(30, 380);
            checkBoxLongTerm.Name = "checkBoxLongTerm";
            checkBoxLongTerm.Size = new Size(153, 24);
            checkBoxLongTerm.TabIndex = 5;
            checkBoxLongTerm.Text = "Длительный срок";
            // 
            // checkBoxHighlyQualified
            // 
            checkBoxHighlyQualified.AutoSize = true;
            checkBoxHighlyQualified.Location = new Point(30, 410);
            checkBoxHighlyQualified.Name = "checkBoxHighlyQualified";
            checkBoxHighlyQualified.Size = new Size(430, 24);
            checkBoxHighlyQualified.TabIndex = 6;
            checkBoxHighlyQualified.Text = "Высококвалифицированный специалист или член семьи";
            // 
            // checkBoxResettlementProgram
            // 
            checkBoxResettlementProgram.AutoSize = true;
            checkBoxResettlementProgram.Location = new Point(30, 440);
            checkBoxResettlementProgram.Name = "checkBoxResettlementProgram";
            checkBoxResettlementProgram.Size = new Size(415, 24);
            checkBoxResettlementProgram.TabIndex = 7;
            checkBoxResettlementProgram.Text = "Участник программы переселения соотечественников";
            // 
            // checkBoxPreviouslyRegistered
            // 
            checkBoxPreviouslyRegistered.AutoSize = true;
            checkBoxPreviouslyRegistered.Location = new Point(30, 470);
            checkBoxPreviouslyRegistered.Name = "checkBoxPreviouslyRegistered";
            checkBoxPreviouslyRegistered.Size = new Size(304, 24);
            checkBoxPreviouslyRegistered.TabIndex = 8;
            checkBoxPreviouslyRegistered.Text = "Ранее состоял на миграционном учете";
            // 
            // checkBoxFingerprinting
            // 
            checkBoxFingerprinting.AutoSize = true;
            checkBoxFingerprinting.Location = new Point(30, 500);
            checkBoxFingerprinting.Name = "checkBoxFingerprinting";
            checkBoxFingerprinting.Size = new Size(422, 24);
            checkBoxFingerprinting.TabIndex = 9;
            checkBoxFingerprinting.Text = "Проводились дактилоскопия и фотографирование в РФ";
            // 
            // checkBoxLanguageDocument
            // 
            checkBoxLanguageDocument.AutoSize = true;
            checkBoxLanguageDocument.Location = new Point(30, 530);
            checkBoxLanguageDocument.Name = "checkBoxLanguageDocument";
            checkBoxLanguageDocument.Size = new Size(622, 24);
            checkBoxLanguageDocument.TabIndex = 10;
            checkBoxLanguageDocument.Text = "Наличие документа о знании русского языка, истории и основ законодательства РФ";
            // 
            // checkBoxPatent
            // 
            checkBoxPatent.AutoSize = true;
            checkBoxPatent.Location = new Point(30, 560);
            checkBoxPatent.Name = "checkBoxPatent";
            checkBoxPatent.Size = new Size(150, 24);
            checkBoxPatent.TabIndex = 11;
            checkBoxPatent.Text = "Наличие патента";
            checkBoxPatent.CheckedChanged += checkBoxPatent_CheckedChanged;
            // 
            // labelDocumentDuration
            // 
            labelDocumentDuration.AutoSize = true;
            labelDocumentDuration.Location = new Point(30, 91);
            labelDocumentDuration.Name = "labelDocumentDuration";
            labelDocumentDuration.Size = new Size(270, 20);
            labelDocumentDuration.TabIndex = 12;
            labelDocumentDuration.Text = "Срок для получения документа (дни):";
            // 
            // labelVisitPurpose
            // 
            labelVisitPurpose.AutoSize = true;
            labelVisitPurpose.Location = new Point(30, 124);
            labelVisitPurpose.Name = "labelVisitPurpose";
            labelVisitPurpose.Size = new Size(98, 20);
            labelVisitPurpose.TabIndex = 13;
            labelVisitPurpose.Text = "Цель визита:";
            // 
            // labelCitizenship
            // 
            labelCitizenship.AutoSize = true;
            labelCitizenship.Location = new Point(30, 224);
            labelCitizenship.Name = "labelCitizenship";
            labelCitizenship.Size = new Size(102, 20);
            labelCitizenship.TabIndex = 14;
            labelCitizenship.Text = "Гражданство:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(194, 628);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(206, 30);
            buttonSubmit.TabIndex = 16;
            buttonSubmit.Text = "Добавить набор условий";
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelRuleName
            // 
            labelRuleName.Location = new Point(0, 0);
            labelRuleName.Name = "labelRuleName";
            labelRuleName.Size = new Size(100, 23);
            labelRuleName.TabIndex = 21;
            // 
            // labelUserMessage
            // 
            labelUserMessage.AutoSize = true;
            labelUserMessage.Location = new Point(30, 15);
            labelUserMessage.Name = "labelUserMessage";
            labelUserMessage.Size = new Size(370, 20);
            labelUserMessage.TabIndex = 19;
            labelUserMessage.Text = "Что необходимо сделать для получения документа:";
            // 
            // textBoxUserMessage
            // 
            textBoxUserMessage.Location = new Point(30, 38);
            textBoxUserMessage.Name = "textBoxUserMessage";
            textBoxUserMessage.Size = new Size(470, 27);
            textBoxUserMessage.TabIndex = 0;
            // 
            // RuleForm
            // 
            ClientSize = new Size(653, 685);
            Controls.Add(textBoxUserMessage);
            Controls.Add(labelUserMessage);
            Controls.Add(labelRuleName);
            Controls.Add(buttonSubmit);
            Controls.Add(labelCitizenship);
            Controls.Add(labelVisitPurpose);
            Controls.Add(labelDocumentDuration);
            Controls.Add(checkBoxPatent);
            Controls.Add(checkBoxLanguageDocument);
            Controls.Add(checkBoxFingerprinting);
            Controls.Add(checkBoxPreviouslyRegistered);
            Controls.Add(checkBoxResettlementProgram);
            Controls.Add(checkBoxHighlyQualified);
            Controls.Add(checkBoxLongTerm);
            Controls.Add(checkBoxINN);
            Controls.Add(checkBoxInsurance);
            Controls.Add(checkedListBoxCitizenship);
            Controls.Add(checkedListBoxVisitPurpose);
            Controls.Add(numericUpDownDocumentDuration);
            Name = "RuleForm";
            Text = "Форма оператора";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDocumentDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private NumericUpDown numericUpDownDocumentDuration;
        private CheckedListBox checkedListBoxVisitPurpose;
        private CheckedListBox checkedListBoxCitizenship;
        private CheckBox checkBoxInsurance;
        private CheckBox checkBoxINN;
        private CheckBox checkBoxLongTerm;
        private CheckBox checkBoxHighlyQualified;
        private CheckBox checkBoxResettlementProgram;
        private CheckBox checkBoxPreviouslyRegistered;
        private CheckBox checkBoxFingerprinting;
        private CheckBox checkBoxLanguageDocument;
        private CheckBox checkBoxPatent;
        private Label labelDocumentDuration;
        private Label labelVisitPurpose;
        private Label labelCitizenship;
        private Button buttonSubmit;
        private Label labelRuleName;
        private Label labelUserMessage;
        private TextBox textBoxUserMessage;
    }
}