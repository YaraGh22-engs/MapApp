namespace GoogleMapApp.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double longitude { get; set; }
        public double latitude { get; set; }
    }
}
