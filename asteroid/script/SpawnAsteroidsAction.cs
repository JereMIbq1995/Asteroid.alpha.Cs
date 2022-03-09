using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace asteroid.script {
    class SpawnAsteroidsAction : genie.script.Action {
        
        private (int, int) windowSize;

        public SpawnAsteroidsAction(int priority, (int, int) windowSize) : base(priority) {
            this.windowSize = windowSize;
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
        }
    }
}