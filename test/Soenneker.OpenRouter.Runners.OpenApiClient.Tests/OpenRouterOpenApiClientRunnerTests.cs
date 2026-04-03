using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenRouter.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenRouterOpenApiClientRunnerTests : FixturedUnitTest
{
    public OpenRouterOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
