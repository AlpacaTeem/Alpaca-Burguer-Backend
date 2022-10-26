using Alpaca_Burguer.Application;
using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Alpaca_Burger.Tests
{
    public class ProductHandlersTests
    {
        [Fact]
        public async void Must_Create_New_Product_Successfuly()
        {
            //arrange

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(f => f.Add(It.IsAny<Product>())).ReturnsAsync(GetRandomProduct());
            var mockedHandler = new CreateProductHandler(mockedProductRepository.Object);
            var mockedRequest = new CreateProductRequest() { Product = GetRandomProduct() };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomProduct().Id);
        }

        [Fact]
        public async void Must_Delete_New_Product_Successfuly()
        {
            //arrange

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(f => f.Delete(Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95"))).ReturnsAsync(GetRandomProduct());
            var mockedHandler = new DeleteProductHandler(mockedProductRepository.Object);
            var mockedRequest = new DeleteProductRequest() { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomProduct().Id);
        }

        [Fact]
        public async void Must_Get_Existent_Product_Successfuly()
        {
            //arrange

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(f => f.Get(Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95"))).ReturnsAsync(GetRandomProduct());
            var mockedHandler = new GetProductHandler(mockedProductRepository.Object);
            var mockedRequest = new GetProductRequest() { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomProduct().Id);
        }

        [Fact]
        public async void Must_Get_All_Products_Successfuly()
        {
            //arrange

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(f => f.GetAll()).ReturnsAsync(new List<Product> { GetRandomProduct() });
            var mockedHandler = new GetProductsHandler(mockedProductRepository.Object);
            var mockedRequest = new GetProductsRequest();

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(new List<Product>{ GetRandomProduct() }.Count, result.Count);
            Assert.True(result.FindAll(c => c.Id == Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95")).Count <= 1);
        }

        [Fact]
        public async void Must_Update_Existent_Product_Successfuly()
        {
            //arrange

            var product = GetRandomProduct();

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(f => f.Update(product)).ReturnsAsync(product);
            var mockedHandler = new UpdateProductHandler(mockedProductRepository.Object);
            var mockedRequest = new UpdateProductRequest() { Product = product };

            //act 

            var result = await mockedHandler.Handle(mockedRequest, CancellationToken.None);

            //assert
            Assert.True(result != null);
            Assert.Equal(result.Id, GetRandomProduct().Id);
        }

        public Product GetRandomProduct()
        {
            return new Product(
                name: "RandomName",
                margemDeLucroVisada: 2.45,
                description: "RandomProduct",
                preco: 2.44,
                ingredients: new List<Ingredient>() { new Ingredient("RandomNameIngredient", "RandomDescript", 4.56) })
                { Id = Guid.Parse("807bc76e-bc80-4003-9410-ff697e248b95") };
        }
    }
}
