namespace Food_Shortage
{
    public abstract class Human : IBuyer
    {
        private string name;
        private int age;

        protected Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Food { get; set; }
        public abstract void BuyFood();
    }
}
