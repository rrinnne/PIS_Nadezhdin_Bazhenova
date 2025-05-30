using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class RuleRepository
    {
        private readonly AppDbContext _context;
        
        public RuleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<RuleMessage>> GetAllRulesAsync()
        {

            return await _context.RuleMessages
                .Include(rm => rm.Rules)       
                    .ThenInclude(r => r.RuleDetails)  
                .ToListAsync();
        }

        public async Task<RuleMessage?> GetRuleByIdAsync(int id)
        {
            return await _context.RuleMessages
                .Include(rm => rm.Rules)
                    .ThenInclude(r => r.RuleDetails)
                .FirstOrDefaultAsync(rm => rm.Id == id);
        }

        public async Task AddRuleAsync(RuleMessage ruleMessage)
        {
            await _context.RuleMessages.AddAsync(ruleMessage);
            await _context.SaveChangesAsync();
        }

        public void UpdateRule(RuleMessage ruleMessage)
        {
            _context.RuleMessages.Update(ruleMessage);
            _context.SaveChanges();
        }

        public void DeleteRule(RuleMessage ruleMessage)
        {
            _context.RuleMessages.Remove(ruleMessage);
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
