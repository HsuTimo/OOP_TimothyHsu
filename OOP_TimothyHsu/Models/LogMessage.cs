namespace OOP_TimothyHsu.Models
{
    public class LogMessage
    {
        public string Boodschap { get; private set; }
        public int ID { get; private set; }
        private static int _counter { get; set; }
        private int GenereerID()
        {
            _counter++;
            return _counter;
        }
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenereerID();
        }
        public override string ToString()
        {
            return $"==============================================\nLOG:{ID} {Boodschap}\n";
        }
    }
}
