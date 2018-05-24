using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula2205_Entity.Models.DAL
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {
            //DropCrateDatabaseAlways

            //DropCreateDatabaseIfModelChanges

            //Migrations (para produção)


            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

    }
}