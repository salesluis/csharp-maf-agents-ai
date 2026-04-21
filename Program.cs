using CSharpMafAgentsAi.Agents;

var agent = AgentFactory.GetAgent("generic");
var agentWeather = AgentFactory.GetAgent("weather");
var agentTranslate = AgentFactory.GetAgent("translate");

var session = await agent!.CreateSessionAsync();

while (true)
{
    Console.WriteLine("Faça uma pergunta:");
    var prompt = Console.ReadLine();
    
    // Agente genérico especializado em econimia de tokens
    var genericResult = await agent!.RunAsync(prompt!, session);
    Console.WriteLine(genericResult.Text);
    
    Console.WriteLine("----------------  tradução para ingles  ----------------");
    // Agente especializado em traduzir do pt-br para en
    var translatedResult = await agentTranslate!.RunAsync(genericResult.Text, session);
    Console.WriteLine(translatedResult.Text);
}

