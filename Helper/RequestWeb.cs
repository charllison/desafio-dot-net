using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjetoDesafioInForma.Helper {
    static class RequestWeb {
        
        // request api
        public static async Task<string> ApiRequest(string url) {
            using (var httpClient = new HttpClient()) {
                using (var res = await httpClient.GetAsync(new Uri(url))) {
                    string result = await res.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }

    }
}