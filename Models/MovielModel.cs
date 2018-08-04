using System;
using System.Collections.Generic;

namespace ProjetoDesafioInForma.Models {
    public class MovieModel {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<MovieResultModel> results { get; set; }
        public MovieResultModel movieResult  { get; set; }
    }
}