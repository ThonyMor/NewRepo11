public class HAuricular : HardwareDecorator
    {
        public HAuricular(DispositivoComponent dispositivo) : base(dispositivo) {Descripcion = string.Format($"{_dispositivo.Descripcion}, Extra Auricular"); }
       
    
    }