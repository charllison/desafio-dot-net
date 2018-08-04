using System;
using FluentValidation;

namespace ProjetoDesafioInForma.Models {
    public class MovieResultValidator : AbstractValidator<MovieResultModel> {
        public MovieResultValidator() {
            // ddd rules to validate inputs
            RuleFor(x => x.title)
                .NotEmpty().WithMessage("Enter the title.")
                .Length(2, 100).WithMessage("The title must have at least 2 and a maximum of 100 characters.");
        }
    }
}