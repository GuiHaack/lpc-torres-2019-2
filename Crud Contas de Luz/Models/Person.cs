namespace aula06CrudPeople.Models
{
    public class Person
    {
        public Person (){}
        public Person(int id, string dataLeitura, string NumLeitura, string kwGasto, string valorPagar, string dataPagamento, string mediaConsumo)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.NumLeitura = NumLeitura;
            this.kwGasto = kwGasto;
            this.valorPagar = valorPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;

        }
        public int id { get; set; }
        public string dataLeitura { get; set; }
        public string NumLeitura { get; set; }
        public string kwGasto { get; set; }
        public string valorPagar { get; set; }
        public string dataPagamento { get; set; }
        public string mediaConsumo { get; set; }
        
        
    }
}