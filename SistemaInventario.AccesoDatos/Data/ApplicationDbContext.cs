﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bodega> Bodegas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Marca> marcas { get; set; }

        //public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<UsuarioAplicacion>UsuarioAplicacion { get; set; }

       

        
    }
}
