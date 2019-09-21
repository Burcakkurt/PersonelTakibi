namespace WFAPersonelTakibi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WFAPersonelTakibi.Dal.ProjectContext__>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WFAPersonelTakibi.Dal.ProjectContext__ context)
        {
        }
    }
}
