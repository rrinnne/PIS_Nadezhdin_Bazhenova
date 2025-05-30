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
    public partial class ConditionAdd : Form
    {
        public static List<RuleMessage> ruleList;
        

        public ConditionAdd()
        {
            InitializeComponent();

            this.Load += ConditionAdd_Load;
            this.FormClosed += (s, e) => new authorizationForm().Show();
        }
        private async void ConditionAdd_Load(object sender, EventArgs e)
        {
            await Task.Delay(100);
            ruleList = await Controller.Instance.GetAllRules();

            foreach (var rule in ruleList)
            {
                listBox1.Items.Add(rule.Title);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointsForm form = new PointsForm(this);
            form.Show();
            this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();

                RuleMessage item = ruleList.FirstOrDefault(r => r.Title == selectedItem);
                PointsForm form = new PointsForm(item);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка.", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox1.SelectedItem = null;
                RuleMessage rm = ruleList.FirstOrDefault(r => r.Title == selectedItem);
                Controller.Instance.RemoveRule(rm.Id);
                ruleList.Remove(rm);
                listBox1.Items.Clear();
                foreach (var rule in ruleList)
                {
                    listBox1.Items.Add(rule.Title);
                }


            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка.", "Ошибка");
            }
        }
    }
}
