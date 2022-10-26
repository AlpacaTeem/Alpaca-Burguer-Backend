using Alpaca_Burguer.Application;
using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Alpaca_Burger.Tests
{
    public class IngredientHandlersTests
    {
        [Fact]
        public async void Must_Create_New_Ingredient_Successfuly()
        {
            //arrange

            var mockedIngredientRepository = new Mock<IIngredientRepository>();
            mockedIngredientRepository.Setup(f => f.Add(It.IsAny<Ingredient>())).ReturnsAsync(GetRandomIngredient());
            var mockedHandler = new CreateIngredientHandler(mockedIngredientRepository.Object);
            var mockedRequest = new CreateIngredientRequest() { Ingredient = GetRandomIngredient() };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomIngredient().Id);
        }

        [Fact]
        public async void Must_Delete_New_Ingredient_Successfuly()
        {
            //arrange

            var mockedIngredientRepository = new Mock<IIngredientRepository>();
            mockedIngredientRepository.Setup(f => f.Delete(Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95"))).ReturnsAsync(GetRandomIngredient());
            var mockedHandler = new DeleteIngredientHandler(mockedIngredientRepository.Object);
            var mockedRequest = new DeleteIngredientRequest() { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomIngredient().Id);
        }

        [Fact]
        public async void Must_Get_Existent_Ingredient_Successfuly()
        {
            //arrange

            var mockedIngredientRepository = new Mock<IIngredientRepository>();
            mockedIngredientRepository.Setup(f => f.Get(Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95"))).ReturnsAsync(GetRandomIngredient());
            var mockedHandler = new GetIngredientHandler(mockedIngredientRepository.Object);
            var mockedRequest = new GetIngredientRequest() { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomIngredient().Id);
        }

        [Fact]
        public async void Must_Get_All_Ingredients_Successfuly()
        {
            //arrange

            var mockedIngredientRepository = new Mock<IIngredientRepository>();
            mockedIngredientRepository.Setup(f => f.GetAll()).ReturnsAsync(new List<Ingredient> { GetRandomIngredient() });
            var mockedHandler = new GetAllIngredientsHandler(mockedIngredientRepository.Object);
            var mockedRequest = new GetAllIngredientsRequest();

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(new List<Ingredient> { GetRandomIngredient() }.Count, result.Count);
            Assert.True(result.FindAll(c => c.Id == Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95")).Count <= 1);
        }

        [Fact]
        public async void Must_Update_Existent_Ingredient_Successfuly()
        {
            //arrange
            var product = GetRandomIngredient();

            var mockedIngredientRepository = new Mock<IIngredientRepository>();
            mockedIngredientRepository.Setup(f => f.Update(product)).ReturnsAsync(product);
            var mockedHandler = new UpdateIngredientHandler(mockedIngredientRepository.Object);
            var mockedRequest = new UpdateIngredientRequest() { Ingredient = product };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomIngredient().Id);
        }

        public Ingredient GetRandomIngredient()
        {
            return new Ingredient(
                name: "RandomName",
                description: "RandomDesc",
                preco: 2.45)
                { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };
        }
    }
}
