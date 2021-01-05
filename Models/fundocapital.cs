using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cligao.Api.ControllerS;

namespace cligao.Api.models

{
    
    public class fundocapital{
        public fundocapital()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get;  }
        public string Nome { get; set;  }
        public decimal ValorNecessario { get; set; }
        public decimal ValorAtual { get; set; }
        public DateTime? DataResgate { get; set; }

    }
}