using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;
using Bugs_in_Samples.TravelApp;

namespace TestBugs_in_Samples
{
	public class TestCardActions
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new TravelAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<CardActions>();
			Assert.NotNull(componentUnderTest);
		}
	}
}