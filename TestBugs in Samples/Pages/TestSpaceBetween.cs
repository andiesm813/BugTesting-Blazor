using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;

namespace TestBugs_in_Samples
{
	public class TestSpaceBetween
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbBadgeModule));
			var componentUnderTest = ctx.RenderComponent<SpaceBetween>();
			Assert.NotNull(componentUnderTest);
		}
	}
}