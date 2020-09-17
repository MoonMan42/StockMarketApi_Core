using System;
using System.Collections.Generic;
using System.Text;

namespace APIHelperLibrary
{
    public class SymbolModel
    {
        public string Symbol { get; set; }
        public string Name { get; set; }

        public string GetResults
        {
            get
            {
                return $"{Symbol} - {Name}";
            }
        }
    }
}
