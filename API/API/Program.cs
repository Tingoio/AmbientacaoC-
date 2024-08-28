//Testar as APIs 
// - Rest Client - Extensão do VsCode
// - Postman
// - Insomnia 
//MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Funcionalidade numero 1");

app.MapGet("/segundafuncionalidade", () => "Funcionalidade numero 2");

app.MapGet("/retornarendereco", () =>
{
    dynamic endereco = new {
        rua = "Parigot de Souza",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

//Criar uma funcionalidade/Endpoint para receber informações
// - Receber informações pela URL da requisição
// - Receber informações pelo corpo da requisição
// - Guardar as informações em uma lista

app.Run();
