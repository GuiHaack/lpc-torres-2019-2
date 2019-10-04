using System;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoG1.Models
{
    public class ContaLuz : BaseEntity
    {
        public ContaLuz() { }

        public ContaLuz(int id, DateTime dataLeitura, int kwGasto, double valorAPagar, DateTime dataPagamento, double mediaConsumo)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorAPagar = valorAPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
        }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        public DateTime dataLeitura { get; set; }

        public int kwGasto { get; set; }

        public double valorAPagar { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        public DateTime dataPagamento { get; set; }

        public double mediaConsumo { get; set; }
    }
}