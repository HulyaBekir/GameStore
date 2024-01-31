using FluentValidation;
using GameStore.Models.Models.User;

namespace GameStore.Validators
{
    public class GameValidator : AbstractValidator<Game>
    {
        public GameValidator() 
        {
            RuleFor(x => x.GenreId)
                .NotNull().GreaterThan(0);
            RuleFor(x => x.Title)
                .NotEmpty().MinimumLength(3);
            RuleFor(x => x.Id)
                .NotEmpty().GreaterThan(0);
            RuleFor(x => x.RelaseDate)
                .NotNull().NotEmpty().LessThan(new DateTime(2001, 04, 11));
        }


    }
}
