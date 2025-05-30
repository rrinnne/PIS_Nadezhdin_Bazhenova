using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly User _currentUser;
        public List<MapPoint> Points;
        private readonly RegistrationForm _registrationForm;

        public Form1(User user, RegistrationForm registrationForm)
        {
            InitializeComponent();
            _currentUser = user;
            _registrationForm = registrationForm;
            this.FormClosed += (s, e) => _registrationForm.Show();

            InitializeForm();
            LoadUserData();
        }

        private void InitializeForm()
        {
            dateTimePickerPatentDate.Enabled = checkBoxPatent.Checked;
            checkBoxPatent.CheckedChanged += checkBoxPatent_CheckedChanged;
        }

        private void LoadUserData()
        {
            dateTimePickerEntryDate.Value = _currentUser.DateOfEntry;
            comboBoxVisitPurpose.Text = _currentUser.VisitPurpose;
            comboBoxCitizenship.Text = _currentUser.Citizenship;
            checkBoxInsurance.Checked = _currentUser.HasPolicy;
            checkBoxINN.Checked = _currentUser.HasInn;
            checkBoxStayDuration.Checked = _currentUser.IsLongStay;
            checkBoxHighlyQualified.Checked = _currentUser.HighQualify;
            checkBoxResettlementProgram.Checked = _currentUser.ProgramResetelment;
            checkBoxPreviouslyRegistered.Checked = _currentUser.IsRegistered;
            checkBoxFingerprinting.Checked = _currentUser.HasFingerprints;
            checkBoxLanguageDocument.Checked = _currentUser.KnowRussian;
            checkBoxPatent.Checked = _currentUser.HasPatent;
            dateTimePickerPatentDate.Value = _currentUser.PatentDate;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Заполните обязательные поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveUserData();
            Controller.Instance.UpdateUser(_currentUser);
            MessageBox.Show("Данные сохранены успешно!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(comboBoxVisitPurpose.Text))
                return false;
            if (string.IsNullOrWhiteSpace(comboBoxCitizenship.Text))
                return false;
            if (checkBoxPatent.Checked && dateTimePickerPatentDate.Value == DateTime.MinValue)
                return false;

            return true;
        }

        private void SaveUserData()
        {

            _currentUser.DateOfEntry = dateTimePickerEntryDate.Value;
            _currentUser.VisitPurpose = comboBoxVisitPurpose.Text;
            _currentUser.Citizenship = comboBoxCitizenship.Text;
            _currentUser.HasPolicy = checkBoxInsurance.Checked;
            _currentUser.HasInn = checkBoxINN.Checked;
            _currentUser.IsLongStay = checkBoxStayDuration.Checked;
            _currentUser.HighQualify = checkBoxHighlyQualified.Checked;
            _currentUser.ProgramResetelment = checkBoxResettlementProgram.Checked;
            _currentUser.IsRegistered = checkBoxPreviouslyRegistered.Checked;
            _currentUser.HasFingerprints = checkBoxFingerprinting.Checked;
            _currentUser.KnowRussian = checkBoxLanguageDocument.Checked;
            _currentUser.HasPatent = checkBoxPatent.Checked;
            _currentUser.PatentDate = dateTimePickerPatentDate.Value;

        }

        private async void buttonViewMap_Click(object sender, EventArgs e)
        {
            Points = await Controller.Instance.seeMap(_currentUser);
            ShowMap();

        }

        private void checkBoxPatent_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerPatentDate.Enabled = checkBoxPatent.Checked;

            if (!checkBoxPatent.Checked)
            {
                dateTimePickerPatentDate.Value = DateTime.Today;
            }
        }

        public void ShowMap()
        {
            string message = "";
            var sortedPoints = Points.OrderBy(p => p.Date).ToList();

            foreach (var point in sortedPoints)
            {
                message += $"Документ: {point.Description}\r\n";
                message += $"Что необходимо сделать: {point.DateText}\r\n";
                message += $"Срок получения до: {point.Date:dd.MM.yyyy}\r\n";
                message += "\r\n";
            }

            ShowMessageWindow(message);
        }
        private void ShowMessageWindow(string text)
        {
            Form messageForm = new Form();
            messageForm.Text = "Информация о точках";
            messageForm.Size = new Size(500, 400);

            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.Dock = DockStyle.Fill;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.Text = text;

            messageForm.Controls.Add(textBox);
            messageForm.StartPosition = FormStartPosition.CenterParent;
            messageForm.ShowDialog();
        }
        private void dateTimePickerEntryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPatentDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}