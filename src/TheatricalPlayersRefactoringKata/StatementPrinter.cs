using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata;

public class StatementPrinter
{
    public string Print(Invoice invoice, Dictionary<string, Play> plays, IPrinter? printer = null) 
    {
        if (printer == null)
        {
            printer = new ConsolePrinter();
        }

        return printer.Print(invoice, plays);
    }
}
