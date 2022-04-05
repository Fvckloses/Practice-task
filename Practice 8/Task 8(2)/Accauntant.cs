namespace Task_8_2_
{
    internal class Accauntant
    {

        public bool AskForBonus(Position dol, int hours)
        {
            if (hours > (int)dol) return true;
            else return false;
        }
    }
}