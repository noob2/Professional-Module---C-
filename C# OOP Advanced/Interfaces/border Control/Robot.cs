namespace border_Control
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            ID = id;
        }

        public string ID { get; set; }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public override string ToString()
        {
            return this.ID;
        }
    }
}
