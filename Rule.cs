using Microsoft.VisualBasic.ApplicationServices;
using Npgsql.TypeMapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Rule
    {
        public int Id { get; set; }
        public int? Mess_ID { get; set; }
        public string TimeText { get; set; } = string.Empty;
        public int? Days { get; set; }
        public bool? d_type { get; set; }

        public DateTime patentDate { get; set; }
        public RuleMessage RuleMessage { get; set; } = null!;
        public List<RuleDetail> RuleDetails { get; set; } = new List<RuleDetail>();

        public bool IsApplicable(User user)
        {
            int checker = 0;
            foreach (var kvp in RuleDetails)
            {
                string propertyName = kvp.Key;    
                string expectedStr = kvp.Value;   

                PropertyInfo prop = typeof(User).GetProperty(propertyName);
                if (prop != null)
                {
                    object actualValue = prop.GetValue(user);

                    object expectedValue = Convert.ChangeType(expectedStr, prop.PropertyType);

                    if (actualValue != null && actualValue.Equals(expectedValue))
                    {
                        checker++;
                    }
                }
            }

            return checker == RuleDetails.Count;
        }

        public DateTime GetDate(User user)
        {
            DateTime baseDate;

            if (d_type == null)
            {
                baseDate = user.DateOfEntry;
            }
            else
            {
                baseDate = user.PatentDate;
            }

            if (baseDate.Kind == DateTimeKind.Unspecified)
            {
                baseDate = DateTime.SpecifyKind(baseDate, DateTimeKind.Utc);
            }

            int daysToAdd = Days ?? 0;

            return baseDate.AddDays(daysToAdd);
        }

    }
}
