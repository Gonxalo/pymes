using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pymes.Common
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre, descripcion;
        public int IDCATEGORIA
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Categoria(int idcat, string nom, string desc)
        {
            idCategoria = idcat;
            nombre = nom;
            descripcion = desc;
        }
    }
}
