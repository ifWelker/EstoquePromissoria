namespace ProjetoEstoquePromissoria.Models
{
    public class PromissoriasModel
    {
        public int id {  get; set; } // Int da tabela

        public string cliente { get; set; } // Nome do Cliente

        public  string produto { get; set; } // Produto da Promissoria

        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now; // data inicial da promissoria

    }
}
