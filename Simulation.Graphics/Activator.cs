using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nonno.Simulation.Graphics;
public class Activator
{
    public GraphicsProcessingUnit CallGPU()
    {
        InstantiateWindow();
        return new();
        //nint bufferSize = InstantiateWindow(null, 0);
        //var buffer = new IntPtr[bufferSize];
        //if (InstantiateWindow(buffer, bufferSize) != bufferSize)
        //{
        //    throw new Exception();
        //}

        //_self = buffer[0];
        //_fnDestroy = Marshal.GetDelegateForFunctionPointer<FnAction>(buffer[1]);
    }

    public Window CallWindow()
    {
        return new();
    }

    public static Activator Instance { get; } = new();

    [DllImport("Simulation.Graphics.rs", EntryPoint = "instantiate_window")]
    static extern void InstantiateWindow();
}
