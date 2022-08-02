public abstract class HardwareDecorator : DispositivoComponent
    {
        protected DispositivoComponent _dispositivo;
        public HardwareDecorator(DispositivoComponent dispositivo)
        {
            _dispositivo = dispositivo;
        }


    }