using Raylib_CsLo;

namespace genie.services.raylib {

    class RaylibScreenService {

        public RaylibScreenService() {
            // 
        }

        /***************************************************************
        * Check to see if the X mark on the top right of the game window
        * is clicked
        ****************************************************************/
        public bool IsQuit() {
            return Raylib.WindowShouldClose();
        }
    }
}