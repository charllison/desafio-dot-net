using System;

namespace ProjetoDesafioInForma.Helper {
    static class Constants {
        private const string KeyApi = "ADD_KEY_HERE";
        private const string UrlBaseApi = "https://api.themoviedb.org/3/";
        public const string UrlImage = "https://image.tmdb.org/t/p/{0}/{1}";
        public const string UrlQuery = UrlBaseApi + "search/movie?api_key=" + KeyApi + "&query={0}";
        public const string UrlQueryId = UrlBaseApi + "movie/{0}?api_key=" + KeyApi; //"&language=pt-BR"
    }
}