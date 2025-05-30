namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private DateTimePicker dateTimePickerEntryDate;
        private ComboBox comboBoxVisitPurpose;
        private ComboBox comboBoxCitizenship;
        private CheckBox checkBoxInsurance;
        private CheckBox checkBoxINN;
        private CheckBox checkBoxStayDuration;
        private CheckBox checkBoxHighlyQualified;
        private CheckBox checkBoxResettlementProgram;
        private CheckBox checkBoxPreviouslyRegistered;
        private CheckBox checkBoxFingerprinting;
        private CheckBox checkBoxLanguageDocument;
        private CheckBox checkBoxPatent;
        private DateTimePicker dateTimePickerPatentDate;
        private Button buttonSubmit;
        private Button buttonViewMap;
        private Label labelEntryDate;
        private Label labelVisitPurpose;
        private Label labelCitizenship;
        private Label labelInsurance;
        private Label labelINN;
        private Label labelStayDuration;
        private Label labelHighlyQualified;
        private Label labelResettlementProgram;
        private Label labelPreviouslyRegistered;
        private Label labelFingerprinting;
        private Label labelLanguageDocument;
        private Label labelPatent;
        private Label labelPatentDate;

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
            dateTimePickerEntryDate = new DateTimePicker();
            comboBoxVisitPurpose = new ComboBox();
            comboBoxCitizenship = new ComboBox();
            checkBoxInsurance = new CheckBox();
            checkBoxINN = new CheckBox();
            checkBoxStayDuration = new CheckBox();
            checkBoxHighlyQualified = new CheckBox();
            checkBoxResettlementProgram = new CheckBox();
            checkBoxPreviouslyRegistered = new CheckBox();
            checkBoxFingerprinting = new CheckBox();
            checkBoxLanguageDocument = new CheckBox();
            checkBoxPatent = new CheckBox();
            dateTimePickerPatentDate = new DateTimePicker();
            buttonSubmit = new Button();
            labelEntryDate = new Label();
            labelVisitPurpose = new Label();
            labelCitizenship = new Label();
            labelInsurance = new Label();
            labelINN = new Label();
            labelStayDuration = new Label();
            labelHighlyQualified = new Label();
            labelResettlementProgram = new Label();
            labelPreviouslyRegistered = new Label();
            labelFingerprinting = new Label();
            labelLanguageDocument = new Label();
            labelPatent = new Label();
            labelPatentDate = new Label();
            buttonViewMap = new Button();
            SuspendLayout();
            // 
            // dateTimePickerEntryDate
            // 
            dateTimePickerEntryDate.Location = new Point(167, 30);
            dateTimePickerEntryDate.Name = "dateTimePickerEntryDate";
            dateTimePickerEntryDate.Size = new Size(200, 27);
            dateTimePickerEntryDate.TabIndex = 0;
            dateTimePickerEntryDate.ValueChanged += dateTimePickerEntryDate_ValueChanged;
            // 
            // comboBoxVisitPurpose
            // 
            comboBoxVisitPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVisitPurpose.Items.AddRange(new object[] { "Работа", "Учеба", "Лечение", "Туризм", "Получение патента" });
            comboBoxVisitPurpose.Location = new Point(167, 70);
            comboBoxVisitPurpose.Name = "comboBoxVisitPurpose";
            comboBoxVisitPurpose.Size = new Size(200, 28);
            comboBoxVisitPurpose.TabIndex = 1;
            // 
            // comboBoxCitizenship
            // 
            comboBoxCitizenship.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCitizenship.Items.AddRange(new object[] { "Россия", "Беларусь", "Казахстан", "Узбекистан", "Украина", "Киргизия", "Армения", "Таджикистан", "Азербайджан", "Молдова" });
            comboBoxCitizenship.Location = new Point(167, 110);
            comboBoxCitizenship.Name = "comboBoxCitizenship";
            comboBoxCitizenship.Size = new Size(200, 28);
            comboBoxCitizenship.TabIndex = 2;
            // 
            // checkBoxInsurance
            // 
            checkBoxInsurance.AutoSize = true;
            checkBoxInsurance.Location = new Point(275, 154);
            checkBoxInsurance.Name = "checkBoxInsurance";
            checkBoxInsurance.Size = new Size(18, 17);
            checkBoxInsurance.TabIndex = 3;
            // 
            // checkBoxINN
            // 
            checkBoxINN.AutoSize = true;
            checkBoxINN.Location = new Point(146, 187);
            checkBoxINN.Name = "checkBoxINN";
            checkBoxINN.Size = new Size(18, 17);
            checkBoxINN.TabIndex = 4;
            // 
            // checkBoxStayDuration
            // 
            checkBoxStayDuration.AutoSize = true;
            checkBoxStayDuration.Location = new Point(223, 223);
            checkBoxStayDuration.Name = "checkBoxStayDuration";
            checkBoxStayDuration.Size = new Size(18, 17);
            checkBoxStayDuration.TabIndex = 4;
            // 
            // checkBoxHighlyQualified
            // 
            checkBoxHighlyQualified.AutoSize = true;
            checkBoxHighlyQualified.Location = new Point(461, 257);
            checkBoxHighlyQualified.Name = "checkBoxHighlyQualified";
            checkBoxHighlyQualified.Size = new Size(18, 17);
            checkBoxHighlyQualified.TabIndex = 6;
            // 
            // checkBoxResettlementProgram
            // 
            checkBoxResettlementProgram.AutoSize = true;
            checkBoxResettlementProgram.Location = new Point(579, 295);
            checkBoxResettlementProgram.Name = "checkBoxResettlementProgram";
            checkBoxResettlementProgram.Size = new Size(18, 17);
            checkBoxResettlementProgram.TabIndex = 7;
            // 
            // checkBoxPreviouslyRegistered
            // 
            checkBoxPreviouslyRegistered.AutoSize = true;
            checkBoxPreviouslyRegistered.Location = new Point(326, 327);
            checkBoxPreviouslyRegistered.Name = "checkBoxPreviouslyRegistered";
            checkBoxPreviouslyRegistered.Size = new Size(18, 17);
            checkBoxPreviouslyRegistered.TabIndex = 8;
            // 
            // checkBoxFingerprinting
            // 
            checkBoxFingerprinting.AutoSize = true;
            checkBoxFingerprinting.Location = new Point(542, 362);
            checkBoxFingerprinting.Name = "checkBoxFingerprinting";
            checkBoxFingerprinting.Size = new Size(18, 17);
            checkBoxFingerprinting.TabIndex = 9;
            // 
            // checkBoxLanguageDocument
            // 
            checkBoxLanguageDocument.AutoSize = true;
            checkBoxLanguageDocument.Location = new Point(369, 415);
            checkBoxLanguageDocument.Name = "checkBoxLanguageDocument";
            checkBoxLanguageDocument.Size = new Size(18, 17);
            checkBoxLanguageDocument.TabIndex = 10;
            // 
            // checkBoxPatent
            // 
            checkBoxPatent.AutoSize = true;
            checkBoxPatent.Location = new Point(170, 442);
            checkBoxPatent.Name = "checkBoxPatent";
            checkBoxPatent.Size = new Size(18, 17);
            checkBoxPatent.TabIndex = 11;
            // 
            // dateTimePickerPatentDate
            // 
            dateTimePickerPatentDate.Enabled = false;
            dateTimePickerPatentDate.Location = new Point(317, 467);
            dateTimePickerPatentDate.Name = "dateTimePickerPatentDate";
            dateTimePickerPatentDate.Size = new Size(200, 27);
            dateTimePickerPatentDate.TabIndex = 12;
            dateTimePickerPatentDate.ValueChanged += dateTimePickerPatentDate_ValueChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(217, 515);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(170, 30);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Сохранить";
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelEntryDate
            // 
            labelEntryDate.AutoSize = true;
            labelEntryDate.Location = new Point(30, 30);
            labelEntryDate.Name = "labelEntryDate";
            labelEntryDate.Size = new Size(96, 20);
            labelEntryDate.TabIndex = 14;
            labelEntryDate.Text = "Дата въезда:";
            // 
            // labelVisitPurpose
            // 
            labelVisitPurpose.AutoSize = true;
            labelVisitPurpose.Location = new Point(30, 70);
            labelVisitPurpose.Name = "labelVisitPurpose";
            labelVisitPurpose.Size = new Size(98, 20);
            labelVisitPurpose.TabIndex = 15;
            labelVisitPurpose.Text = "Цель визита:";
            // 
            // labelCitizenship
            // 
            labelCitizenship.AutoSize = true;
            labelCitizenship.Location = new Point(30, 110);
            labelCitizenship.Name = "labelCitizenship";
            labelCitizenship.Size = new Size(102, 20);
            labelCitizenship.TabIndex = 16;
            labelCitizenship.Text = "Гражданство:";
            // 
            // labelInsurance
            // 
            labelInsurance.AutoSize = true;
            labelInsurance.Location = new Point(30, 151);
            labelInsurance.Name = "labelInsurance";
            labelInsurance.Size = new Size(232, 20);
            labelInsurance.TabIndex = 17;
            labelInsurance.Text = "Наличие медицинского полиса:";
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.Location = new Point(30, 184);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(110, 20);
            labelINN.TabIndex = 18;
            labelINN.Text = "Наличие ИНН:";
            // 
            // labelStayDuration
            // 
            labelStayDuration.AutoSize = true;
            labelStayDuration.Location = new Point(30, 220);
            labelStayDuration.Name = "labelStayDuration";
            labelStayDuration.Size = new Size(187, 20);
            labelStayDuration.TabIndex = 19;
            labelStayDuration.Text = "Длительное пребывание:";
            // 
            // labelHighlyQualified
            // 
            labelHighlyQualified.AutoSize = true;
            labelHighlyQualified.Location = new Point(30, 254);
            labelHighlyQualified.Name = "labelHighlyQualified";
            labelHighlyQualified.Size = new Size(411, 20);
            labelHighlyQualified.TabIndex = 20;
            labelHighlyQualified.Text = "Высококвалифицированный специалист или член семьи:";
            // 
            // labelResettlementProgram
            // 
            labelResettlementProgram.AutoSize = true;
            labelResettlementProgram.Location = new Point(30, 292);
            labelResettlementProgram.Name = "labelResettlementProgram";
            labelResettlementProgram.Size = new Size(530, 20);
            labelResettlementProgram.TabIndex = 21;
            labelResettlementProgram.Text = "Участник программы переселения соотечественников и членов их семей:";
            // 
            // labelPreviouslyRegistered
            // 
            labelPreviouslyRegistered.AutoSize = true;
            labelPreviouslyRegistered.Location = new Point(30, 324);
            labelPreviouslyRegistered.Name = "labelPreviouslyRegistered";
            labelPreviouslyRegistered.Size = new Size(285, 20);
            labelPreviouslyRegistered.TabIndex = 22;
            labelPreviouslyRegistered.Text = "Ранее состоял на миграционном учете:";
            // 
            // labelFingerprinting
            // 
            labelFingerprinting.AutoSize = true;
            labelFingerprinting.Location = new Point(30, 359);
            labelFingerprinting.Name = "labelFingerprinting";
            labelFingerprinting.Size = new Size(498, 20);
            labelFingerprinting.TabIndex = 23;
            labelFingerprinting.Text = "Проводились дактилоскопическая регистрация и фотографирование:";
            // 
            // labelLanguageDocument
            // 
            labelLanguageDocument.AutoSize = true;
            labelLanguageDocument.Location = new Point(30, 392);
            labelLanguageDocument.Name = "labelLanguageDocument";
            labelLanguageDocument.Size = new Size(333, 40);
            labelLanguageDocument.TabIndex = 24;
            labelLanguageDocument.Text = "Наличие документа о знании русского языка, \nистории России и основ законодательства РФ:";
            // 
            // labelPatent
            // 
            labelPatent.AutoSize = true;
            labelPatent.Location = new Point(33, 439);
            labelPatent.Name = "labelPatent";
            labelPatent.Size = new Size(131, 20);
            labelPatent.TabIndex = 25;
            labelPatent.Text = "Наличие патента:";
            // 
            // labelPatentDate
            // 
            labelPatentDate.AutoSize = true;
            labelPatentDate.Location = new Point(30, 472);
            labelPatentDate.Name = "labelPatentDate";
            labelPatentDate.Size = new Size(263, 20);
            labelPatentDate.TabIndex = 26;
            labelPatentDate.Text = "Дата выдачи патента (при наличии):";
            // 
            // buttonViewMap
            // 
            buttonViewMap.Location = new Point(217, 551);
            buttonViewMap.Name = "buttonViewMap";
            buttonViewMap.Size = new Size(170, 59);
            buttonViewMap.TabIndex = 14;
            buttonViewMap.Text = "Посмотреть дорожную карту";
            buttonViewMap.Click += buttonViewMap_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(630, 671);
            Controls.Add(labelPatentDate);
            Controls.Add(labelPatent);
            Controls.Add(labelLanguageDocument);
            Controls.Add(labelFingerprinting);
            Controls.Add(labelPreviouslyRegistered);
            Controls.Add(labelResettlementProgram);
            Controls.Add(labelHighlyQualified);
            Controls.Add(labelStayDuration);
            Controls.Add(labelINN);
            Controls.Add(labelInsurance);
            Controls.Add(labelCitizenship);
            Controls.Add(labelVisitPurpose);
            Controls.Add(labelEntryDate);
            Controls.Add(buttonViewMap);
            Controls.Add(buttonSubmit);
            Controls.Add(dateTimePickerPatentDate);
            Controls.Add(checkBoxPatent);
            Controls.Add(checkBoxLanguageDocument);
            Controls.Add(checkBoxFingerprinting);
            Controls.Add(checkBoxPreviouslyRegistered);
            Controls.Add(checkBoxResettlementProgram);
            Controls.Add(checkBoxHighlyQualified);
            Controls.Add(checkBoxStayDuration);
            Controls.Add(checkBoxINN);
            Controls.Add(checkBoxInsurance);
            Controls.Add(comboBoxCitizenship);
            Controls.Add(comboBoxVisitPurpose);
            Controls.Add(dateTimePickerEntryDate);
            Name = "Form1";
            Text = "Форма мигранта";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}