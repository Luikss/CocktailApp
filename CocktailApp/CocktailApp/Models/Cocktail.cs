namespace Models
{
    public class Cocktail
    {
        public string Name { get; set; }
        public string GlassType { get; set; }
        public string Instructions { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
