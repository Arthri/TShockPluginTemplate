using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;

namespace $safeprojectname$
{
    [ApiVersion(2, 1)]
    public class Plugin : TerrariaPlugin
    {
        public override string Name => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public override string Description => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        public override Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public override string Author => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public Plugin(Main game) : base(game)
        {
            Console.WriteLine($"    {Name}  Copyright (C) $year$  {Author}");
            Console.WriteLine($"    This program comes with ABSOLUTELY NO WARRANTY; see {Name}.COPYING for details");
            Console.WriteLine($"    This is free software, and you are welcome to redistribute it");
            Console.WriteLine($"    under certain conditions; see {Name}.COPYING for details.");
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
