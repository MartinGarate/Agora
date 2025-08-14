using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Enums
{
    public enum TipoUsuarioEnum
    {
        //un enum es un conjunto de constantes con nombre
        //los valores por defecto son 0,1,2,3...
        //se pueden asignar valores personalizados
        
        Estudiante,
        Docente,
        Administrador,

        // si no le ponemos valor, automaticamente toma el valor comenzando desde 0 y aumentando en 1 por cada elemento.
    }
}
