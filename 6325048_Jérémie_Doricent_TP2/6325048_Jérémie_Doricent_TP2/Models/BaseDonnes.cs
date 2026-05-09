using System;
using System.Collections.Generic;
using System.Linq;  
namespace _6325048_Jérémie_Doricent_TP2.Models
{
    public class BaseDonnes
    {

      
            
            public List<Enfant> enfant { get; set; }
            public List<Parent> parent { get; set; }

            public  BaseDonnes()
            {
                enfant = new List<Enfant>();
                parent = new List<Parent>();

               
                parent.Add(new Parent() { Id = 1, Nom = "Conférence Est"   , description = "La Conférence Ouest de la NBA est reconnue pour son intensité et sa compétitivité. Les équipes qui la composent offrent un style de jeu rapide, physique et stratégique. Chaque saison, la lutte pour les séries éliminatoires est extrêmement serrée, ce qui rend chaque match important. Les joueurs vedettes de l’Ouest se démarquent par leurs performances impressionnantes et leur capacité à changer le cours d’un match à tout moment" });
                parent.Add(new Parent() { Id = 2, Nom = "Conférence Ouest", description = "La Conférence Est regroupe des équipes historiques et emblématiques de la NBA. Elle est reconnue pour ses rivalités classiques et ses matchs intenses. Chaque saison, les formations de l’Est cherchent à s’imposer grâce à un jeu collectif solide et une défense rigoureuse. La conférence continue de produire des talents émergents qui façonnent l’avenir de la ligue." });
                parent.Add(new Parent() { Id = 3, Nom = "best of hall time ", description = "Hall-time\r\nLe Basketball Hall of Fame célèbre les plus grandes légendes de l’histoire du basketball. Il rend hommage aux joueurs, entraîneurs et personnalités qui ont marqué le sport par leur talent et leur contribution exceptionnelle. Être intronisé au Hall of Fame représente l’une des plus grandes reconnaissances qu’un joueur puisse recevoir dans sa carrière." });
                
                enfant.Add(new Enfant() { Id = 1, Nom = "LeBron James",  PointsParMatch = 27.2, Passes = 8.3, Rebonds = 7.5, IdParent = 3  ,estjoueur = true});
                

                
                enfant.Add(new Enfant() { Id = 2, Nom = "Michael Jordan",  PointsParMatch = 30.1, Passes = 5.3, Rebonds = 6.2, IdParent = 3, estjoueur = true });
            enfant.Add(new Enfant() { Id = 3, Nom = "Kareem", PointsParMatch = 15.1, Passes = 4.3, Rebonds = 22.5, IdParent = 3, estjoueur = true });
            enfant.Add(new Enfant() { Id = 4, Nom = "Bill Russell", PointsParMatch = 15.1, Passes = 4.3, Rebonds = 22.5, IdParent = 3, estjoueur = true });
           
            enfant.Add(new Enfant() { Id = 5, Nom = "Wilt", PointsParMatch = 15.1, Passes = 4.3, Rebonds = 22.5, IdParent = 3, estjoueur = true });

            enfant.Add(new Enfant() { Id = 6, Nom = "Magic Johnson", PointsParMatch = 19.5, Passes = 11.2, Rebonds = 7.2, IdParent = 3, estjoueur = true });
                enfant.Add(new Enfant() { Id = 7, Nom = "Larry Bird",  PointsParMatch = 27.7, Passes = 3.4, Rebonds = 8.7, IdParent = 3, estjoueur = true });

               
                enfant.Add(new Enfant() { Id = 9, Nom = "Boston Celtics", PointsParMatch = 120.6, Passes = 27.3, Rebonds = 44.1, IdParent = 1 , estjoueur = false });
                enfant.Add(new Enfant() { Id = 11, Nom = "Cleveland Cavaliers", PointsParMatch = 113.8, Passes = 25.1, Rebonds = 42.7, IdParent = 1 , estjoueur = false });
                enfant.Add(new Enfant() { Id = 10, Nom = "New York Knicks",  PointsParMatch = 111.2, Passes = 23.8, Rebonds = 43.5, IdParent = 1, estjoueur = false });
                enfant.Add(new Enfant() { Id = 8, Nom = "Detroit Pistons", PointsParMatch = 108.4, Passes = 22.6, Rebonds = 41.9, IdParent = 1, estjoueur = false });
                enfant.Add(new Enfant() { Id = 12, Nom = "Toronto Raptors", PointsParMatch = 109.7, Passes = 24.2, Rebonds = 42.3, IdParent = 1, estjoueur = false });
                enfant.Add(new Enfant() { Id = 13, Nom = "Philadelphia 76ers", PointsParMatch = 112.1, Passes = 24.9, Rebonds = 43.8, IdParent = 1, estjoueur = false });
                enfant.Add(new Enfant() { Id = 14, Nom = "Orlando Magic", PointsParMatch = 107.8, Passes = 22.1, Rebonds = 41.6, IdParent = 2, estjoueur = false });

                enfant.Add(new Enfant() { Id =16 , Nom = "Oclama city", PointsParMatch = 114.6, Passes = 28.4, Rebonds = 44.9, IdParent = 2, estjoueur = false });
                enfant.Add(new Enfant() { Id = 18, Nom = "Denver Nuggets",  PointsParMatch = 114.6, Passes = 28.4, Rebonds = 44.9, IdParent = 2, estjoueur = false });
                enfant.Add(new Enfant() { Id = 20, Nom = "Houston Rockets",  PointsParMatch = 110.3, Passes = 25.7, Rebonds = 43.2, IdParent = 2, estjoueur = false });
                enfant.Add(new Enfant() { Id = 19, Nom = "Los Angeles Lakers",  PointsParMatch = 115.9, Passes = 26.8, Rebonds = 44.5, IdParent = 2, estjoueur = false });
             
                enfant.Add(new Enfant() { Id = 17, Nom = "San Antonio Spurs", PointsParMatch = 109.1, Passes = 23.5, Rebonds = 42.8, IdParent = 2, estjoueur = false });
                enfant.Add(new Enfant() { Id = 22, Nom = "Phoenix Suns",  PointsParMatch = 113.4, Passes = 26.1, Rebonds = 43.7, IdParent = 2, estjoueur = false });
                enfant.Add(new Enfant() { Id = 21, Nom = "Minnesota Timberwolves", PointsParMatch = 111.7, Passes = 24.6, Rebonds = 43.1, IdParent = 2, estjoueur = false });

            foreach (var element in parent)
            {
               element.Enfant =new List<Enfant>();
                element.Enfant.AddRange(enfant.Where(x => x.Id == element.Id));
              
                
            }
        
            foreach(var element in enfant)
            {
                element.Parent = parent.Where(p => p.Id == element.IdParent).Single();
            }
        }
        
    }
}
