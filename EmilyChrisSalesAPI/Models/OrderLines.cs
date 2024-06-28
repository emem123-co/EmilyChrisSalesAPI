namespace EmilyChrisSalesAPI.Models;



    public class OrderLines 
    
    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        public virtual Order? order { get; set; }
        public virtual Items? items { get; set; }

}


