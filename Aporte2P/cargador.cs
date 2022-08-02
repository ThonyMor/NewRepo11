 public class HCargador : HardwareDecorator
    {
        public HCargador(DispositivoComponent dispositivo) : base(dispositivo) { Descripcion = string.Format($"{_dispositivo.Descripcion}, Extra Cargador"); }

    }