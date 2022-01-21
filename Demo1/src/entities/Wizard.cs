namespace Demo1.src.entities
{
    public class Wizard : Hero // Herança de Hero
    {   
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack() {
            return this.Name + " Lançou Magia."; // O polimorfismo foi dessa frase.
        }
        // Exemplo de POLIMORFISMO com ENCAPSULAMENTO.
        public string Attack(int Bonus) {
            //Encapsulamento.
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus + ".";
            }
            else
            { 
                return this.Name + " Lançou uma Magia com força fraca com bonus de " + Bonus + ".";
            }

        }


    }
}