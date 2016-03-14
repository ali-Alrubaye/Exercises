using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public class TableCell
    {
        private string _nodeName;
        public string Content { get; set; }

        public TableCell(string nodeName,string content)
        {
            this._nodeName = nodeName;
            Content = content;
        }
        public TableCell( string nodeName)
        {
            this._nodeName = nodeName;
            Content = "";
        }
        public override string ToString()
        {
            return string.Format("<td>{0}</td>", _nodeName, Content);
        }

    }
}
