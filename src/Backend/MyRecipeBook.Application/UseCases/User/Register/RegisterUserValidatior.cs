using MyRecipeBook.Communication.Requests;
using FluentValidation;
namespace MyRecipeBook.Application.UseCases.User.Register
{
    class RegisterUserValidatior : AbstractValidator<RequestRegisterUserJson>
    {
       public RegisterUserValidatior()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage("o Nome não pode ser vazio");
            RuleFor(user => user.Email).NotEmpty().WithMessage("o Emal não pode ser vazio");
            RuleFor(user => user.Email).EmailAddress();
            RuleFor(user => user.Password.Length).GreaterThanOrEqualTo(6);
        }
    }
}
