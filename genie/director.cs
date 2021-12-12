using genie.cast;
using genie.script;

namespace genie {
    class Director : genie.script.Action.Callback {

        private bool isDirecting;
        private Cast cast;
        private Script script;
        private Clock clock;

        public Director() {
            this.isDirecting = true;
            this.cast = new Cast();
            this.script = new Script();
            this.clock = new Clock();
        }

        public void DirectScene(Cast cast, Script script) {
            
            this.cast = cast;
            this.script = script;
            this.isDirecting = true;

            while (isDirecting) {
                DoInputs();
                DoUpdates();
                DoOutputs();

                // Console.Write("Are we done? ");
                // string? answer = Console.ReadLine();
                // if (answer == "y") {
                //     isDirecting = false;
                // }
            }
        }

        public override void OnStop()
        {
            this.isDirecting = false;
        }

        public override void OnNext(Cast cast, Script script) {
            this.cast = cast;
            this.script = script;
        }

        private void DoInputs() {
            Console.WriteLine("Doing inputs...");
        }

        private void DoUpdates() {
            Console.WriteLine("Doing Updates...");
        }

        private void DoOutputs() {
            Console.WriteLine("Doing outputs...");
        }
    }
}