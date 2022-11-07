using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary {
    
    public class Item {
    
        public string Text { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;
    }
}
