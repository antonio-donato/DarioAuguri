using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioAuguri
{
    public class Dario
    {
        public List<String> _randomList = new List<string>();
        public string _path;
        static Random rnd = new Random();
        private string _searchPattern;

        public static Random Rnd
        {
            get { return rnd; }
            set { rnd = value; }
        }

        public Dario()
        {
        }

        public int SelectRandom()
        {
            int r = Rnd.Next(_randomList.Count);
            return r;
        }

        public void RiempiLista()
        {
            _path = "Resources/";
            _searchPattern = "*.aac";
            string[] fileEntries = Directory.GetFiles(_path, _searchPattern);

            foreach (string fileName in fileEntries)
            {
                _randomList.Add(fileName);
            }

        }

        public string Seleziona(int numeroRnd)
        {
            return _randomList[numeroRnd];
        }
    }

}
