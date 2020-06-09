using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
            PcjDescuento = 10;
            PcjGanancia = 30;
            PcjIva = 19;

        }

        public Factura(Cliente cliente, Empleado empleado, List<DetalleFactura> detalles) {
            Cliente = cliente;
            Empleado = empleado;
            Detalles = detalles;
            PcjDescuento = 10;
            PcjGanancia = 30;
            PcjIva = 19;

        }
     

        public int Codigo { get; set; } 

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }

        public List<DetalleFactura> Detalles { get; set; }

        public double PcjIva { get; set; }

        public double Iva
        {
            get
            {
                return this.SubTotal * this.PcjIva / 100;
            }
        }

        public double SubTotal { get { return this.Detalles.Sum(x => x.Servicio.Base); } }

        public double PcjGanancia { get; set; } 

        public double Ganancia
        {   get
            {
                return  this.SubTotal * this.PcjGanancia / 100;
            }
        } 

        public double PcjDescuento { get; set; }

        public double Descuento { get{ return this.SubTotal * this.PcjDescuento / 100; }}

        public int NServicios { get { return this.Detalles.Count; } }

        public double Total { get { return  this.SubTotal + this.Iva + this.Ganancia - this.Descuento; } }

        public override string ToString()
        {
            return $"Cliente: {Cliente.NombreCompleto()}\nEmpleado: {Empleado.NombreCompleto()}\nServicios: {NServicios}\nSubTotal: {SubTotal}\nTotal: {Total}\nDescuento: {Descuento}\nGanancia: {Ganancia}\n";
        }
    }
}


   
