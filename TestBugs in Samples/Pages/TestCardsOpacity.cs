using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;

namespace TestBugs_in_Samples
{
	public class TestCardsOpacity
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<CardsOpacity>();
			Assert.NotNull(componentUnderTest);
		}
	}
}