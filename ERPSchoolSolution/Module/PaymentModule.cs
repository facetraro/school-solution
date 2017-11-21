using Domain;
using Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    public class PaymentModule : ModuleClass
    {
        public PaymentModule()
        {
            this.Name = "Gestión de pagos";
            this.Description = "Sector que pertime gestionar los pagos de coutas y actividades de los Alumnos.";
        }
    }
}
