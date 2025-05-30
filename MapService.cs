using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MapService
    {
        private readonly RuleRepository _ruleRepository;

        public MapService(RuleRepository ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }
        public async Task<List<MapPoint>> GenerateMap(User user)
        {
            List<MapPoint> mapPoints = new List<MapPoint>();
            List<RuleMessage> rules = await GetAllRulesForMapAsync();
            foreach (var ruleMessage in rules) 
            {
                foreach(var rule in ruleMessage.Rules)
                {
                    if (rule.IsApplicable(user))
                    {
                        MapPoint mapPoint = new MapPoint();
                        mapPoint.Description = ruleMessage.Message;
                        mapPoint.DateText = rule.TimeText;
                        if (rule.Days != null)
                        {
                            mapPoint.Date = rule.GetDate(user);
                        }
                        mapPoints.Add(mapPoint);
                        break;
                    }
                }
                
            }
            return mapPoints;
        }

        public async Task<List<RuleMessage>> GetAllRulesForMapAsync()
        {
            return await _ruleRepository.GetAllRulesAsync();
        }
    }
}
