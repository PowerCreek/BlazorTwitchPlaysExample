namespace TBRPG_1.Game.Hud
{
    public interface IPercenter
    {
        public int MaxPoints { get; set; }
        public int CurrentPoints { get; set; }

        public virtual int SetPoints
        {
            set => MaxPoints = CurrentPoints = value;
        }

        public virtual decimal Percentage => (decimal) CurrentPoints / MaxPoints;

        public virtual int ChangePercent(int delta)
        {
            return 0;
        }
    }
}