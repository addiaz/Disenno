using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PAMTEC.Seguridad
{
    public sealed class SingletonConecction
    {
        private static readonly SingletonConecction DBInstance=  new SingletonConecction();
        private readonly SqlConnection con = new SqlConnection("data source=SQLMASTER; initial catalog=Disenno;user id=sa;password=Solaris2012");

        static SingletonConecction() { } //Constructor privado

        public static SingletonConecction Instance
        {
            get
            {
                return DBInstance;
            }
        }

        public SqlConnection GetDBConnection()
        {
            return con;
        }


    }
}