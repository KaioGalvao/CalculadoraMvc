using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult Operacao([FromForm] string operacao, [FromForm] double n1, [FromForm] double n2)
    {
        if(operacao == "Soma"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 + n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "+";

            return View();
        }

        if(operacao == "Subtração"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 - n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "-";

            return View();
        }

        if(operacao == "Multiplicação"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 * n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "*";

            return View();
        }

        if(operacao == "Divisão"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 / n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "/";

            return View();
        }

        return View();
    }
}
