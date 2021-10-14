using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;

namespace $safeprojectname$
{
    [ApiVersion(2, 1)]
    public class Plugin : TerrariaPlugin
    {
        public override string Name => typeof(Plugin).Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public override string Description => typeof(Plugin).Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        public override Version Version => typeof(Plugin).Assembly.GetExecutingAssembly().GetName().Version;

        public override string Author => typeof(Plugin).Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public Plugin(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
