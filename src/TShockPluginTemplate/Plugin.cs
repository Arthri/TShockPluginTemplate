using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;

namespace $pluginprefixedname$
{
    [ApiVersion(2, 1)]
    public class $pluginname$ : TerrariaPlugin
    {
        /// <inheritdoc />
        public override string Name => typeof($pluginname$).Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

        /// <inheritdoc />
        public override string Description => typeof($pluginname$).Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        /// <inheritdoc />
        public override Version Version => typeof($pluginname$).Assembly.GetName().Version;

        /// <inheritdoc />
        public override string Author => typeof($pluginname$).Assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public $pluginname$(Main game) : base(game)
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
