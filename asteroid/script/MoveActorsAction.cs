using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace asteroid.script {
    class MoveActorsAction : genie.script.Action {

        RaylibPhysicsService physicsService;

        public MoveActorsAction(int priority, RaylibPhysicsService physicsService) : base(priority) {
            this.physicsService = physicsService;
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            this.physicsService.MoveActors(cast.GetAllActors());
        }
    }
}