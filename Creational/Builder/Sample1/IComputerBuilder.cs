using Creational.Builder.Sample1.Models;

namespace Creational.Builder.Sample1
{
    public interface IComputerBuilder
    {
        void SetCPU(string cpuName, int coreCount, int threadCount);
        void SetGPU(string gpuName, int vramSize);
        void SetSSD(string ssdName, int ssdCapacity);
        void SetRAM(string memoryName, int memorySize);

        Computer BuildComputer();

    }
}
