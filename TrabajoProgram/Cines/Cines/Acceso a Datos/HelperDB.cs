using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaCineBack.Acceso_a_Datos.Parametros;
using Cines.Clases.Cines;

namespace SistemaCineBack.Acceso_a_Datos
{
    class HelperDB
    {
        
        private static HelperDB instancia;
        private SqlConnection cnn = new SqlConnection("");
        public static HelperDB obtenerInstancia()
        {
            if(instancia == null)
                instancia = new HelperDB();
            return instancia;           
        }
        public DataTable consultar(string sp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool ejecutarSql(string spMaestro, string spDetalle, Funciones funciones)
        {
            bool aux = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spMaestro, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("",);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                int id = (int)param.Value;           
                   
            }
            catch (Exception)
            {
                aux = false;
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            t.Commit();
            return aux;
        }
        public int obtenerProximoId()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }
    }
}
