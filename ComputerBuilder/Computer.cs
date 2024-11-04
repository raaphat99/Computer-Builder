using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class Computer
    {
        // Fields
        public string CPU { get; private set; }
        public string RAM { get; private set; }
        public string Storage { get; private set; }
        public string GraphicsCard { get; private set; }
        public bool HasWifi { get; private set; }
        public bool HasBluetooth { get; private set; }

        // Prevent the direct initialization through the constructor
        private Computer()
        { }

        public void ShowComputerCapabilities()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Graphics Card: {GraphicsCard}");
            Console.WriteLine($"WiFi: {HasWifi}");
            Console.WriteLine($"Bluetooth: {HasBluetooth}");
        }

        // Nested class
        public class Builder
        {
            private readonly Computer computer;
            public Builder()
            {
                computer = new Computer();
            }

            public Builder SetCPU(string cpu)
            {
                computer.CPU = cpu;
                return this;
            }

            public Builder SetRAM(string ram)
            {
                computer.RAM = ram;
                return this;
            }

            public Builder SetStorage(string storage)
            {
                computer.Storage = storage;
                return this;
            }

            public Builder SetGraphicsCard(string graphicsCard)
            {
                computer.GraphicsCard = graphicsCard;
                return this;
            }

            public Builder SetBluetooth(bool bluetooth)
            {
                computer.HasBluetooth = bluetooth;
                return this;
            }

            public Builder SetWifi(bool wifi)
            {
                computer.HasWifi = wifi;
                return this;
            }

            public Computer Build()
            {
                return computer;
            }
        }
    }
}
