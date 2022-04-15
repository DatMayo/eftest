namespace eftest.Models
{

    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Enabled { get; set; } = true;
        public ICollection<Log> Logs { get; set; } = new List<Log>();
    }

}
