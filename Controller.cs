using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Controller
    {
        private static Controller _instance;
        private static readonly object _lock = new object();
        private Service service;
        private MapService mapservice;
        private RuleService ruleservice;
        public static AppDbContext context = new AppDbContext();
        private RuleRepository repository = new RuleRepository(context);
        public static User user;
        public Controller()
        {
            service = new Service(context);
            mapservice = new MapService(repository);
            ruleservice = new RuleService(repository);
        }

        public static Controller Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Controller();
                    return _instance;
                }
            }
        }
        public AppDbContext GetContext()
        {
            return context;
        }

        public void UpdateUser(User user)
        {
            service.updateUser(user);
        }
        public void AddUser(User user)
        {
            service.addUser(user);
        }
        public bool CheckUsers(string phone)
        {
           return service.checkUser(phone);
        }
        public User GetUser(string phone)
        {
            return service.getUser(phone);
        }
        public async Task<List<MapPoint>> seeMap(User user)
        {
            List<MapPoint> points = await mapservice.GenerateMap(user);
            return points;
        }
        public Task<RuleMessage> GetRule(int Id)
        {
            return ruleservice.GetRuleByIdAsync(Id);
        }
        public Task<List<RuleMessage>> GetAllRules()
        {
            return ruleservice.GetAllRulesAsync();
        }
        public Task<bool> AddRule(RuleMessage rule)
        {
            return ruleservice.CreateRuleAsync(rule);
        }
        public Task<bool> RemoveRule(int Id) 
        { 
            return ruleservice.DeleteRuleAsync(Id);
        }
        public void ChangeRule(RuleMessage ruleMessage)
        {
            ruleservice.changeRule(ruleMessage);
        }
    }
}
