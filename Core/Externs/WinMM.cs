using System.Runtime.InteropServices;

namespace CVRModUpdater.Core.Externs
{
    public static class WinMM
    {
        [DllImport("winmm.dll")]
        public static extern uint timeBeginPeriod(uint uPeriod);
    }
}
