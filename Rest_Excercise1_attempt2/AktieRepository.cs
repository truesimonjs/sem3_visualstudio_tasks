using Rest_Excercise1_attempt2.Models;

namespace Rest_Excercise1_attempt2
{
    public class AktieRepository
    {
        private int nextId = 0;
        private List<Aktie> aktieList = new();
        public AktieRepository()
        {
            const int testDataCount = 3;
            for (int i = 0; i < testDataCount; i++)
            {
                Aktie aktie = new();
                aktie.Name = $"testAktie{i}";
                aktie.Price = 10 * i;
                add(aktie);
            }
        }
        public List<Aktie> GetAll()
        {
            return new List<Aktie>(aktieList);
        }
        public Aktie GetById(int id)
        {
            return aktieList.Where(Aktie => Aktie.Id == id).FirstOrDefault();
            
        }
        public Aktie add (Aktie newAktie)
        {
            newAktie.Id = GetNextId();
            aktieList.Add(newAktie);
            return newAktie;
        }
        public Aktie Delete(int id)
        {
            Aktie aktie = GetById(id);
            if (aktie == null) return null;
            aktieList.Remove(aktie);
            return aktie;
        }
        public Aktie Update(int id, Aktie newValues)
        {
            Aktie aktie = GetById(id);
            if (aktie == null) return null;
            aktie.Price = newValues.Price;
            aktie.Name = newValues.Name;
            return aktie;
        }
        public int GetNextId()
        {
            int value = nextId;
            nextId++;
            return value;
        }
    }
}
