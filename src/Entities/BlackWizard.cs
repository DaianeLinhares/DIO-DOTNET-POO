namespace dotnet_poo.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, int HpCurrent, int HpMax,
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
            return this.Name + " Lançou Magia Obscura";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + " Lançou Magia Obscura super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + "Lancou uma magia Obscura com força fraca com bonus de " + Bonus;
            }

        }
        public override string Defense()
        {
            return this.Name + ": Defendeu com Magia Obscura";
        }
        public string Defense(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Defendeu com sua Magia Obscura efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Defendeu com sua Magia Obscura com defesa fraca com bonus de " + Bonus;
            }

        }
    }
}
