using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class authorizationForm : Form
    {
        public authorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm(this);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConditionAdd operatorForm = new ConditionAdd();
            operatorForm.Show();
            this.Hide();
        }

        private void authorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
