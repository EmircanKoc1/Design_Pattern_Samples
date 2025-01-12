using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Sample1.Models
{
    public class Computer
    {
        public string? CPUName { get; set; }
        public int CPUCoreCount { get; set; }
        public int CPUThreadCount { get; set; }

        public string? GPUName { get; set; }
        public int GPUVRAMSize { get; set; }

        public string? SSDName { get; set; }
        public int SSDCapacity { get; set; }

        public string? RAMName { get; set; }
        public int RAMSize { get; set; }


        public override string ToString()
        {

            return $"Computer Details:\n\n" +
            $"CPU: {CPUName ?? "undefined"} ({CPUCoreCount} cores, {CPUThreadCount} threads)\n" +
            $"GPU: {GPUName ?? "undefined"} ({GPUVRAMSize} GB VRAM)\n" +
            $"RAM: {RAMName ?? "undefined"} ({RAMSize} GB)\n" +
            $"SSD: {SSDName ?? "undefined"} ({SSDCapacity} GB)";
        }
    }

}
