using Raylib_CsLo;

namespace genie.services.raylib {
    class RaylibKeyboardService {
        KeysMap keysMap;

        public RaylibKeyboardService() {
            this.keysMap = new KeysMap();

        }

        public bool IsQuit() {
            return Raylib.WindowShouldClose();
        }

        public Dictionary<int, bool> GetKeysState(List<int> keys) {
            Dictionary <int, bool> keysState = new Dictionary<int, int>();
            foreach (int key in keys) {
                keysState.Add(key, Raylib.IsKeyDown(this.keysMap.GetRaylibKey(key)));
            }
            return keysState;
        }
    }
}