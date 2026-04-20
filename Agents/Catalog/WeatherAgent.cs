using CSharpMafAgentsAi.Agents.Abstractions;

namespace CSharpMafAgentsAi.Agents.Catalog;

public class WeatherAgent : AgentCreator
{
    protected override string Uri => "http://localhost:11434";
    protected override string Model => "llama3.1:latest";
    protected override string SystemPrompt => @" Voce é um especialista em climas e responderá as perguntas de forma 
                                            direta sobre o clima na cidade desejada pelo usuário, sendo tecnico
                                            porem direto ao ponto.";
}