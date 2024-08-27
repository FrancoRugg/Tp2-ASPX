using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2.api.Handlers;
using tp2.models;

namespace tp2.api.Services
{
    public class usuariosService
    {
        public string GetUsers()
        { 
             string json = MysqlHandler.GetJson("select * from usuarios");
            return json;
        }public string GetUsersById(string Id)
        { 
             string query = MysqlHandler.GetJson("select * from usuarios WHERE id ="+Id);
            return query;
        }
        public bool DeleteUser(string Id)
        { 
            return MysqlHandler.Exec($"DELETE from usuarios WHERE id = {Id}");
        }

        public bool PostUser(Usuario usuario)
        {
            if(usuario.Nombre == "" || usuario.Dni == "" || usuario.Email == "")
            {
                return false;
            }
            else
            {
                return MysqlHandler.Exec($"INSERT INTO usuarios VALUES(0,'{usuario.Nombre}','{usuario.Dni}','{usuario.Email}')");
            }
        }public bool UpdateUser(Usuario usuario)
        {
            if(usuario.Nombre == "" || usuario.Dni == "" || usuario.Email == "")
            {
                return false;
            }
            else
            {
                return MysqlHandler.Exec($"UPDATE usuarios SET Nombre='{usuario.Nombre}', dni='{usuario.Dni}', email='{usuario.Email}' WHERE id="+usuario.Id);
            }
        }
    }
}
