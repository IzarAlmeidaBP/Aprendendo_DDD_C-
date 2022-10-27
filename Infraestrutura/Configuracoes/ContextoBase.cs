using Entidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuracoes
{
    public class ContextoBase : DbContext
    {
        public ContextoBase(DbContextOptions<ContextoBase> options) : base(options)
        {

        }
         
        
          public DbSet<Produto> Produto { get; set; }

        protected override void GetV(DbContextOptions optionsBuilder)
        {
            return base.OnConfiguring(optionsBuilder);
        }

        protected override void OnConfiguring(DbContextOptions optionsBuilder, void v)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(string.Empty);
                v;
            }
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-SKQHBNC;Initial Catalog=Ecommecer_API;Persist Security Info=True;User ID=sa;Password=********";
            return strCon;
        }
    }
}
