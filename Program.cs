using CSharpMafAgentsAi.Agents;

var agent = AgentFactory.GetAgent("weather");

var prompt = Console.ReadLine();
await foreach(var token in agent!.RunStreamingAsync(prompt!))
        Console.Write(token);

