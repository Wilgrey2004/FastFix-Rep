using FastFix_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFix_Negocio_logica
{
    public class Usuarios_Metodos
    {
        public void CrearUsuarioNormal(string name, string last_name1,string last_name2,string email,string sexo,string password)
        {
            using (FixFastDbEntities db = new FixFastDbEntities())
            {
                Usuarios newUser = new Usuarios();
                newUser.name = name;
                newUser.last_name1 = last_name1;
                newUser.last_name2 = last_name2;
                newUser.email = email;
                newUser.password = password;

                switch (sexo)
                {
                    case "Hombre":
                        newUser.sexo = "H";
                        break;

                    case "Mujer":
                        newUser.sexo = "M";
                        break;

                    case "Otro":
                        newUser.sexo = "O";
                        break ;
                    default:
                        MessageBox.Show("Sexo no espesificado!!!");
                        break;

                }

                db.Usuarios.Add(newUser);
                db.SaveChanges();
            }
        }

        public Usuarios comprovarExistencia(string email, string pass)
        {
            using (FixFastDbEntities db = new FixFastDbEntities()) { 
                Usuarios userFaind =  db.Usuarios.FirstOrDefault(sf => sf.email == email);

                if ( userFaind == null)
                {
                    MessageBox.Show($"el correo ${email} no esta registrado.");
                    return null;
                }

                if (userFaind.password == pass)
                {
                    MessageBox.Show($"usuario encontrado. Bienbenido {userFaind.name} {userFaind.last_name1}");

                    return userFaind;
                }

                return null;

            }


        }
            
    }
}