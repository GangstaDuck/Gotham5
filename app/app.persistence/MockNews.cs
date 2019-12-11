
using System.Collections.Generic;

namespace app.persistence
{
    public class MockNews
    {
        public List<domain.News> news { get; set; }

        public domain.News news1 = new domain.News()
        {
            Title = "Les framboises sont de retours!",
            Text = "Les fermes Onésimes Pouliot produisent les meilleurs fraises, framboises et bleuets de l'île d'Orléan.",
            Link = "https://onesimepouliot.com/",
            Status = "Non publié"
        };

        public domain.News news2 = new domain.News()
        {
            Title = "Le retour du Jeep Pick-up",
            Text = "Le Jeep Gladiator était attendu depuis longtemps. Il est maintenant de retour au Canada.",
            Link = "https://www.guideautoweb.com/articles/53419/face-a-face-le-jeep-gladiator-2020-mis-a-l-essai/",
            Status = "Non publié"
        };

        public domain.News news3 = new domain.News()
        {
            Title = "Nouvelle instinction en approche?",
            Text = "Notre planète est sujet aux impacts de météorites. Mais lesquels vont réellement nous frapper? Nous ne le savon pas.",
            Link = "https://www.notre-planete.info/terre/fin_du_monde/risque-collision-asteroide-Terre.php?nd=10",
            Status = "Non publié"
        };
    }
}
