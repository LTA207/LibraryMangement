using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV2
{
    public class UndoItem
    {
        public string TableName { get; set; } 
        public object[] ItemArray { get; set; }
        public string Action { get; set; } 
        public int Index { get; set; }
        public int RealIndex { get; set; }
    }

}
