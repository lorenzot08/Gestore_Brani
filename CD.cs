using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestore_Brani_CD
{
    class CD
    {
        private string _titolo;
        private string _autore;
        private List<Brano> _brani;

        public CD(string titolo, string autore)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<Brano>();
        }
        public string getTitolo()
        {
            return _titolo;
        }
        public void setTitolo(string titolo)
        {
            _titolo = titolo;
        }
        public string getAutore()
        {
            return _autore;
        }
        public void setAutore(string autore)
        {
            _autore = autore;
        }
        public void AggiungiBrano(Brano br)
        {
            _brani.Add(br);
        }
        public double Durata()
        {
            double totale = 0;
            foreach (Brano br in _brani)
            {
                totale += br.getDurata();
            }
            return totale;
        }
    }
}