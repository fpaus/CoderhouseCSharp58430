namespace Clase5.Clases
{
    public class Producto
    {
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;

        public int Codigo { get; init; }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }

        public double PrecioDeCompra
        {
            get {
                return _precioDeCompra;
            }
            set {
                if(value < 0)
                {
                    Console.WriteLine("El valor no puede ser menor a 0");
                } else
                {
                    _precioDeCompra = value;
                }
            }
        }
        
        public double PrecioDeVenta
        {
            get
            {
                return _precioDeVenta;
            }
            set
            {
                _precioDeVenta = value;
            }
        }

        public string Categoria
        {
            get => _categoria;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _categoria = "SIN CATEGORIA";
                }
                else
                {
                    _categoria = value;
                }
            }

        }

        public Producto(int codigo, 
                        string descripcion, 
                        double precioCompra, 
                        double precioVenta, 
                        string categoria ) {
            Codigo = codigo;
            this._descripcion = descripcion;
            this._precioDeCompra = precioCompra;
            this._precioDeVenta = precioVenta;
            Categoria = categoria;
            
        }

        public bool TienePrecioDeVentaCargado()
        {
            return this._precioDeVenta > 0;
        }

    }
}
