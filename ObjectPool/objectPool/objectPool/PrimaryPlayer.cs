namespace looseCoupling
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;

        public string Name { get; set; }
        public int Level { get; set; }

        public int Armor { get; set; }

        public int Health { get; set; }
        public IWeapon Weapon { set; get; }

        public static PrimaryPlayer Instance
        {
            get { return _instance; }
        }

        private PrimaryPlayer()
        {
        }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1,
                Armor = 25,
                Health = 100
            };
        }
    }
}