using genie;
using genie.cast;
using genie.test;
using genie.services;
using genie.services.raylib;

using Raylib_CsLo;

namespace asteroid
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // MouseMap mouseMap = new MouseMap();
            // mouseMap.getRaylibMouse(-1);
            CastScriptTest castScriptTest = new CastScriptTest();
            castScriptTest.testCast();
            // castScriptTest.testScript();

            // Director director = new Director();
            // director.DirectScene();
        }
    }
}