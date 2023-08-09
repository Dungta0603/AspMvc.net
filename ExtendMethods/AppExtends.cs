// using System.net;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Http;
// namespace demo1.ExtendMethods {
//     public static class AppExtend
//     {
//         public static class AppStatusCodePage ( this IApplicationBuilder app){
//              app.UseStatusCodePages(appError => {
//                 appError.Run(async () => {
//                     var respone = context.Response;
//                     var code = respone.StartupCode;

//                     var context = @$"<html>
//                     <head>
//                     <meta charset='UTF-8'/>
//                     <title>Looi {code}</title>
//                     <body>
//                         <p>Looi {code} - {(HttpStatusCode)code}</p>
//                     </body>
//                     </head>
//                     </html>";
//                     await respone.WriteAsync(context);
//                 });
//             });
//         }
//     }
//     }