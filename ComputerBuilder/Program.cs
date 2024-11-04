namespace ComputerBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computer myPC = new Computer.Builder()
                                        .SetCPU("Intel i7")
                                        .SetRAM("16GB")
                                        .SetStorage("1TB SSD")
                                        .SetGraphicsCard("NVIDIA GTX 3080")
                                        .SetWifi(true)
                                        .SetBluetooth(true)
                                        .Build();

            myPC.ShowComputerCapabilities();

        }
    }
}
