namespace dotnet_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, int HpCurrent, int HpMax,
         int MpCurrent, int MpMax, string HeroType)
        {

            this.Name = Name;
            this.Level = Level;
            this.HpMax = HpMax;
            this.HpCurrent = HpCurrent;
            this.MpMax = MpCurrent;
            this.MpCurrent = MpCurrent;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + "Lancou uma magia com força fraca com bonus de " + Bonus;
            }

        }
        public override string Defense()
        {
            return this.Name + ": Defendeu com Magia ";
        }
        public string Defense(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Defendeu com sua Magia efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Defendeu com sua Magia com defesa fraca com bonus de " + Bonus;
            }

        }
    }
}
