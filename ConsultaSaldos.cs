using System;

namespace ConsultaSaldos
{
    public class ConsultaSaldos
    {
        public string Nombre { get; set; }
        public DateTime FEchaConsulta { get; set; }

        public int SaldoContable { get; set; }

        public int Compensacion { get; set; }

        public int  SaltoTotal { get; set; }
    }
}
