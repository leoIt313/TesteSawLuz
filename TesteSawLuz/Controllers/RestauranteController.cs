using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Models;

namespace TesteSawLuz.Controllers
{
    public class RestauranteController : Controller
    {
        public readonly IRestauranteApplication _restauranteApplication;

        public RestauranteController(IRestauranteApplication restauranteApplication)
        {
            _restauranteApplication = restauranteApplication;
        }
        public IActionResult Index()
        {
            return View(new CadastrarEditarRestauranteRequestViewModel());
        }

        public PartialViewResult ListarRestaurantes(string nome)
        {
            return PartialView("_GridRestaurante", _restauranteApplication.Listar(nome).ToList());
        }

        public object CadastrarRestaurante(CadastrarEditarRestauranteRequestViewModel model)
        {
            try
            {
                _restauranteApplication.CadastrarRestaurante(model);

                return new ExecutionResult(StatusCodes.Status200OK, "Cadastro Efetuado com sucesso");
            }
            catch (ArgumentException exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status400BadRequest, exception.Message);
            }
            catch (Exception exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status500InternalServerError, exception.Message);
            }
           
        }

        public object EditarRestaurante(CadastrarEditarRestauranteRequestViewModel model)
        {
            try
            {
                _restauranteApplication.EditarRestaurante(model);

                return new ExecutionResult(StatusCodes.Status200OK, "Registro Alterado com sucesso");
            }
            catch (ArgumentException exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status400BadRequest, exception.Message);
            }
            catch (Exception exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status500InternalServerError, exception.Message);
            }

        }

        public object ExcluirRestaurante(int idrestaurante)
        {
            try
            {
                _restauranteApplication.ExcluirRestaurante(idrestaurante);

                return new ExecutionResult(StatusCodes.Status200OK, "Registro Excluido com sucesso");
            }
            catch (ArgumentException exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status400BadRequest, exception.Message);
            }
            catch (Exception exception)
            {
                this.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return new ExecutionResult(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}