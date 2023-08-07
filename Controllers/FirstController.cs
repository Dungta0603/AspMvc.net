using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demo1.Models;

namespace demo1.Controllers;

    public class FirstController : Controller {
        private readonly ILogger <FirstController> _logger;
        private readonly ProductService _productService;

        public FirstController(ILogger<FirstController> logger , ProductService productService){
            _logger = logger;
            _productService = productService;
        } 
        public string Index() {
            // _logger.LogInformation("Indexdcnaskl");  
            // _logger.LogWarning("Indexdcnaskl");
            // _logger.LogDebug("Indexdc");
            // _logger.LogError("Index");
            // _logger.LogCritical("Index");
            // _logger.LogInformation("Index");
                return "nckasnkdjcjkasd";
        }

        public object Anything() => DateTime.Now;
    

    public IActionResult Readme() {
        var content = @"nksdjcnkjsnd
        
        
        jcjksndjc";
        return Content(content, "text/plain");
    }

    // public IActionResult IMG(){
    //     string filePath = Path.Combine(Program.ContentRootPath, "Files","files1.png");
    //     var bytes = System.IO.File.ReadAllBytes(filePath);

    //     return File(bytes,"image/png");
    // }


    public IActionResult Iphens(){
        return Json(
            new {
                productName = "Iphens",
                Price = 1000 
            }
        );
    }

    public IActionResult Privacy(){
        var url1 = Url.Action("Privacy","Home");
        _logger.LogInformation(url1);
        return LocalRedirect(url1);
    }
     public IActionResult Google(){
        var url2 = "https://www.google.com/";
        _logger.LogInformation(url2);
        return Redirect(url2);
    }

    public IActionResult HelloView(){

        return View ("/MyView/xinchao1.cshtml");
    }

    public IActionResult HelloView2 (string username) {
        if(string.IsNullOrEmpty(username))
        username = "kaccccj";

        return View ("/MyView/xinchao2.cshtml", username);
    }

    public IActionResult viewProduct (int? id) {

        var product = _productService.where(p => p.id == id).FirstOrDefault();
        if(product == null)
        return noFound();
        return Content($"san pham Id ={id}");
    }

    }