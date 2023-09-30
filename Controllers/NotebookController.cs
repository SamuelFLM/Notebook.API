using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_test.Entities;
using Api_test.Models;
using Api_test.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Api_test.Controllers
{
    [Route("v1/notebook")]
    [ApiController]
    public class NotebookController : ControllerBase
    {
        private readonly NotebookContext _context;
        public NotebookController(NotebookContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Obter todos notebooks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var dados = _context.Notebooks;
            return Ok(dados);
        }
        /// <summary>
        /// Obter notebook por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var notebookId = _context.Notebooks.SingleOrDefault(x => x.Id == id);
            if (notebookId == null)
                return NotFound();
            return Ok(notebookId);
        }
        /// <summary>
        /// Cadastrar notebook
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(AddNotebook model)
        {
            Notebook notebook = new Notebook(
                model.Marca,
                model.Modelo,
                model.Ano,
                model.Preco
            );

            if (notebook.Marca.Length > 30)
                return BadRequest();

            if (notebook.Modelo.Length > 150)
                return BadRequest();

            _context.Add(notebook);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = notebook.Id }, notebook);

        }
        /// <summary>
        /// Alterar cadastro de notebook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateNotebook model)
        {
            var notebook = _context.Notebooks.SingleOrDefault(x => x.Id == id);

            if (notebook == null)
                return NotFound();

            notebook.Update(model.Marca, model.Modelo, model.Ano, model.Preco);

            _context.Update(notebook);

            _context.SaveChanges();

            return NoContent();
        }
        /// <summary>
        /// Deletar cadastro de notbook
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){

            var notebook = _context.Notebooks.SingleOrDefault(x => x.Id == id);

            if (notebook == null)
                return NotFound();

            _context.Remove(notebook);

            _context.SaveChanges();

            return NoContent();
        }
    }
}