using genie;
using genie.cast;
using genie.test;
using genie.services;
using genie.services.raylib;

using Raylib_cs;

namespace asteroid
{
    public static class Program
    {
        public static void Test() {
            // MouseMap mouseMap = new MouseMap();
            // mouseMap.getRaylibMouse(-1);

            // CastScriptTest castScriptTest = new CastScriptTest();
            // castScriptTest.testCast();
            // castScriptTest.testScript();

            ServicesTest servicesTest = new ServicesTest();
            servicesTest.TestScreenService();

            // Director director = new Director();
            // director.DirectScene();
        }

        public static void Main(string[] args)
        {
            (int, int) W_SIZE = (500, 700);
            (int, int) START_POSITION = (500, 700);
            int SHIP_WIDTH = 40;
            int SHIP_LENGTH = 50;
            string SCREEN_TITLE = "Asteroids";
            int FPS = 120;
            
            // Test();
            RaylibKeyboardService keyboardService = new RaylibKeyboardService();
            RaylibPhysicsService physicsService = new RaylibPhysicsService();
            RaylibScreenService screenService = new RaylibScreenService(W_SIZE, SCREEN_TITLE, FPS);
            
        
        }
    }
}