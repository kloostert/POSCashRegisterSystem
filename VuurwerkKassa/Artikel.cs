using System;

namespace VuurwerkKassa
{
    public class Artikel
    {
        private int nr;
        private int aantal;
        private String barcode;
        private String omschrijving;
        private float prijs;
        private float totaal;

        public Artikel(int n, int a, String b, String o, float p, float t)
        {
            this.nr = n;
            this.aantal = a;
            this.barcode = b;
            this.omschrijving = o;
            this.prijs = p;
            this.totaal = t;
        }

        public void setNr(int nummer)
        {
            this.nr = nummer;
        }

        public void setAantal(int aant)
        {
            this.aantal = aant;
            update();
        }

        public void setBarcode(String code)
        {
            this.barcode = code;
        }

        public void setOmsch(String omsch)
        {
            this.omschrijving = omsch;
        }

        public void setPrijs(float pr)
        {
            this.prijs = pr;
            update();
        }

        public void setTotaal(float tot)
        {
            this.totaal = tot;
        }


        public int getNr()
        {
            return this.nr;
        }

        public int getAantal()
        {
            return this.aantal;
        }

        public String getBarcode()
        {
            return this.barcode;
        }

        public String getOmsch()
        {
            return this.omschrijving;
        }

        public float getPrijs()
        {
            return this.prijs;
        }

        public float getTotaal()
        {
            return this.totaal;
        }

        private void update()
        {
            this.totaal = this.aantal * this.prijs;
        }

    }
}
