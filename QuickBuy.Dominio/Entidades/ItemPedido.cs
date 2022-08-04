namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if(PedidoId == 0)
            {
                AdicionarCritica("Crítica: Não foi identificado qual a referência do produto")
            }

            if(Quantidade == 0)
            {
                AdicionarCritica("Crítica: Quantidade não foi informado");
            }
        }
    }
}
