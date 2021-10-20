using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;

namespace $safeprojectname$
{
    [ApiVersion(2, 1)]
    public class Plugin : TerrariaPlugin
    {
        /// <inheritdoc />
        public override string Name => typeof(Plugin).Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

        /// <inheritdoc />
        public override string Description => typeof(Plugin).Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        /// <inheritdoc />
        public override Version Version => typeof(Plugin).Assembly.GetName().Version;

        /// <inheritdoc />
        public override string Author => typeof(Plugin).Assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public Plugin(Main game) : base(game)
        {
        }

        /// <inheritdoc />
        public override void Initialize()
        {
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
