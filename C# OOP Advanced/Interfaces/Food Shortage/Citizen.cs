using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Shortage
{
    public class Citizen : Human
    {
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate) 
            : base(name, age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}
