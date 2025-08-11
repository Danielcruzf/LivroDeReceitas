using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Response;

namespace MyRecipeBook.Application.UseCases.User.Register;

public class RegisterUserUseCase
{
    public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
    {
        validate(request);
        // mapear a request em uma unidade 
        // criptografia da senha
        // salvar no banco de Dados


        return new ResponseRegisteredUserJson
        {
            Name = request.Name,
        };
    }
    private void validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidatior();
        var result = validator.Validate(request);

        if (result.IsValid==false)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage);

            throw new Exception();
        }
    }
}
