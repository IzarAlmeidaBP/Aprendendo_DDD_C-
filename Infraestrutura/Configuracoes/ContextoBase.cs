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

     

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
              
            }
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-SKQHBNC;Initial Catalog=Ecommecer_API;Persist Security Info=True;User ID=sa;Password=Izar0109";
            return strCon;
        }
    }
}
