using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class RegistrationForm : Form
    {

        private readonly authorizationForm _autorizationForm;

        public RegistrationForm(authorizationForm authorizationForm1)
        {

            InitializeComponent();
            _autorizationForm = authorizationForm1;
            this.FormClosed += (s, e) => _autorizationForm.Show();
        }

        private async void buttonAuth_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text.Trim();

            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Номер должен содержать минимум 10 символов",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Controller.Instance.CheckUsers(phone))
            {
                User user = Controller.Instance.GetUser(phone);
                Form1 form = new Form1(user, this);
                form.Show();
                this.Hide();
            }
            else
            {
                User user = new User();
                user.DateOfEntry = DateTime.Now.ToUniversalTime();
                user.PatentDate = DateTime.Now.ToUniversalTime();
                user.Phone = phone;
                user.VisitPurpose = "";
                user.Citizenship = "";
                user.HasPolicy = false;
                user.HasInn = false;
                user.IsLongStay = false;
                user.HighQualify = false;
                user.ProgramResetelment = false;
                user.IsRegistered = false;
                user.HasFingerprints = false;
                user.KnowRussian = false;
                user.HasPatent = false;
                Controller.Instance.AddUser(user);
                Form1 form = new Form1(user, this);
                form.Show();
                this.Hide();
            }

        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.Length >= 10;
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}