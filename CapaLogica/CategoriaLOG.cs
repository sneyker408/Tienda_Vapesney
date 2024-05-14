﻿using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaLOG
    {

        CategoriaDAL _categoriaDAL;

        public int GuardarCategoria(Categoria categoria, int id = 0, bool Actualizacion = false)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.Guardar(categoria, id, Actualizacion);
        }

        public Categoria ObtenerCategoriaPorId(int codigo)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.LeerPorId(codigo);

        }

        public int ActualizarCategoria(Categoria categoria, int id)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.Guardar(categoria, id, true);
        }

        public List<Categoria> ObtenerCategorias(bool inactivo = false)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Categorias(inactivo);

        }

        public string ExtraerNombreCategoria(int idCategoria)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.ObtenerNombreCategoriaDesdeBD(idCategoria);
        }

        public int EliminarCategoria(int id)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.EliminarCategoria(id);
        }

        public object ObtenerTodasCategorias()
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.TodasCategorias();
        }

        public List<Categoria> ObtenerFabricantesPorEstado(bool estadoActivo)
        {
            return _categoriaDAL.ObtenerCategoriaPorEstado(estadoActivo);
        }

        public Categoria ObtenerFabricantePorId(int codigo)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.LeerPorId(codigo);
        }

        public List<Categoria> ObtenerCategoria(bool inactivo = false)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Categorias(inactivo);
        }

        public Categoria ObtenerCategoriaPorNombre(string nombreCategoria)
        {
            _categoriaDAL = new CategoriaDAL();

            return _categoriaDAL.ObtenerCategoriaPorNombre(nombreCategoria);
        }

    }
}
