using System.Collections.Generic;
using TrabalhoG1.Models;

namespace TrabalhoG1.Models
{
    public interface IContaLuzRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}