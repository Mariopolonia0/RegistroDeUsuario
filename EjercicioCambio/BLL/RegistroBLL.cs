using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RegistroDeUsuario.DAL;
using RegistroDeUsuario.Entidades;

namespace RegistroDeUsuario.BLL
{
    class RegistroBLL
    {
        public static Usuario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuario usuario;

            try
            {
                usuario = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return usuario;
        }

        public static void GuardarUsuario(Usuario usuario)
        {
            Contexto contexto = new Contexto();


            try
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
        }
    }
}
