using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoAppMAUI.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Actividad { get; set; }
    }
}
