using cligao.Api.models;
using System.Collections.Generic;
using System;

namespace cligao.api.Repositories
{
    public interface IFundoCapitalRepository
    {
      void Adicionar (fundocapital fundo);  

      void Alterar (fundocapital fundo); 

      IEnumerable<fundocapital> ListarFundos(); 

      fundocapital ObterPorId (Guid id);

      void RemoverFundo (fundocapital fundo); 
    }
}