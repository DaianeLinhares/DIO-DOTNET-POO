namespace dotnet_poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HpCurrent, int HpMax,
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
            return this.Name + ": Atacou com sua Katana";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + ": Atacou com sua Katana super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Atacou com sua Katana com força fraca com bonus de " + Bonus;
            }
        }

        public override string Defense()
        {
            return this.Name + ": Se defendeu";
        }
        public string Defense(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + ": Defendeu com sua agilidade efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + ": Defendeu com sua agilidade com defesa fraca com bonus de " + Bonus;
            }

        }
    }
}
