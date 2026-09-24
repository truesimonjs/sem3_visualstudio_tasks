using Rest_Excercise1_attempt2.Models;

namespace Rest_Excercise1_attempt2
{
    public class AktieRepository
    {
        private int nextId = 1;
        private List<Aktie> aktieList = new();
        public List<Aktie> GetAll()
        {
            return aktieList;
        }
        public Aktie GetById(int id)
        {
            return aktieList.Where(Aktie => Aktie.id == id).FirstOrDefault();
            
        }
        public Aktie add (Aktie newAktie)
        {
            newAktie.id = GetNextId();
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
            //change values here
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
