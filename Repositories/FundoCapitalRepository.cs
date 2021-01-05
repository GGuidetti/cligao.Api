using cligao.Api.models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace cligao.api.Repositories
{
    

    public class FundoCapitalRepository : IFundoCapitalRepository
    {
        private readonly List<fundocapital> _storage;

     public FundoCapitalRepository ()
{
    _storage = new List<fundocapital>();
}

    public void Adicionar (fundocapital fundo)  {
   _storage.Add(fundo);
}

    public void Alterar (fundocapital fundo) {
    var index = _storage.FindIndex(0, 1, x => x.id == fundo.id);
    _storage[index] = fundo;
}

    public IEnumerable<fundocapital> ListarFundos() {
    return _storage;
}
    public fundocapital ObterPorId (Guid id){
    return _storage.firstordefault(x => x.id == id);
}
    public void RemoverFundo (fundocapital fundo) {
    _storage.Remove(fundo);
    }
}}