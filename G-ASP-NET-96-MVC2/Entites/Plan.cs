namespace G_ASP_NET_96_MVC2.Entites
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
 
        public string Description { get; set; } = default!;
         
        public int DurationDays { get; set; }
         
        public decimal Price { get; set; }
         
        public bool IsActive { get; set; }
    }
}
