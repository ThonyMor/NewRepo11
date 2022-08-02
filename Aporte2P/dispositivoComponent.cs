using System;
public abstract class DispositivoComponent
    {
        public int Imei { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Sistema { get; set; }
        public bool chip { get; set; }
        public string pais { get; set; }
        public List<String> FuncionalidadesReparar { get; set; }

        public string listarFuncionalidadesReparar() {

            String respuesta ="";

            foreach (var item in this.FuncionalidadesReparar)
            {
                respuesta = respuesta + " " + item + " | ";
            }
            return respuesta;
        }

    }
