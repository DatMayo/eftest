using eftest.Enum;

namespace eftest.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public ActionType Type { get; set; } = ActionType.Undefined;
        public string IP { get; set; } = "127.0.0.1";
    }
}
