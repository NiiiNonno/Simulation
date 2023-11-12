namespace Nonno.Simulation.Graphics;
public class Program
{
    public static int Main(string[] args)
    {
        var p = new Program();

        Set(p, Activator.Instance);

        return 0;
    }

    public static void Set(Program program, Activator activator)
    {
        activator.CallGPU();
        activator.CallWindow();
    }
}
