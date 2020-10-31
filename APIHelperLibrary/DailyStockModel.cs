using System;
using System.Collections.Generic;
using System.Text;

namespace APIHelperLibrary
{
    public class DailyStockModel : SymbolModel
    {
        public float Open { get; set; }
        public float Close { get; set; }
        public float High { get; set; }
        public float Low { get; set; }

        public float Volume { get; set; }
    }
}
