﻿using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorio
{
  public  class UnidadTrabajo:IUnidadTrabajo
    {

        private readonly ApplicationDbContext _db;

        public  IBodegaRepositorio Bodega { get; private set; }
        public IcategoriaRepositorio Categoria { get; private set; }
        public IMarcaRepositorio Marca { get; private set; }
        public IProductoRepositorio Producto { get; private set; }


       

        public IUsuarioAplicacionRepositorio UsuarioAplicacionRepositorio { get; private set; }

      
        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Bodega = new BodegaRepositorio(_db);
            Categoria = new CategoriaRepositorio(_db);
            Marca = new MarcaRepositorio(_db);
            Producto = new ProductoRepositorio(_db);
            UsuarioAplicacionRepositorio = new UsuarioAplicacionRepositorio(_db);
        }

        public void Guardar()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
