using System;
class Program
    {
        static void Main(string[] args)
        {
            DispositivoComponent oCelular1 = new DisCelular();
            oCelular1.Marca = "Xiaomi";
            oCelular1.Modelo = "S";
            oCelular1.Imei = 123456;
            oCelular1.Sistema = "Android";
            oCelular1.Descripcion = oCelular1.Marca + " " + oCelular1.Modelo + " " + oCelular1.Sistema + " " + oCelular1.Imei;
            oCelular1 = new HAuricular(oCelular1);
            oCelular1 = new HCargador(oCelular1);

            List<String> funcionesReparaList = new List<string>();
            funcionesReparaList.Add("Pantalla");
            funcionesReparaList.Add("Camara");
            funcionesReparaList.Add("Pin Carga");
            oCelular1.FuncionalidadesReparar = funcionesReparaList;

            DispositivoComponent oCelular2 = new DisCelular();
            oCelular2.Marca = "LG";
            oCelular2.Modelo = "104";
            oCelular2.Imei = 35892;
            oCelular2.Sistema = "Android";
            oCelular2.Descripcion = oCelular2.Marca + " " + oCelular2.Modelo + " " + oCelular2.Sistema + " " + oCelular2.Imei;
            oCelular2 = new HAuricular(oCelular2);

            List<String> funcionesReparaListC2 = new List<string>();
            funcionesReparaListC2.Add("Sonido");
            funcionesReparaListC2.Add("Flash");
            funcionesReparaListC2.Add("Camara");
            oCelular2.FuncionalidadesReparar = funcionesReparaListC2;



            DispositivoComponent oTablet1 = new DisTablet();
            oTablet1.Marca = "Apple";
            oTablet1.Modelo = "iPad";
            oTablet1.Imei = 55554;
            oTablet1.Sistema = "IOS";
            oTablet1.chip = true;
            oTablet1.pais = "USA";
            oTablet1.Descripcion = oTablet1.Marca + " " + oTablet1.Modelo + " " + oTablet1.Sistema + " " + oTablet1.Imei + " Chip: " + oTablet1.chip.ToString() + " Pais:  "+ oTablet1.pais ;
            oTablet1 = new HAuricular(oTablet1);
            oTablet1 = new HCargador(oTablet1);


            List<String> funcionesReparaListT1 = new List<string>();
            funcionesReparaListT1.Add("Vibrador");
            funcionesReparaListT1.Add("Flash");
            funcionesReparaListT1.Add("Boton");
            oTablet1.FuncionalidadesReparar = funcionesReparaListT1;


            Cliente oCliente = new Cliente();
            oCliente.Nombre = "cliente: Gema Delgado ";
            oCliente.Dispositivos = new List<DispositivoComponent>() { oCelular1, oCelular2 , oTablet1 };


            OrdenReparacion oReparacion = new OrdenReparacion();
            oReparacion.ClienteReparacion = oCliente;
            oReparacion.NumeroOrden = 1001;

            Console.WriteLine(" Orden Reparacion: " + oReparacion.NumeroOrden + " - Cliente: Gema Delgado " );
            Console.WriteLine("Dispositivos: ");

            foreach (var item in oReparacion.ClienteReparacion.Dispositivos)
            {
                Console.WriteLine($"  {item.Descripcion} - Reparar: " + item.listarFuncionalidadesReparar());
            }

            //  Console.WriteLine($"Dispositivo:  {oCelular1.Descripcion} - Reparar: "+ oCelular1.listarFuncionalidadesReparar());



        
        }
    }
