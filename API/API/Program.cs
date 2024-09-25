using API.Models;
//Testar as APIs 
// - Rest Client - Extensão do VsCode
// - Postman
// - Insomnia 
//MINIMAL APIs

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto(){Nome = "Notebook", Preco = 5000, Quantidade = 54});
produtos.Add(new Produto(){Nome = "PC", Preco = 10000, Quantidade = 30});
produtos.Add(new Produto(){Nome = "Mouse", Preco = 100, Quantidade = 109});
produtos.Add(new Produto(){Nome = "Headset", Preco = 200, Quantidade = 12});

//EndPoints - Funcionalidades
//Request - Configurar a URL e o método/verbo HTTP
//Response - Retornar os dados (json/xml) e
app.MapGet("/", () => "API de Produtos");


//GET: /produto/listar
// app.MapGet("/produto/listar", () => 
// {
//     return Results.Ok(produtos);
// });

//POST: /produto/cadastrar
app.MapPost("/produto/cadastrar/{nome}", (string nome) => 
{   
    //Criar e preencher objeto
    Produto produto = new Produto();
    produto.Nome = nome;
    //Adicionando na lista
    produtos.Add(produto);
    return Results.Ok(produtos);
});

// Impressão de objeto
// app.MapGet("/retornarendereco", () =>
// {
//     dynamic endereco = new {
//         rua = "Parigot de Souza",
//         numero = 5300,
//         cep = "81290-350"
//     };
//     return endereco;
// });

//Criar uma funcionalidade/Endpoint para receber informações
// - Receber informações pela URL da requisição

// - Receber informações pelo corpo da requisição
// - Guardar as informações em uma lista

app.Run();

// C# - Utilização de get e set
// Produto produto = new Produto();

// Console.WriteLine("Preço: " + produto.Preco);

// JAVA - Utilização de get e set
// Produto produto = new Produto();
// produto.setPreco(5);
// Console.WriteLine("Preço: " + produto.getPreco());