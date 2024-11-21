namespace QuickBiteAPI.Models
{
    public class UserModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string  email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string passwordHash { get; set; }
        public string userRole { get; set; } 
        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
