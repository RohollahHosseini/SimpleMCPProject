namespace SimpleMCPServer;

using MCPSharp;
using System.Threading.Tasks;
internal class Program
{
    static async Task Main(string[] args)
    {
        MCPServer.Register<CalculatorTool>();

       await MCPServer.StartAsync("SimpleMCP Server", "V1.0.0");
    }


    #region Codes

    //static async Task Main(string[] args)
    //{
    //    int port = 25565; // Default Minecraft port
    //    TcpListener listener = new TcpListener(IPAddress.Any, port);
    //    listener.Start();
    //    Console.WriteLine($"MCP Server started on port {port}");
    //    while (true)
    //    {
    //        TcpClient client = await listener.AcceptTcpClientAsync();
    //        _ = HandleClientAsync(client);
    //    }
    //}
    //private static async Task HandleClientAsync(TcpClient client)
    //{
    //    Console.WriteLine("Client connected");
    //    NetworkStream stream = client.GetStream();
    //    byte[] buffer = new byte[1024];
    //    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
    //    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
    //    Console.WriteLine($"Received: {message}");
    //    string response = "Hello from MCP Server!";
    //    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
    //    await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
    //    client.Close();
    //    Console.WriteLine("Client disconnected");
    //}
    #endregion
}

public class CalculatorTool
{
    [McpTool(name:"Addition",description: "This function will add two numbers.")]
    public static int Addition(
        [McpParameter(required:true,Description ="First Number")] int firstNumber,
        [McpParameter(required:true,Description="Second Number")] int secondNumber
        )
    {
        return firstNumber + secondNumber;
    }

}
