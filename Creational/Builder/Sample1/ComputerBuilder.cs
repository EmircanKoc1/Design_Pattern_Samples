using Creational.Builder.Sample1.Models;

namespace Creational.Builder.Sample1
{
    public class ComputerBuilder : IComputerBuilder
    {

        public ComputerBuilder(Computer computer)
            => this.computer = computer;

        public ComputerBuilder()
        {

        }

        private Computer? computer;

        public void SetCPU(string cpuName, int coreCount, int threadCount)
        {

            if (CreateAndSetIfNotExistsComputer() is Computer computer)
            {
                computer.CPUName = cpuName;
                computer.CPUCoreCount = coreCount;
                computer.CPUThreadCount = threadCount;
            }
        }

        public void SetGPU(string gpuName, int vramSize)
        {
            if (CreateAndSetIfNotExistsComputer() is Computer computer)
            {
                computer.GPUName = gpuName;
                computer.GPUVRAMSize = vramSize;
            }
        }

        public void SetRAM(string memoryName, int memorySize)
        {
            if (CreateAndSetIfNotExistsComputer() is Computer computer)
            {
                computer.RAMName = memoryName;
                computer.RAMSize = memorySize;
            }
        }

        public void SetSSD(string ssdName, int ssdCapacity)
        {
            if (CreateAndSetIfNotExistsComputer() is Computer computer)
            {
                computer.SSDName = ssdName;
                computer.SSDCapacity = ssdCapacity;
            }
        }

        public Computer BuildComputer()
        {
            var builtComputer = computer;
            computer = null;
            return builtComputer ?? throw new InvalidOperationException("Computer has not been built.");
        }

        protected Computer CreateAndSetIfNotExistsComputer()
            => computer ??= new Computer();
    }
}
