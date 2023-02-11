using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Master_Piece.Startup))]
namespace Master_Piece
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
