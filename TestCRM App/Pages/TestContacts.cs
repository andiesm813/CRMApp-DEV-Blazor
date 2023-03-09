using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_App.Pages;

namespace TestCRM_App
{
	public class TestContacts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Contacts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}