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
        //private readonly List<domain.News> _news;
        public List<domain.News> _news { get; set; }

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
            domain.News newNew = entity;
            _news.Add(newNew);
            return GetAll();
        }

        public Task Delete(domain.News entity)
        {
            foreach (domain.News news in _news)
            {
                if (news.Id == entity.Id)
                {
                    _news.Remove(entity);
                    return GetAll();
                }
                return GetAll();
            }
            return GetAll();
        }

        public async Task<IQueryable<domain.News>> GetAll()
        {
            IQueryable<domain.News> list = _news.AsQueryable();
            return await Task.Run(() => list);
        }

        public Task<domain.News> GetById(int? id)
        {
            foreach (domain.News news in _news)
            {
                if(news.Id == id)
                {
                    return Task.FromResult(news);
                }
                return null;
            }
            return null;
        }

        public Task Update(domain.News entity)
        {
            foreach (domain.News news in _news)
            {
                if (news.Id == entity.Id)
                {
                    news.Title = entity.Title;
                    news.Text = entity.Text;
                    news.Link = entity.Link;
                    news.Status = entity.Link;
                    return GetAll();
                }
                return GetAll();
            }
            return GetAll();
        }

    }
}
