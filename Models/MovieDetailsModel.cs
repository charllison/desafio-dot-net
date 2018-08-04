using System;
using System.Collections.Generic;

namespace ProjetoDesafioInForma.Models {
    public class MovieDetailsModel {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public string poster_path  { get; set; }
        public string backdrop_path { get; set; }
    }
}