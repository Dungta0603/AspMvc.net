using System.Collections.Generic;
using App.Models;

namespace demo1.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService() { 
            this.AssRange(new ProductModel[]{
                new ProductModel() {Id= 1, Name="iphone5 " , Price = "120000"},
                new ProductModel() {Id= 1, Name="iphone4 " , Price = "130000"},
                new ProductModel() {Id= 1, Name="iphone3 " , Price = "1045000"},
                new ProductModel() {Id= 1, Name="iphone2 " , Price = "1055000"},
            });
        } 
    }
}