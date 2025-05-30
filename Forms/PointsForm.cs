using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class PointsForm : Form

    {
        public static RuleMessage ruleMessage;
        bool ischange = false;
        private readonly ConditionAdd _ConditionAdd;

        public PointsForm(ConditionAdd _conditionAdd)
        {
            InitializeComponent();

            _ConditionAdd = _conditionAdd;

            this.FormClosed += (s, e) => _ConditionAdd.Show();

            ruleMessage = new RuleMessage();
            foreach (var item in ruleMessage.Rules)
            {
                listBoxPoints.Items.Add(item.TimeText);
            }
            textBox1.Text = ruleMessage.Message;
            textBoxMessage.Text = ruleMessage.Title;

        }
        public PointsForm(RuleMessage rl)
        {
            _ConditionAdd = new ConditionAdd();
            this.FormClosed += (s, e) => _ConditionAdd.Show();
            InitializeComponent();
            ruleMessage = rl;
            foreach (var item in ruleMessage.Rules)
            {
                listBoxPoints.Items.Add(item.TimeText);
            }
            ischange = true;
            textBox1.Text = ruleMessage.Message;
            textBoxMessage.Text = ruleMessage.Title;

        }
        public void AddRule(Rule rule)
        {
            ruleMessage.Rules.Add(rule);
        }
        public void ChangeRule(Rule rule, Rule ruleDel)
        {
            ruleMessage.Rules.Remove(ruleDel);
            ruleMessage.Rules.Add(rule);
        }
        public void LoadPoints()
        {
            listBoxPoints.Items.Clear();
            foreach (var item in ruleMessage.Rules)
            {
                listBoxPoints.Items.Add(item.TimeText);
            }
        }

        private void listBoxPoints_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            RuleForm form = new RuleForm(this);
            form.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPoints.SelectedItem != null)
            {
                string selectedItem = listBoxPoints.SelectedItem.ToString();
                Rule rlrem = ruleMessage.Rules.FirstOrDefault(u => u.TimeText == selectedItem);
                ruleMessage.Rules.Remove(rlrem);
                LoadPoints();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка.", "Ошибка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ischange)
            {
                ruleMessage.Message = textBox1.Text;
                ruleMessage.Title = textBoxMessage.Text;
                Controller.Instance.ChangeRule(ruleMessage);
                ConditionAdd form = new ConditionAdd();
                form.Show();
                this.Hide();
            }
            else
            {
                ruleMessage.Message = textBox1.Text;
                ruleMessage.Title = textBoxMessage.Text;
                Controller.Instance.AddRule(ruleMessage);
                ConditionAdd form = new ConditionAdd();
                form.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mess = textBox1.Text;
            string title = textBoxMessage.Text;
            ruleMessage.Message = mess;

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxPoints.SelectedItem != null)
            {
                string selectedItem = listBoxPoints.SelectedItem.ToString();

                Rule item = ruleMessage.Rules.FirstOrDefault(u => u.TimeText == selectedItem);
                RuleForm form = new RuleForm(this, item);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка.", "Ошибка");
            }
        }


    }
}