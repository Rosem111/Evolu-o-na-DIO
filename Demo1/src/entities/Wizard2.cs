namespace Demo1.src.entities
{
    public class Wizard2 : Hero
    {
         public Wizard2(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack() {
            return this.Name + " Lançou Magia Negra com força total."; 
        }
    }
}
