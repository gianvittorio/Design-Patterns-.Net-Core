using System.Runtime.CompilerServices;

namespace singleton
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        public string Name { get; set; }
        public int Level { get; set; }

        public static PrimaryPlayer Instance
        {
            get { return _instance; }
        }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1
            };
        }

        private PrimaryPlayer()
        {
        }
    }
}