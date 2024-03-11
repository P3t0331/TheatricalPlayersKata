using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatricalPlayersRefactoringKata
{
    internal interface IPrinter
    {
        public string Print(Invoice invoice, Dictionary<string, Play> plays);
    }
}
