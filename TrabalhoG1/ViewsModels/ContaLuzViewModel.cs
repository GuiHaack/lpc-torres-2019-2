using TrabalhoG1.Models;
using System.Collections.Generic;

namespace TrabalhoG1.ViewsModels
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(IContaLuzRepository contaLuzRepository)
        {
            this.listaContasLuz = contaLuzRepository.Get();
            this.menorConsumo = contaLuzRepository.GetMenorConsumo();
            this.maiorConsumo = contaLuzRepository.GetMaiorConsumo();
        }

        public IEnumerable<ContaLuz> listaContasLuz { get; set; }
        public ContaLuz menorConsumo { get; set; }
        public ContaLuz maiorConsumo { get; set; }
    }
}