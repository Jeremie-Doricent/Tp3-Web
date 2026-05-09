namespace _6325048_Jérémie_Doricent_TP2.Models
{
    
    public class Parent
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string ImageURL { get; set; }
        public List<Enfant> Enfant { get; set; }
        
        public string description { get; set; }
    }
}
