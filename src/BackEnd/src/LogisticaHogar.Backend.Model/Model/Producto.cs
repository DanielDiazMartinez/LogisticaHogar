﻿namespace LogisticaHogar.Backend.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Cantidad { get; set; }
        public string Unidad { get; set; }
        public bool EsPropio { get; set; }
    }
}

