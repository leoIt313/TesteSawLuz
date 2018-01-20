using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteSawLuz.Application.ViewModel.Request;
using TesteSawLuz.Application.Interfaces;
using TesteSawLuz.Models;

namespace TesteSawLuz.Controllers
{
    public class PratoController : Controller
    {
        public readonly IRestauranteApplication _restauranteApplication;
        public readonly IPratoApplication _pratoApplication;

        public PratoController(IRestauranteApplication restauranteApplication, IPratoApplication pratoApplication)
        {
            _restauranteApplication = restauranteApplication;
            _pratoApplication = pratoApplication;
        }

        public IActionResult Index()
        {
            return View(new CadastrarEditarPratosResquestViewModel
            {
                ItemLancheViewModel = _restauranteApplication.Listar(string.Empty).Select(x => new ItemRestauranteViewModel
                {
                    IdRestaurante = x.IdRestaurante,
                    NomeRestaurante = x.NomeRestaurante
                }).ToList()
            });
        }

        public PartialViewResult ListarPratos()
        {
            return PartialView("_GridPratos", _pratoApplication.Listar().ToList());
        }

        public object CadastrarPrato(CadastrarEditarPratosResquestViewModel model)
        {
            try
            {
                _pratoApplication.CadastrarPratos(model);

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

        public object EditarPrato(CadastrarEditarPratosResquestViewModel model)
        {
            try
            {
                _pratoApplication.EditarPratos(model);

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

        public object ExcluirPrato(int idPrato)
        {
            try
            {
                _pratoApplication.ExcluirPratos(idPrato);

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