using Microsoft.AspNetCore.Components.Web;

namespace _6325048_Jérémie_Doricent_TP2.Models
{

    public class Enfant
    {


        public int Id { get; set; }
        public string Nom { get; set; }
      
        public double PointsParMatch { get; set; }
        public double Passes { get; set; }
        public double Rebonds { get; set; }

        public bool estjoueur { get; set; }

        public int IdParent { get; set; }
        public Parent Parent { get; set; }
        public Enfant() { } 

       

    
            

        
    }
}
