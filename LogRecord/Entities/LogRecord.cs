namespace Log.Entities
{
    internal class LogRecord
    {
        public string? UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string line)
        {
            string[] vect = line.Split(' ');
            UserName = vect[0];
            Instant = DateTime.Parse(vect[1]);
        }

        public override int GetHashCode() => UserName.GetHashCode();

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            LogRecord? other = obj as LogRecord;
            return UserName.Equals(other?.UserName);
        }
    }
}
