using System.Collections.ObjectModel;

namespace VuurwerkKassa
{
    public class Model
    {
        private Collection<Artikel> Artikelen = new Collection<Artikel>();
        private int vermenigvuldiging = 1;
        private float grandTotal = 0;

        public void addArtikel(Artikel a)
        {
            if (a != null && a.getNr() != 0)
            {
                a.setAantal(vermenigvuldiging);
                Artikelen.Add(a);
                vermenigvuldiging = 1;
            }
        }

        public void resetArtikelen()
        {
            this.Artikelen.Clear();
        }

        public void removeFromArtikelen(int selectedIdx)
        {
            this.Artikelen.RemoveAt(selectedIdx);
        }

        public void setGrandTotal(float total)
        {
            this.grandTotal = total;
        }

        public float getGrandTotal()
        {
            return this.grandTotal;
        }

        public void setVermenigvuldiging(int verm)
        {
            this.vermenigvuldiging = verm;
        }

        public int getVermenigvuldiging()
        {
            return this.vermenigvuldiging;
        }

        public Collection<Artikel> getArtikelen()
        {
            return this.Artikelen;
        }
    }
}
