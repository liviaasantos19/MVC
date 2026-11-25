//Importa recursos do framework
using Microsoft.AspNetCore.Mvc;
using CadastroProdutos.Models;

namespace CadastroProdutos.Controllers; //Organiza as classes

public class ProdutosController : Controller 
//           Nome do Controller   Herança da classe Controller
{
    public IActionResult Index() 
// IActionResult = Tipo de retorno da ação
// Index() = Método responsável pela página inicial    
    {
        var produtos = new List<Produto>
        {
            new Produto
            {
                Id=1,
                Nome="Teclado",
                Preco=129.90m,
                Estoque=15
            },
            new Produto
            {
                Id=2,
                Nome="Mouse",
                Preco=59.90m,
                Estoque=10
            },
            new Produto
            {
                Id=3,
                Nome="Monitor",
                Preco=889.90m,
                Estoque=6
            }
        };
        //return Content("Página de produtos"); // Content = Retorna conteúdo textual
        return View(produtos);
    }
}
