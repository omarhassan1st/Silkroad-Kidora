using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidora_Tool
{
    class Messageay
    {
        public delegate void Message(string txt);
        public static Message Error = (string txt) => MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static Message Information = (string txt) => MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
