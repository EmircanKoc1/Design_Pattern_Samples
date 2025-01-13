using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Sample1
{
    public class WindowOptions
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string? PanelType { get; set; }

        public override string ToString()
        {
            return $"WindowOptions:\n" +
                $" Width = {Width}, Height = {Height}, PanelType = {PanelType ?? "undefined"}";
        }
    }
}
