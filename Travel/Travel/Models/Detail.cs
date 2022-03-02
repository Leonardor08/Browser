using Microsoft.EntityFrameworkCore;

//Creamos la propiedad de la vista como si fuera una entidad normal

namespace Travel.Models{
    //Esta propiedad indica que no maneja una llave primaria al ser una vista. 
    [Keyless]
    public class Detail{
       public string Nombre { get; set; } 
       public string Apellidos { get; set; }
       public string Titulo { get; set; }
       public string Sinopsis { get; set; }
       public string N_paginas { get; set; }
       public int Isbn { get; set; }
       public string Editorial { get; set; }
    }
}