using System;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;

namespace SerialProgram
{
    internal sealed class SerialWaiter : IDisposable
    {
        private readonly StringBuilder _buffer;
        private readonly SerialPort _port;

        public SerialWaiter(SerialPort port)
        {
            _buffer = new StringBuilder();
            _port = port;
            _port.DataReceived += PortDataRecieved;
        }

        private void PortDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            _buffer.Append(_port.ReadExisting());
        }

        public async Task<string> ReadLineAsync()
        {
            int waited = 0;
            while (waited < _port.ReadTimeout)
            {
                if (_buffer.Length > 0
                    && _buffer[_buffer.Length - 1] == '\n')
                {
                    break;
                }
                waited++;
                await Task.Delay(1);
            }
            return _buffer.ToString();
        }

        public void Dispose()
        {
            _port.DataReceived -= PortDataRecieved;
        }
    }

    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Elérhető portok:");
            foreach (var port in SerialPort.GetPortNames())
            {
                Console.WriteLine(port);
            }
            Console.Write("Használni kívánt port neve: ");
            string? selectedPortName = Console.ReadLine();

            using (SerialPort serialPort = CreateSerialForAduino(selectedPortName, 115200))
            {
                serialPort.Open();

                using (var waiter = new SerialWaiter(serialPort))
                {
                    serialPort.Write("hello");
                    var response = await waiter.ReadLineAsync();
                    Console.WriteLine(response);
                }
            }
        }

        private static SerialPort CreateSerialForAduino(string? portName, int baudRate)
        {
            if (string.IsNullOrEmpty(portName))
                throw new ArgumentException("Nem megfelelő soros port");

            return new SerialPort
            {
                PortName = portName,
                BaudRate = baudRate,
                WriteTimeout = 1000,
                ReadTimeout = 1000,
                DataBits = 8,
                StopBits = StopBits.One,
                Parity = Parity.,
                RtsEnable = false,
                DtrEnable = false,
            };
        }
    }
}
