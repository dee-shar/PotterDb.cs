# PotterDb.cs
Web-API for [potterdb.com](https://potterdb.com/) an expansive API dedicated to housing a comprehensive collection of data from the Harry Potter Universe

## Example
```cs
using PotterDbApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new PotterDb();
            string spells = await api.GetSpells();
            Console.WriteLine(spells);
        }
    }
}
```
