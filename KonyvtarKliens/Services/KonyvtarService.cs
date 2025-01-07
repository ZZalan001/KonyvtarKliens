using KonyvtarApi.Models;
using KonyvtarKliens.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKliens.Services
{
    internal class KonyvtarService
    {
        public static async Task<List<KonyvtarakDTO>> GetAll(HttpClient client)
        {
            return await client.GetFromJsonAsync<List<KonyvtarakDTO>>("Konyvtar/GetAll");
        }
    }
}
