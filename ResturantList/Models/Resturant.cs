namespace ResturantList.Models
{
    public class Resturant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageURL { get; set; }
        public string Address { get; set; }
        public List<ResturantDish>? ResturantDishes { get; set; }
    }
}
