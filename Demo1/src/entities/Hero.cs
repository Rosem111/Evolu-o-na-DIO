namespace Demo1.src.entities
{
    public abstract class Hero // Classe ABSTRATA que é a classe MÃE.
    {
            public Hero(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero() { 

        }
        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() {
            return this.Name + " Atacou com a sua espada.";
        }



    }
}