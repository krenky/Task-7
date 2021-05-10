using var16zad6;

namespace zadanie7
{
    class contain
    {
        Tariff[] TarriffMass = new Tariff[5];
        int Head = 0;
        public bool add(Tariff Input)
        {
            if (Head < TarriffMass.Length)
            {
                TarriffMass[Head] = Input;
                Head++;
                return true;
            }
            else return false;
        }
        public bool Delete(int index)
        {
            TarriffMass[index] = null;
            if (index != Head)
            {
                for (int j = index; j < Head; j++)
                {
                    TarriffMass[j] = TarriffMass[j + 1];
                }

            }
            return true;
        }
        public string Print(int index)
        {
            return TarriffMass[index].PrintInfo();
        }
        public string printAll()
        {
            string str = "";
            for (int i = 0; i < Head; i++)
            {
                str = str + Print(i) + "\n";
            }
            return str;
        }
    }
}
