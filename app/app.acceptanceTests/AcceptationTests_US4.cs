using app.persistence;
using app.web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestStack.BDDfy;
using Xunit;

namespace app.unitTests
{
    [Story(
            Title = "Je veux pouvoir voir les infos d'une capsule",
            AsA = "User général",
            IWant = "Je veux les infos d'une capsule,",
            SoThat = "Afin de pouvoir prendre connaissance d'une capsule")]

    public class NewsTestsAcceptation
    {
        public domain.Models.CapsulesInformation capsule = new domain.Models.CapsulesInformation();
        public MockCapsulesInformationRepository mockRepo;
        public CapsulesInformationsController controller;
        public IActionResult result;

        [Fact]
        public void visualiser_les_infos_d_une_news()
        {
            this.Given(x => une_capsule())
                .When(x => l_user_demande_de_voir_la_liste_des_capsules())
                .Then(x => les_infos_d_une_capsule())
                .BDDfy();
        }

        private void une_capsule()
        {
            capsule.Titre = "Folie contagieuse";
            capsule.Texte = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum aliquet justo vitae dictum vestibulum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Cras condimentum justo eu dolor iaculis pretium.Ut magna diam, gravida sit amet posuere id, semper nec nisi.Suspendisse vitae leo interdum, faucibus leo ac, sagittis nisl.Aenean aliquam ligula erat, et eleifend justo tempus in. Curabitur condimentum rutrum efficitur. Nulla ante enim, aliquam eget posuere eget, fringilla at est. Pellentesque interdum, arcu a lobortis vestibulum, dui est fermentum est, vel fermentum turpis neque eget tortor.Vestibulum blandit eros turpis, non consequat ligula vehicula in. Nullam porttitor metus vel iaculis eleifend. Quisque vel odio id enim tempus varius ut non tellus. Nulla eget maximus sem. Sed aliquam velit quis libero pharetra auctor.Morbi condimentum, lacus nec lobortis faucibus, orci lectus bibendum massa, et pellentesque nisi risus id magna.Morbi at ante faucibus, ullamcorper metus id, volutpat ligula.Vivamus efficitur at neque id varius. Aenean et justo sollicitudin, mattis eros ut, luctus velit.Aliquam erat volutpat.Ut faucibus, velit venenatis pellentesque ornare, diam libero egestas arcu, ac vehicula ex magna sit amet dolor. Cras non aliquam dui. Cras interdum sodales venenatis. Praesent eget porttitor.";
            capsule.Lien = "https://www.youtube.com/watch?v=RJIDLGuqfmc";
            capsule.Status = "published";
        }

        private async Task l_user_demande_de_voir_la_liste_des_capsules()
        {
            // Arrange
            mockRepo = new MockCapsulesInformationRepository();
            controller = new CapsulesInformationsController(mockRepo);

            // Act
            result = await controller.Index();
        }

        private async void les_infos_d_une_capsule()
        {
            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}