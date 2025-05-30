using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Forms
{
    public partial class RuleForm : Form
    {
        private readonly int? _ruleId;
        private PointsForm previousForm;
        private Rule rule;
        bool ischange = false;
        public RuleForm(PointsForm form)
        {
            previousForm = form;
            InitializeComponent();
        }
        public RuleForm(PointsForm form, Rule rul)
        {
            rule = rul;
            previousForm = form;
            ischange = true;
            InitializeComponent();
            LoadRuleData();
        }

        private void LoadRuleData()
        {
            if (rule == null)
                return;


            textBoxUserMessage.Text = rule.TimeText;

            numericUpDownDocumentDuration.Value = (decimal)rule.Days;

            var visitPurposes = rule.RuleDetails
                .Where(d => d.Key == "VisitPurpose")
                .Select(d => d.Value);
            CheckItemsInList(checkedListBoxVisitPurpose, string.Join(",", visitPurposes));

            var citizenships = rule.RuleDetails
                .Where(d => d.Key == "Citizenship")
                .Select(d => d.Value);
            CheckItemsInList(checkedListBoxCitizenship, string.Join(",", citizenships));

            checkBoxInsurance.Checked = rule.RuleDetails
                .Any(d => d.Key == "HasPolicy" && d.Value == "true");
            checkBoxINN.Checked = rule.RuleDetails
                .Any(d => d.Key == "HasInn" && d.Value == "true");
            checkBoxLongTerm.Checked = rule.RuleDetails
                .Any(d => d.Key == "IsLongStay" && d.Value == "true");
            checkBoxHighlyQualified.Checked = rule.RuleDetails
                .Any(d => d.Key == "HighQualify" && d.Value == "true");
            checkBoxResettlementProgram.Checked = rule.RuleDetails
                .Any(d => d.Key == "ProgramResetelment" && d.Value == "true");
            checkBoxPreviouslyRegistered.Checked = rule.RuleDetails
                .Any(d => d.Key == "IsRegistered" && d.Value == "true");
            checkBoxFingerprinting.Checked = rule.RuleDetails
                .Any(d => d.Key == "HasFingerprinting" && d.Value == "true");
            checkBoxLanguageDocument.Checked = rule.RuleDetails
                .Any(d => d.Key == "KnowRussian" && d.Value == "true");
            checkBoxPatent.Checked = rule.RuleDetails
                .Any(d => d.Key == "HasPatent" && d.Value == "true");
        }

        private void SetControlValue(string key, string value)
        {

        }

        private void CheckItemsInList(CheckedListBox listBox, string values)
        {
            if (string.IsNullOrEmpty(values))
                return;

            var parts = values.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(v => v.Trim());

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                var itemText = listBox.Items[i].ToString();
                if (parts.Contains(itemText))
                    listBox.SetItemChecked(i, true);
                else
                    listBox.SetItemChecked(i, false);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ischange)
                {
                    if (string.IsNullOrWhiteSpace(textBoxUserMessage.Text))
                    {
                        MessageBox.Show("Введите название правила", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ;
                    string RuleMessage = textBoxUserMessage.Text;
                    int Days = (int)numericUpDownDocumentDuration.Value;
                    var VisitPurpose = checkedListBoxVisitPurpose.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString())
                    .ToList();
                    var Citizenship = checkedListBoxCitizenship.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString())
                    .ToList();
                    bool HasPolis = checkBoxInsurance.Checked;
                    bool HasInn = checkBoxINN.Checked;
                    bool ForLongStay = checkBoxLongTerm.Checked;
                    bool HighQualify = checkBoxHighlyQualified.Checked;
                    bool ReLocationing = checkBoxResettlementProgram.Checked;
                    bool VasRegistered = checkBoxPreviouslyRegistered.Checked;
                    bool GotFingerprinting = checkBoxFingerprinting.Checked;
                    bool KnowRussian = checkBoxLanguageDocument.Checked;
                    bool GotPatent = checkBoxPatent.Checked;
                    Rule rule = new Rule();
                    rule.Days = Days;
                    rule.TimeText = RuleMessage;
                    foreach (var item in VisitPurpose)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "VisitPurpose",
                            Value = item.ToString()
                        });
                    }
                    ;
                    foreach (var item in Citizenship)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "Citizenship",
                            Value = item.ToString()
                        });
                    }
                    ;
                    if (HasPolis)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasPolicy",
                            Value = HasPolis.ToString().ToLower()
                        });
                    }
                    ;
                    if (HasInn)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasInn",
                            Value = HasInn.ToString().ToLower()
                        });
                    }
                    ;
                    if (ForLongStay)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "IsLongStay",
                            Value = ForLongStay.ToString().ToLower()
                        });
                    }
                    ;
                    if (HighQualify)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HighQualify",
                            Value = HighQualify.ToString().ToLower()
                        });
                    }
                    ;
                    if (ReLocationing)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "ProgramResetelment",
                            Value = ReLocationing.ToString().ToLower()
                        });
                    }
                    ;
                    if (VasRegistered)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "IsRegistered",
                            Value = VasRegistered.ToString().ToLower()
                        });
                    }
                    ;
                    if (GotFingerprinting)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasFingerprinting",
                            Value = GotFingerprinting.ToString().ToLower()
                        });
                    }
                    ;
                    if (KnowRussian)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "KnowRussian",
                            Value = KnowRussian.ToString().ToLower()
                        });
                    }
                    ;
                    if (GotPatent)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasPatent",
                            Value = GotPatent.ToString().ToLower()
                        });
                        rule.d_type = true;
                    }
                    ;
                    previousForm.AddRule(rule);
                    previousForm.LoadPoints();
                    previousForm.Show();

                    this.Close();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxUserMessage.Text))
                    {
                        MessageBox.Show("Введите название правила", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ;
                    string RuleMessage = textBoxUserMessage.Text;
                    int Days = (int)numericUpDownDocumentDuration.Value;
                    var VisitPurpose = checkedListBoxVisitPurpose.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString())
                    .ToList();
                    var Citizenship = checkedListBoxCitizenship.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString())
                    .ToList();
                    bool HasPolis = checkBoxInsurance.Checked;
                    bool HasInn = checkBoxINN.Checked;
                    bool ForLongStay = checkBoxLongTerm.Checked;
                    bool HighQualify = checkBoxHighlyQualified.Checked;
                    bool ReLocationing = checkBoxResettlementProgram.Checked;
                    bool VasRegistered = checkBoxPreviouslyRegistered.Checked;
                    bool GotFingerprinting = checkBoxFingerprinting.Checked;
                    bool KnowRussian = checkBoxLanguageDocument.Checked;
                    bool GotPatent = checkBoxPatent.Checked;
                    Rule rule = new Rule();
                    rule.Days = Days;
                    rule.TimeText = RuleMessage;
                    foreach (var item in VisitPurpose)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "VisitPurpose",
                            Value = item.ToString()
                        });
                    }
                    ;
                    foreach (var item in Citizenship)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "Citizenship",
                            Value = item.ToString()
                        });
                    }
                    ;
                    if (HasPolis)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasPolicy",
                            Value = HasPolis.ToString().ToLower()
                        });
                    }
                    ;
                    if (HasInn)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasInn",
                            Value = HasInn.ToString().ToLower()
                        });
                    }
                    ;
                    if (ForLongStay)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "IsLongStay",
                            Value = ForLongStay.ToString().ToLower()
                        });
                    }
                    ;
                    if (HighQualify)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HighQualify",
                            Value = HighQualify.ToString().ToLower()
                        });
                    }
                    ;
                    if (ReLocationing)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "ProgramResetelment",
                            Value = ReLocationing.ToString().ToLower()
                        });
                    }
                    ;
                    if (VasRegistered)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "IsRegistered",
                            Value = VasRegistered.ToString().ToLower()
                        });
                    }
                    ;
                    if (GotFingerprinting)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasFingerprinting",
                            Value = GotFingerprinting.ToString().ToLower()
                        });
                    }
                    ;
                    if (KnowRussian)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "KnowRussian",
                            Value = KnowRussian.ToString().ToLower()
                        });
                    }
                    ;
                    if (GotPatent)
                    {
                        rule.RuleDetails.Add(new RuleDetail
                        {
                            Key = "HasPatent",
                            Value = GotPatent.ToString().ToLower()
                        });
                        rule.d_type = true;
                    }
                    ;
                    previousForm.ChangeRule(rule, this.rule);
                    previousForm.LoadPoints();
                    previousForm.Show();

                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRuleDetails(Rule rule)
        {

        }

        private List<string> GetCheckedItems(CheckedListBox listBox)
        {
            return listBox.CheckedItems.Cast<string>().ToList();
        }

        private void AddCheckBoxDetail(Rule rule, string key, CheckBox checkBox)
        {
            rule.RuleDetails.Add(new RuleDetail
            {
                Key = key,
                Value = checkBox.Checked.ToString().ToLower()
            });
        }

        private void checkBoxPatent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxVisitPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}