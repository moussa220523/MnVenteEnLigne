﻿/*using EhodBoutiqueEnLigne.Models.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace EhodBoutiqueEnLigne.Tests
    {
    public class ProductServiceTests
        {
        /// <summary>
        /// Take this test method as a template to write your test method.
        /// A test method must check if a definite method does its job:
        /// returns an expected value from a particular set of parameters
        /// </summary>
        [Fact]
        public void ExampleMethod()
            {
            // Arrange

            // Act


            // Assert
            Assert.Equal(1, 1);
            }

        // TODO write test methods to ensure a correct coverage of all possibilities
        }

    }*/

/*using EhodBoutiqueEnLigne.Models;
using EhodBoutiqueEnLigne.Models.Repositories;
using EhodBoutiqueEnLigne.Models.Services;
using EhodBoutiqueEnLigne.Models.ViewModels;
using Microsoft.Extensions.Localization;
using Moq;
using System;
using Xunit;

namespace EhodBoutiqueEnLigne.Tests
{
    public class ProductServiceTests
    {
        private readonly Mock<ICart> _mockCart;
        private readonly Mock<IProductRepository> _mockProductRepository;
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly Mock<IStringLocalizer<ProductService>> _mockLocalizer;
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _mockCart = new Mock<ICart>();
            _mockProductRepository = new Mock<IProductRepository>();
            _mockOrderRepository = new Mock<IOrderRepository>();
            _mockLocalizer = new Mock<IStringLocalizer<ProductService>>();
            _mockLocalizer.Setup(l => l["MissingName"]).Returns(new LocalizedString("MissingName", "MissingName"));
            _mockLocalizer.Setup(l => l["MissingPrice"]).Returns(new LocalizedString("MissingPrice", "MissingPrice"));
            _mockLocalizer.Setup(l => l["PriceNotANumber"]).Returns(new LocalizedString("PriceNotANumber", "PriceNotANumber"));
            _mockLocalizer.Setup(l => l["PriceNotGreaterThanZero"]).Returns(new LocalizedString("PriceNotGreaterThanZero", "PriceNotGreaterThanZero"));
            _mockLocalizer.Setup(l => l["MissingQuantity"]).Returns(new LocalizedString("MissingQuantity", "MissingQuantity"));
            _mockLocalizer.Setup(l => l["StockNotAnInteger"]).Returns(new LocalizedString("StockNotAnInteger", "StockNotAnInteger"));
            _mockLocalizer.Setup(l => l["StockNotGreaterThanZero"]).Returns(new LocalizedString("StockNotGreaterThanZero", "StockNotGreaterThanZero"));

            _productService = new ProductService(_mockCart.Object, _mockProductRepository.Object, _mockOrderRepository.Object, _mockLocalizer.Object);
        }
        [Fact]
        public void GetAllProductsViewModel_ShouldReturnValidList()
        {
            // Arrange
          

            // Act
      /*      var result = _productService.GetAllProductsViewModel();

            // Assert
        //    Assert.NotNull(result);
         //   Assert.NotEmpty(result);
            // Ajoutez des assertions supplémentaires pour vérifier le contenu de la liste résultante si nécessaire
        }*/


/*  [Fact]
  public void SaveProduct_ShouldNotThrowException()
  {
      // Arrange
    //  var productViewModel = new ProductViewModel
      {
          Name = "Test Product",
          Description = "Test Description",
          Price = "10.99",
          Stock = "5"
      };*/


//act
// Action act = () => _productService.SaveProduct(productViewModel);
//assert
//ArgumentException exception = Assert.Throws<ArgumentException>(act);
// Assert.Equal("", exception.Message);
// Assert.Throws<Exception>(() => _productService.SaveProduct(productViewModel));

// }

//[Fact]
//public void SaveProduct_MissingName_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = " ",
//        Description = "Test Description",
//        Price = "10",
//        Stock = "5"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("MissingName", modelErrors);            
//}
//[Fact]
//public void SaveProduct_PriceNotGreaterThanZero_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//        Price = "-3",
//        Stock = "5"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("PriceNotGreaterThanZero", modelErrors);
//}
//[Fact]
//public void SaveProduct_StockNotGreaterThanZero_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//        Price = "2",
//        Stock = "-3"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("StockNotGreaterThanZero", modelErrors);
//}

//[Fact]
//public void SaveProduct_MissingPrice_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//        Price = null,
//        Stock = "5"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("MissingPrice", modelErrors);
//}

//[Fact]
//public void SaveProduct_PriceNotANumber_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//       Price = "string",
//        Stock = 5
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("PriceNotANumber", modelErrors);
//}


//[Fact]
//public void SaveProduct_MissingQuantity_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//        Price = 3,
//       // Stock = "5"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("MissingQuantity", modelErrors);
//}
//[Fact]
//public void SaveProduct_StockNotAnInteger_ShouldReturnErrorMessage()
//{
//    // Arrange
//    var productViewModel = new ProductViewModel
//    {
//        Name = "product_name",
//        Description = "Test Description",
//        Price = 3,
//        Stock = "string"
//    };

//    // Act
//    _productService.SaveProduct(productViewModel);
//    var modelErrors = _productService.CheckProductModelErrors(productViewModel);

//    // Assert
//    Assert.Contains("PriceNotGreaterThanZero", modelErrors);
//}

//    }
//
//}

using EhodBoutiqueEnLigne.Models;
using EhodBoutiqueEnLigne.Models.Repositories;
using EhodBoutiqueEnLigne.Models.Services;
using EhodBoutiqueEnLigne.Models.ViewModels;
using Microsoft.Extensions.Localization;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace EhodBoutiqueEnLigne.Tests
{
    public class ProductServiceTests
    {
        private readonly Mock<ICart> _mockCart;
        private readonly Mock<IProductRepository> _mockProductRepository;
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly Mock<IStringLocalizer<ProductService>> _mockLocalizer;
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _mockCart = new Mock<ICart>();
            _mockProductRepository = new Mock<IProductRepository>();
            _mockOrderRepository = new Mock<IOrderRepository>();
            _mockLocalizer = new Mock<IStringLocalizer<ProductService>>();
            _mockLocalizer.Setup(l => l["MissingName"]).Returns(new LocalizedString("MissingName", "MissingName"));
            _mockLocalizer.Setup(l => l["MissingQuantity"]).Returns(new LocalizedString("MissingQuantity", "MissingQuantity"));
            _mockLocalizer.Setup(l => l["MissingPrice"]).Returns(new LocalizedString("MissingPrice", "MissingPrice"));
            _mockLocalizer.Setup(l => l["PriceNotANumber"]).Returns(new LocalizedString("PriceNotANumber", "PriceNotANumber"));
            _mockLocalizer.Setup(l => l["PriceNotGreaterThanZero"]).Returns(new LocalizedString("PriceNotGreaterThanZero", "PriceNotGreaterThanZero"));
            _mockLocalizer.Setup(l => l["StockNotGreaterThanZero"]).Returns(new LocalizedString("StockNotGreaterThanZero", "StockNotGreaterThanZero"));
            _mockLocalizer.Setup(l => l["StockNotAnInteger"]).Returns(new LocalizedString("StockNotAnInteger", "StockNotAnInteger"));

            _productService = new ProductService(_mockCart.Object, _mockProductRepository.Object, _mockOrderRepository.Object, _mockLocalizer.Object);
        }

        [Fact]
        public void SaveProduct_AllFieldsFilled_ShouldNotReturnErrorMessages()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Product",
                Description = "Test Description",
                Price = "10,99",
                Stock = "5"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Empty(modelErrors);
        }

        [Fact]
        public void SaveProduct_MissingName_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "",
                Description = "Test Description",
                Price = "10,99",
                Stock = "5"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("MissingName", modelErrors);
        }

        [Fact]
        public void SaveProduct_MissingStock_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name",
                Description = "Test Description",
                Price = "10,99",
                Stock = ""
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("MissingQuantity", modelErrors);
        }

        [Fact]
        public void SaveProduct_StockNotAnInteger_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name ",
                Description = "Test Description",
                Price = "10.99",
                Stock = "1.3"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("StockNotAnInteger", modelErrors);
        }

        [Fact]
        public void SaveProduct_StockNotGreaterThanZero_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name ",
                Description = "Test Description",
                Price = "10.99",
                Stock = "-1"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("StockNotGreaterThanZero", modelErrors);
        }

        [Fact]
        public void SaveProduct_MissingPrice_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name ",
                Description = "Test Description",
                Price = "",
                Stock = "1"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("MissingPrice", modelErrors);
        }

        [Fact]
        public void SaveProduct_PriceNotANumber_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name ",
                Description = "Test Description",
                Price = "a",
                Stock = "1"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("PriceNotANumber", modelErrors);
        }

        [Fact]
        public void SaveProduct_PriceNotGreaterThanZero_ShouldReturnErrorMessage()
        {
            // Arrange
            var productViewModel = new ProductViewModel
            {
                Name = "Test Name ",
                Description = "Test Description",
                Price = "0",
                Stock = "1"
            };

            // Act
            _productService.SaveProduct(productViewModel);
            var modelErrors = _productService.CheckProductModelErrors(productViewModel);

            // Assert
            Assert.Contains("PriceNotGreaterThanZero", modelErrors);
        }


    }
}

