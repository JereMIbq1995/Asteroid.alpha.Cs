using genie;
using genie.cast;
using genie.test;

namespace asteroid {
    public static class Program {
        public static void Main(string[] args) {
            
            CastScriptTest castScriptTest = new CastScriptTest();
            castScriptTest.testCast();
            castScriptTest.testScript();

            // Director director = new Director();
            // director.DirectScene();
        }
    }
}