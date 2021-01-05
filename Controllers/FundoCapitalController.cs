using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using cligao.Api.models;
using System;
using cligao.api.Repositories;

namespace cligao.Api.ControllerS
{
    

    public class FundoCapitalController: Controller
  {     
      private readonly IFundoCapitalRepository _repositorio;

public FundoCapitalController(IFundoCapitalRepository repositorio)
{
_repositorio = repositorio;
}

      [HttpGet("zap")]
      public IActionResult ListarFundos()
      {

          return Ok(_repositorio.ListarFundos());
          }
      
    
    
    
    
      [HttpPut("zap")]
    public IActionResult AlterarFundo(Guid id, [FromBody]fundocapital fundo)
    {
        var fundoantigo = _repositorio.obterporid(id);

        if (fundoantigo == null){
            return notfound();
        }
        fundoantigo.Nome = fundo.Nome;
        fundoantigo.ValorAtual = fundo.ValorAtual;
        fundoantigo.ValorNecessario = fundo.ValorNecessario;
        _repositorio.Alterar (fundoantigo);
        return Ok();
    }
    
    
   [HttpPost("zap")]
    public IActionResult AdicionarFundos([FromBody]fundocapital fundo){
        _repositorio.Adicionar(Fundo);
        return Ok();
    }

 [HttpGet("zap/{id}")]
    public IActionResult ObterFundos(Guid id, [FromBody]fundocapital fundo){
     var fundoantigo = _repositorio.ObterPorId(id);

        if (fundoantigo == null){
            return NotFound();
        }
 
        
        return Ok(fundoantigo);
    }
              
    
       
       [HttpDelete("zap/{id}")]
    public IActionResult RemoverFundos(Guid id, [FromBody]fundocapital fundo){
             var fundoantigo = _repositorio.ObterPorId(id);

        if (fundoantigo == null){
            return NotFound();
        }
 
        _repositorio.RemoverFundo(fundo);
        return Ok(fundoantigo);
    }
    }
   
                    }

