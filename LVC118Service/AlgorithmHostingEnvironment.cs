// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities.API;
using LVC118;

namespace LVC118Service
{
    [CompilerGenerated]
    internal static class AlgorithmHostingEnvironment
    {
        public static Framework Framework;

        public static void Initialize()
        {
            Algorithm.UpdateSystemSettings();
        }

        public static void Start()
        {
            Framework = FrameworkFactory.Create();
            Algorithm.API = new Hub(Framework);
        }

        public static void Shutdown()
        {
            Framework?.Dispose();
        }
    }
}