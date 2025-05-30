using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class RuleService
    {
        private readonly RuleRepository _ruleRepository;

        public RuleService(RuleRepository ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }

        public async Task<List<RuleMessage>> GetAllRulesAsync()
        {
            return await _ruleRepository.GetAllRulesAsync();
        }

        public async Task<RuleMessage?> GetRuleByIdAsync(int id)
        {
            return await _ruleRepository.GetRuleByIdAsync(id);
        }

        public async Task<bool> CreateRuleAsync(RuleMessage ruleMessage)
        {
            await _ruleRepository.AddRuleAsync(ruleMessage);
            await _ruleRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRuleAsync(int id)
        {
            var rule = await _ruleRepository.GetRuleByIdAsync(id);
            if (rule == null) return false;

            _ruleRepository.DeleteRule(rule);
            await _ruleRepository.SaveChangesAsync();
            return true;
        }
        public void changeRule(RuleMessage ruleMessage)
        {
            _ruleRepository.UpdateRule(ruleMessage);
            _ruleRepository.SaveChangesAsync();
        }
    }
}
