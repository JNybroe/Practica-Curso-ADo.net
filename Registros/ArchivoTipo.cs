﻿using Discos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros
{
    public class ArchivoTipo
    {
        public List<Estilo> listar()
        {
            List<Estilo> lista = new List<Estilo>();
            LecturaRegistros lector = new LecturaRegistros("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            try
            {
                lector.setConsulta("select Id, Descripcion from TIPOSEDICION");
                lector.realizarConsulta();

                while (lector.Lector.Read())
                {
                    Estilo aux = new Estilo();
                    aux.Id = lector.Lector.GetInt32(0);
                    aux.Description = (string)lector.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lector.cerrarConexion();
            }

        }
    }
}
