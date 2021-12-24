using Raylib_CsLo;

namespace genie.services.raylib {
    public class KeysMap {

        // hold the mapping of genie key to raylib key
        private Dictionary<int, int> keysMap;
        
        /*
            Constructor:
            Put all the mapping of supported genie keys to raylib keys inside keysMap
        */
        public KeysMap() {
            this.keysMap = new Dictionary<int, int>();

            keysMap.Add(Keys.BACKSPACE, (int) KeyboardKey.KEY_BACKSPACE);
            keysMap.Add(Keys.TAB, (int) KeyboardKey.KEY_TAB);
            // keysMap.Add(Keys.CLEAR, (int) KeyboardKey.);
            keysMap.Add(Keys.RETURN, (int) KeyboardKey.KEY_ENTER);
            keysMap.Add(Keys.PAUSE, (int) KeyboardKey.KEY_PAUSE);
            keysMap.Add(Keys.ESCAPE, (int) KeyboardKey.KEY_ESCAPE);
            keysMap.Add(Keys.SPACE, (int) KeyboardKey.KEY_SPACE);
            // keysMap.Add(Keys.EXCLAIM, (int) KeyboardKey.);
            // keysMap.Add(Keys.DBL_QUOTE, (int) KeyboardKey.);
            // keysMap.Add(Keys.HASH, (int) KeyboardKey.);
            // keysMap.Add(Keys.DOLLAR, (int) KeyboardKey.);
            // keysMap.Add(Keys.AMPERSAND, (int) KeyboardKey.);
            keysMap.Add(Keys.QUOTE, (int) KeyboardKey.KEY_APOSTROPHE);
            // keysMap.Add(Keys.LEFTPAREN, (int) KeyboardKey.);
            // keysMap.Add(Keys.RIGHTPAREN, (int) KeyboardKey.);
            // keysMap.Add(Keys.ASTERISK, (int) KeyboardKey.);
            // keysMap.Add(Keys.PLUS, (int) KeyboardKey.);
            keysMap.Add(Keys.COMMA, (int) KeyboardKey.KEY_COMMA);
            keysMap.Add(Keys.MINUS, (int) KeyboardKey.KEY_MINUS);
            keysMap.Add(Keys.PERIOD, (int) KeyboardKey.KEY_PERIOD);
            keysMap.Add(Keys.SLASH, (int) KeyboardKey.KEY_SLASH);
            keysMap.Add(Keys.K_0, (int) KeyboardKey.KEY_ZERO);
            keysMap.Add(Keys.K_1, (int) KeyboardKey.KEY_ONE);
            keysMap.Add(Keys.K_2, (int) KeyboardKey.KEY_TWO);
            keysMap.Add(Keys.K_3, (int) KeyboardKey.KEY_THREE);
            keysMap.Add(Keys.K_4, (int) KeyboardKey.KEY_FOUR);
            keysMap.Add(Keys.K_5, (int) KeyboardKey.KEY_FIVE);
            keysMap.Add(Keys.K_6, (int) KeyboardKey.KEY_SIX);
            keysMap.Add(Keys.K_7, (int) KeyboardKey.KEY_SEVEN);
            keysMap.Add(Keys.K_8, (int) KeyboardKey.KEY_EIGHT);
            keysMap.Add(Keys.K_9, (int) KeyboardKey.KEY_NINE);
            // keysMap.Add(Keys.COLON, (int) KeyboardKey.);
            keysMap.Add(Keys.SEMICOLON, (int) KeyboardKey.KEY_SEMICOLON);
            // keysMap.Add(Keys.LESS, (int) KeyboardKey.);
            keysMap.Add(Keys.EQUAL, (int) KeyboardKey.KEY_EQUAL);
            // keysMap.Add(Keys.GREATER, (int) KeyboardKey.);
            // keysMap.Add(Keys.QUESTION, (int) KeyboardKey.);
            // keysMap.Add(Keys.AT, (int) KeyboardKey.);
            keysMap.Add(Keys.LEFT_BRACKET, (int) KeyboardKey.KEY_LEFT_BRACKET);
            keysMap.Add(Keys.BACKSLASH, (int) KeyboardKey.KEY_BACKSLASH);
            keysMap.Add(Keys.RIGHTBRACKET, (int) KeyboardKey.KEY_RIGHT_BRACKET);
            // keysMap.Add(Keys.CARET, (int) KeyboardKey.);
            // keysMap.Add(Keys.UNDERSCORE, (int) KeyboardKey.);
            keysMap.Add(Keys.BACKQUOTE, (int) KeyboardKey.KEY_GRAVE);
            keysMap.Add(Keys.A, (int) KeyboardKey.KEY_A);
            keysMap.Add(Keys.B, (int) KeyboardKey.KEY_B);
            keysMap.Add(Keys.C, (int) KeyboardKey.KEY_C);
            keysMap.Add(Keys.D, (int) KeyboardKey.KEY_D);
            keysMap.Add(Keys.E, (int) KeyboardKey.KEY_E);
            keysMap.Add(Keys.F, (int) KeyboardKey.KEY_F);
            keysMap.Add(Keys.G, (int) KeyboardKey.KEY_G);
            keysMap.Add(Keys.H, (int) KeyboardKey.KEY_H);
            keysMap.Add(Keys.I, (int) KeyboardKey.KEY_I);
            keysMap.Add(Keys.J, (int) KeyboardKey.KEY_J);
            keysMap.Add(Keys.K, (int) KeyboardKey.KEY_K);
            keysMap.Add(Keys.L, (int) KeyboardKey.KEY_L);
            keysMap.Add(Keys.M, (int) KeyboardKey.KEY_M);
            keysMap.Add(Keys.N, (int) KeyboardKey.KEY_N);
            keysMap.Add(Keys.O, (int) KeyboardKey.KEY_O);
            keysMap.Add(Keys.P, (int) KeyboardKey.KEY_P);
            keysMap.Add(Keys.Q, (int) KeyboardKey.KEY_Q);
            keysMap.Add(Keys.R, (int) KeyboardKey.KEY_R);
            keysMap.Add(Keys.S, (int) KeyboardKey.KEY_S);
            keysMap.Add(Keys.T, (int) KeyboardKey.KEY_T);
            keysMap.Add(Keys.U, (int) KeyboardKey.KEY_U);
            keysMap.Add(Keys.V, (int) KeyboardKey.KEY_V);
            keysMap.Add(Keys.W, (int) KeyboardKey.KEY_W);
            keysMap.Add(Keys.X, (int) KeyboardKey.KEY_X);
            keysMap.Add(Keys.Y, (int) KeyboardKey.KEY_Y);
            keysMap.Add(Keys.Z, (int) KeyboardKey.KEY_Z);
            keysMap.Add(Keys.DELETE, (int) KeyboardKey.KEY_DELETE);
            keysMap.Add(Keys.KP0, (int) KeyboardKey.KEY_KP_0);
            keysMap.Add(Keys.KP1, (int) KeyboardKey.KEY_KP_1);
            keysMap.Add(Keys.KP2, (int) KeyboardKey.KEY_KP_2);
            keysMap.Add(Keys.KP3, (int) KeyboardKey.KEY_KP_3);
            keysMap.Add(Keys.KP4, (int) KeyboardKey.KEY_KP_4);
            keysMap.Add(Keys.KP5, (int) KeyboardKey.KEY_KP_5);
            keysMap.Add(Keys.KP6, (int) KeyboardKey.KEY_KP_6);
            keysMap.Add(Keys.KP7, (int) KeyboardKey.KEY_KP_7);
            keysMap.Add(Keys.KP8, (int) KeyboardKey.KEY_KP_8);
            keysMap.Add(Keys.KP9, (int) KeyboardKey.KEY_KP_9);
            keysMap.Add(Keys.KP_PERIOD, (int) KeyboardKey.KEY_KP_DECIMAL);
            keysMap.Add(Keys.KP_DIVIDE, (int) KeyboardKey.KEY_KP_DIVIDE);
            keysMap.Add(Keys.KP_MULTIPLY, (int) KeyboardKey.KEY_KP_MULTIPLY);
            keysMap.Add(Keys.KP_MINUS, (int) KeyboardKey.KEY_KP_SUBTRACT);
            keysMap.Add(Keys.KP_PLUS, (int) KeyboardKey.KEY_KP_ADD);
            keysMap.Add(Keys.KP_ENTER, (int) KeyboardKey.KEY_KP_ENTER);
            keysMap.Add(Keys.KP_EQUAL, (int) KeyboardKey.KEY_KP_EQUAL);
            keysMap.Add(Keys.UP, (int) KeyboardKey.KEY_UP);
            keysMap.Add(Keys.DOWN, (int) KeyboardKey.KEY_DOWN);
            keysMap.Add(Keys.LEFT, (int) KeyboardKey.KEY_LEFT);
            keysMap.Add(Keys.RIGHT, (int) KeyboardKey.KEY_RIGHT);
            keysMap.Add(Keys.INSERT, (int) KeyboardKey.KEY_INSERT);
            keysMap.Add(Keys.HOME, (int) KeyboardKey.KEY_HOME);
            keysMap.Add(Keys.END, (int) KeyboardKey.KEY_END);
            keysMap.Add(Keys.PAGEUP, (int) KeyboardKey.KEY_PAGE_UP);
            keysMap.Add(Keys.PAGEDOWN, (int) KeyboardKey.KEY_PAGE_DOWN);
            keysMap.Add(Keys.F1, (int) KeyboardKey.KEY_F1);
            keysMap.Add(Keys.F2, (int) KeyboardKey.KEY_F2);
            keysMap.Add(Keys.F3, (int) KeyboardKey.KEY_F3);
            keysMap.Add(Keys.F4, (int) KeyboardKey.KEY_F4);
            keysMap.Add(Keys.F5, (int) KeyboardKey.KEY_F5);
            keysMap.Add(Keys.F6, (int) KeyboardKey.KEY_F6);
            keysMap.Add(Keys.F7, (int) KeyboardKey.KEY_F7);
            keysMap.Add(Keys.F8, (int) KeyboardKey.KEY_F8);
            keysMap.Add(Keys.F9, (int) KeyboardKey.KEY_F9);
            keysMap.Add(Keys.F10, (int) KeyboardKey.KEY_F10);
            keysMap.Add(Keys.F11, (int) KeyboardKey.KEY_F11);
            keysMap.Add(Keys.F12, (int) KeyboardKey.KEY_F12);
            // keysMap.Add(Keys.F13, (int) KeyboardKey.);
            // keysMap.Add(Keys.F14, (int) KeyboardKey.);
            // keysMap.Add(Keys.F15, (int) KeyboardKey.);
            keysMap.Add(Keys.NUMLOCK, (int) KeyboardKey.KEY_NUM_LOCK);
            keysMap.Add(Keys.CAPSLOCK, (int) KeyboardKey.KEY_CAPS_LOCK);
            keysMap.Add(Keys.SCROLLOCK, (int) KeyboardKey.KEY_SCROLL_LOCK);
            keysMap.Add(Keys.RSHIFT, (int) KeyboardKey.KEY_RIGHT_SHIFT);
            keysMap.Add(Keys.LSHIFT, (int) KeyboardKey.KEY_LEFT_SHIFT);
            keysMap.Add(Keys.RCTRL, (int) KeyboardKey.KEY_RIGHT_CONTROL);
            keysMap.Add(Keys.LCTRL, (int) KeyboardKey.KEY_LEFT_CONTROL);
            keysMap.Add(Keys.RALT, (int) KeyboardKey.KEY_RIGHT_ALT);
            keysMap.Add(Keys.LALT, (int) KeyboardKey.KEY_LEFT_ALT);
            // keysMap.Add(Keys.RMETA, (int) KeyboardKey.);
            // keysMap.Add(Keys.LMETA, (int) KeyboardKey.);
            keysMap.Add(Keys.LSUPER, (int) KeyboardKey.KEY_LEFT_SUPER);
            keysMap.Add(Keys.RSUPER, (int) KeyboardKey.KEY_RIGHT_SUPER);
            // keysMap.Add(Keys.MODE, (int) KeyboardKey.);
            // keysMap.Add(Keys.HELP, (int) KeyboardKey.);
            keysMap.Add(Keys.PRINT, (int) KeyboardKey.KEY_PRINT_SCREEN);
            // keysMap.Add(Keys.SYSREQ, (int) KeyboardKey.);
            // keysMap.Add(Keys.BREAK, (int) KeyboardKey.);
            keysMap.Add(Keys.MENU, (int) KeyboardKey.KEY_MENU);
            // keysMap.Add(Keys.POWER, (int) KeyboardKey.);
            // keysMap.Add(Keys.EURO, (int) KeyboardKey.);
            keysMap.Add(Keys.KB_MENU, (int) KeyboardKey.KEY_KB_MENU);
            keysMap.Add(Keys.VOLUME_UP, (int) KeyboardKey.KEY_VOLUME_UP);
            keysMap.Add(Keys.VOLUME_DOWN, (int) KeyboardKey.KEY_VOLUME_DOWN);
        }

        public int getRaylibKey(int genieKey) {
            try {
                return this.keysMap[genieKey];
            }
            catch (KeyNotFoundException e) {
                if (e.Source != null)
                    Console.WriteLine("KeyNotFoundException source: {0}", e.Source);
                throw new KeyNotFoundException($"Genie key {genieKey} is not a valid key");
            }
        }
    }
}