using Prodwin.Data.Access;
using System;

namespace WindowsFormsApp1 {

    internal class DbComando {
        private string sql;
        private DbHandler dbh;
        private string v;

        public DbComando(string sql) {
            this.sql = sql;
        }

        public DbComando(DbHandler dbh, string v) {
            this.dbh = dbh;
            this.v = v;
        }

        internal void Execute() {
            throw new NotImplementedException();
        }
    }
}