//using AutoMoq;
//using System.Threading;
//using Xunit;



//namespace Alpaca_Burger.Tests
//{
//    public class CreateProductTests
//    {
//        [Fact]
//        public async void Must_Create_New_Product_Successfuly()
//        {
//            //arrange
//            var mocker = new AutoMoqer();

//            //var handle = mocker.Create<CreateProductCommandHandler>();

//            //act
//            // var command = new CreateProductCommandRequest();
//            //var result = await handle.Handle(command, new CancellationToken());


//            //assert
//            result.Id.Should().NotBeEmpty();
//            result.Success.Should().BeTrue();
//            result.Messages.FirstOrDefault().Should().Be("O produto Foi Criado com Sucesso.");
//        }
//        [Fact]
//        public async void Should_Return_An_Error_When_Create_Product_Is_Duplicated()
//        {
//            //arrange
//            var mocker = new AutoMoqer();

//            var handle = mocker.Create<CreateProductCommandHandler>();

//            //act
//            var command = new CreateProductCommand();
//            var result = await handle.Handle(command, new CancellationToken());


//            //assert
//            result.Id.Should().NotBeEmpty();
//            result.Success.Should().BeTrue();
//            result.Messages.FirstOrDefault().Should().Be("O produto ja existe.");
//        }
//        [Fact]
//        public async void Must_Not_Create_A_Pathology_With_Empty_Name()
//        {
//            //arrange
//            var mocker = new AutoMoqer();

//            var handle = mocker.Create<CreateProductCommandHandler>();

//            //act
//            var command = new CreateProductCommand();
//            var result = await handle.Handle(command, new CancellationToken());


//            //assert
//            result.Id.Should().NotBeEmpty();
//            result.Success.Should().BeTrue();
//            result.Messages.Should().ContainMatch("O nome não pode ser vazio");
//            result.Success.Should().BeFalse();
//        }


//    }
//}
