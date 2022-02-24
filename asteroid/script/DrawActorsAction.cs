using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace asteroid.script {
    class DrawActorsAction : genie.script.Action {
        
        RaylibScreenService screenService;

        public DrawActorsAction(int priority, RaylibScreenService screenService) : base(priority) {
            this.screenService = screenService;
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            this.screenService.FillScreen(Color.WHITE);
            foreach (Actor actor in cast.GetAllActors()) {
                this.screenService.DrawRectangle(actor.GetPosition(), actor.GetWidth(), actor.GetHeight(), Color.BLACK, 5);
            }
        }
    }
}