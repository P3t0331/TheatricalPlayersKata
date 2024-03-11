using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata
{
    public interface IPrinter
    {
        public string Print(Invoice invoice, Dictionary<string, Play> plays);
    }
}
