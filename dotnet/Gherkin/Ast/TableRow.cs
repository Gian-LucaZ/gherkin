using System.Collections.Generic;

namespace Gherkin.Ast;

public class TableRow : IHasLocation
{
    public Location Location { get; set; }
    public IEnumerable<TableCell> Cells { get; set; }

    public TableRow(Location location, TableCell[] cells)
    {
        Location = location;
        Cells = cells;
    }
}