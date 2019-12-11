using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.persistence;
using app.domain.Models;

namespace app.persistence
{
    public class MockCapsulesInformationRepository : IRepository<CapsulesInformation>
    {
        private readonly List<CapsulesInformation> _capsulesInformation;

        public MockCapsulesInformationRepository()
        {
            _capsulesInformation = new List<CapsulesInformation>()
            {
				new CapsulesInformation(){ Titre = "Folie contagieuse", Lien = "https://www.youtube.com/watch?v=RJIDLGuqfmc", Status = "published", Texte = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum aliquet justo vitae dictum vestibulum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras condimentum justo eu dolor iaculis pretium. Ut magna diam, gravida sit amet posuere id, semper nec nisi. Suspendisse vitae leo interdum, faucibus leo ac, sagittis nisl. Aenean aliquam ligula erat, et eleifend justo tempus in. Curabitur condimentum rutrum efficitur. Nulla ante enim, aliquam eget posuere eget, fringilla at est. Pellentesque interdum, arcu a lobortis vestibulum, dui est fermentum est, vel fermentum turpis neque eget tortor. Vestibulum blandit eros turpis, non consequat ligula vehicula in. Nullam porttitor metus vel iaculis eleifend. Quisque vel odio id enim tempus varius ut non tellus. Nulla eget maximus sem. Sed aliquam velit quis libero pharetra auctor. Morbi condimentum, lacus nec lobortis faucibus, orci lectus bibendum massa, et pellentesque nisi risus id magna. Morbi at ante faucibus, ullamcorper metus id, volutpat ligula. Vivamus efficitur at neque id varius. Aenean et justo sollicitudin, mattis eros ut, luctus velit. Aliquam erat volutpat. Ut faucibus, velit venenatis pellentesque ornare, diam libero egestas arcu, ac vehicula ex magna sit amet dolor. Cras non aliquam dui. Cras interdum sodales venenatis. Praesent eget porttitor."},
                new CapsulesInformation(){ Titre = "Feu", Lien = "https://www.youtube.com/watch?v=BDpS28vIpsA", Status = "pending", Texte = "lorem ipsum"},
                new CapsulesInformation(){ Titre = "Zombie", Lien = "https://www.youtube.com/watch?v=iSiouayIEAI", Status = "archived", Texte = "lorem ipsum"},
                new CapsulesInformation(){ Titre = "Joker", Lien = "https://www.youtube.com/watch?v=t433PEQGErc", Status = "archived", Texte="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum aliquet justo vitae dictum vestibulum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras condimentum justo eu dolor iaculis pretium. Ut magna diam, gravida sit amet posuere id, semper nec nisi. Suspendisse vitae leo interdum, faucibus leo ac, sagittis nisl. Aenean aliquam ligula erat, et eleifend justo tempus in. Curabitur condimentum rutrum efficitur. Nulla ante enim, aliquam eget posuere eget, fringilla at est. Pellentesque interdum, arcu a lobortis vestibulum, dui est fermentum est, vel fermentum turpis neque eget tortor. Vestibulum blandit eros turpis, non consequat ligula vehicula in. Nullam porttitor metus vel iaculis eleifend. Quisque vel odio id enim tempus varius ut non tellus. Nulla eget maximus sem. Sed aliquam velit quis libero pharetra auctor. Morbi condimentum, lacus nec lobortis faucibus, orci lectus bibendum massa, et pellentesque nisi risus id magna. Morbi at ante faucibus, ullamcorper metus id, volutpat ligula. Vivamus efficitur at neque id varius. Aenean et justo sollicitudin, mattis eros ut, luctus velit. Aliquam erat volutpat. Ut faucibus, velit venenatis pellentesque ornare, diam libero egestas arcu, ac vehicula ex magna sit amet dolor. Cras non aliquam dui. Cras interdum sodales venenatis. Praesent eget porttitor."},
            };

        }

        public async Task Add(CapsulesInformation entity)
        {
            _capsulesInformation.Add(entity);
        }

        public Task Delete(CapsulesInformation entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<CapsulesInformation>> GetAll()
        {
            IQueryable<CapsulesInformation> list = _capsulesInformation.AsQueryable();
            return await Task.Run(() => list);
        }

        public Task<CapsulesInformation> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CapsulesInformation entity)
        {
            throw new NotImplementedException();
        }
    }
}
