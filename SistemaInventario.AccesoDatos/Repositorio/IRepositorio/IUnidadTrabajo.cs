using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
 public   interface IUnidadTrabajo:IDisposable
    {
        IBodegaRepositorio Bodega { get; }
        IcategoriaRepositorio Categoria { get; }
        IMarcaRepositorio Marca { get;  }

        void Guardar();
    }
}
