// using System.Net.WebSockets;
// using Syste m.Threading;
using WebSocketServer.Middlware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebSocketManager();
var app = builder.Build();
app.UseWebSockets();
app.UseWebSocketServer();
// app.Use(async (context, next) =>
// {
//     WriteRequestParam(context);
//     if (context.WebSockets.IsWebSocketRequest)
//     {
//         WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
//         Console.WriteLine("WebSocket Connected");

//         await ReceiveMessage( , async (result, buffer) =>
//         {
//             if (result.MessageType == WebSocketMessageType.Text)
//             {
//                 Console.WriteLine("Message received");
//                 return;
//             }
//             else if (result.MessageType == WebSocketMessageType.Close)
//             {
//                 Console.WriteLine("Recived close message");
//                 return;
//             }
//         });
//     }
//     else
//     {
//         Console.WriteLine("2nd request delegate");
//         await next();
//     }
// });

// app.Run(async context =>
// {
//     Console.WriteLine("3rd request delegate");
//     await context.Response.WriteAsync("3rd request delegate");
// });

// void WriteRequestParam(HttpContext context)
// {
//     Console.WriteLine("Request Method:" + context.Request.Method);
//     Console.WriteLine("Request Protocol:" + context.Request.Protocol);

//     if (context.Request.Headers != null)
//     {
//         foreach (var x in context.Request.Headers)
//         {
//             Console.WriteLine("--> " + x.Key + " : " + x.Value);
//         }
//     }
// }

// async Task ReceiveMessage(WebSocket socket, Action<WebSocketReceiveResult, byte[]> handleMessage)
// {
//     var buffer = new byte[1024 * 4];

//     while (socket.State == WebSocketState.Open)
//     {
//         var result = await socket.ReceiveAsync(buffer: new ArraySegment<byte>(buffer),
//             cancellationToken: CancellationToken.None);
//         handleMessage(result, buffer);
//     }
// }

app.Run();