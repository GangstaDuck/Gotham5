using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.domain;

namespace app.persistence
{
    public class MockNewsRepository : IRepository<domain.News>
    {
        private readonly List<domain.News> _news;
        public MockNewsRepository()
        {
            _news = new List<domain.News>()
            {
                new domain.News()
                {
                    Title = "Les framboises sont de retours!",
                    Text = "Les fermes Onésimes Pouliot produisent les meilleurs fraises, framboises et bleuets de l'île d'Orléan.",
                    Link = "https://onesimepouliot.com/",
                    Status = "Non publié"
                },
                new domain.News()
                {
                    Title = "Le retour du Jeep Pick-up",
                    Text = "Le Jeep Gladiator était attendu depuis longtemps. Il est maintenant de retour au Canada.",
                    Link = "https://www.guideautoweb.com/articles/53419/face-a-face-le-jeep-gladiator-2020-mis-a-l-essai/",
                    Status = "Non publié"
                },
                new domain.News()
                {
                    Title = "Nouvelle instinction en approche?",
                    Text = "Notre planète est sujet aux impacts de météorites. Mais lesquels vont réellement nous frapper? Nous ne le savon pas.",
                    Link = "https://www.notre-planete.info/terre/fin_du_monde/risque-collision-asteroide-Terre.php?nd=10",
                    Status = "Non publié"
                }
            };
        }
        public Task Add(domain.News entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(domain.News entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<domain.News>> GetAll()
        {
            IQueryable<domain.News> list = _news.AsQueryable();
            return await Task.Run(() => list);
        }

        public Task<domain.News> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(domain.News entity)
        {
            throw new NotImplementedException();
        }
    }
}
