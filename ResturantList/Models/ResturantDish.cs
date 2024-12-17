namespace ResturantList.Models
{
    public class ResturantDish
    {
        public int ResturantId { get; set; }
        public Resturant Resturant { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }

    }
}
