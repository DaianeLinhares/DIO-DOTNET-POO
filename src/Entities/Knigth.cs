namespace dotnet_poo.src.Entities
{
    public class Knigth : Hero
    {
        public Knigth(string Name, int Level, int HpCurrent, int HpMax,
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
            return this.Name + ": Atacou com sua Espada";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Atacou com sua Espada super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Atacou com sua Espada com força fraca com bonus de " + Bonus;
            }

        }
        public override string Defense()
        {
            return this.Name + ": Defendeu com seu escudo";
        }
        public string Defense(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Defendeu com seu escudo super efetivo com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Defendeu com seu escudo com defesa fraca com bonus de " + Bonus;
            }

        }
    }
}
