using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pamtec.Datos
{
    public sealed class SingletonConecction
    {
        private static readonly SingletonConecction DBInstance=  new SingletonConecction();
        private readonly SqlConnection con = new SqlConnection("data source=SQLMASTER; initial catalog=ProyectoDisenno;user id=sa;password=Solaris2012");
         //private readonly SqlConnection con = new SqlConnection("Data Source=SQL5011.Smarterasp.net;Initial Catalog=DB_9B17EE_Proyecto;User Id=DB_9B17EE_Proyecto_admin;Password=Majo2907");

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
            //if(con.State = ConnectionState.Open())
            return con;
        }


    }
}