using System.Diagnostics.Metrics;
using testComponentes.Data;
using Bunit;
using BlazorApp1.Components.Pages;

namespace testComponentes;

public class Tests
{
    [Test]
    public async Task Basic()
    {
        Console.WriteLine("This is a basic test");
        var bunitctx = new Bunit.TestContext();
        var componente = bunitctx.RenderComponent<Counter>();
        componente.Find("button").Click();
        var resultado = componente.Find("p[role='status']");
        await TUnit.Assertions.Assert.That(resultado.TextContent).Contains("Current count: 1");
    }

   



}
