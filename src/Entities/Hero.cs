namespace dotnet_poo.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, int HpCurrent, int HpMax,
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
        public Hero()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int HpMax { get; set; }
        public int HpCurrent { get; set; }
        public int MpMax { get; set; }
        public int MpCurrent { get; set; }
        public string HeroType { get; set; }



        public override string ToString()
        {
            return "HeroType: " + this.HeroType + "\n" + "Name: " + this.Name +
             "\n" + "HP: " + this.HpCurrent + "/" + this.HpMax + "\n" + "MP: " +
              this.MpCurrent + "/" + this.MpMax + "\n" + "Level: " + this.Level;
        }
        public virtual string Attack()
        {
            return this.Name + " Fez um ataque";
        }
        public virtual string Defense()
        {
            return this.Name + " Se defendeu";
        }
    }
}