using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDLServices.Views.Navigation
{

    public class mdStartPageMenuItem
    {
        public mdStartPageMenuItem()
        {
            TargetType = typeof(mdStartPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}