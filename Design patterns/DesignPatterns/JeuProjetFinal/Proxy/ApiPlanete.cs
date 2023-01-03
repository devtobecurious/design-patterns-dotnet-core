using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JeuProjetFinal.Proxy
{
    internal class ApiPlanete 
    {
        public async Task<IEnumerable<Planete>> GetList()
        {
            using HttpClient client = new();

            await using Stream stream = await client.GetStreamAsync("https://swapi.dev/api/planets");
            return await JsonSerializer.DeserializeAsync<List<Planete>>(stream);
        }
    }
}
