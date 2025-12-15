using MCPSharp;
using MCPSharp.Model;

namespace SimpleMCP.Client;
internal class Program
{
    static async Task Main(string[] args)
    {
        var client = new MCPClient(
            name:"Simple MCP Client ",
            version:"V1.0.0",
            server: "D:\\Projects\\MyProjectsInGitHub\\All Project MCP\\SimpleMCPProject\\SimpleMCPServer\\bin\\Debug\\net9.0\\SimpleMCPServer.exe");

        // for show the available tools in the servers
        //List<Tool> tooles =await client.GetToolsAsync();

        //Console.WriteLine(tooles.Count);
        //Console.WriteLine(tooles.First().Name);
        //Console.WriteLine(tooles.First().Description);

        //Console.Read();

        var result = await client.CallToolAsync(
            name: "Addition",
            parameters: new Dictionary<string, object> 
            {
                {"firstNumber", 10 },
                { "secondNumber", 20 }
            });

        Console.WriteLine(result.Content[0].Text);

        Console.ReadKey();
    }
}