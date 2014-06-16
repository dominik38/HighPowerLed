using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

using GTI = Gadgeteer.Interfaces;
using Gadgeteer;
using Gadgeteer.Modules.Schreiber;

namespace GadgeteerApp1
{
    public partial class Program
    {
        HighPowerLed highPowerLed;
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {  
            Debug.Print("Program Started");        
            highPowerLed = new HighPowerLed(4);
            Thread thread1 = new Thread(ThreadStart1);
            thread1.Start();
        }

        private void ThreadStart1()
        {
            Debug.Print("Thread started");
            while (1 == 1)
            {
                highPowerLed.Dim(LedNumber.Led1, 100);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led2, 100);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led3, 100);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led1, 50);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led2, 50);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led3, 50);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led1, 0);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led2, 0);
                Thread.Sleep(1000);
                highPowerLed.Dim(LedNumber.Led3, 0);
                Thread.Sleep(1000);
                highPowerLed.On(LedNumber.Led1);
                highPowerLed.On(LedNumber.Led2);
                highPowerLed.On(LedNumber.Led3);
                Thread.Sleep(1000);
                highPowerLed.Off(LedNumber.Led1);
                highPowerLed.Off(LedNumber.Led2);
                highPowerLed.Off(LedNumber.Led3);
            }
        }
    }
}
