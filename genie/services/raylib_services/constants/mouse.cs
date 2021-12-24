using Raylib_CsLo;

namespace genie.services.raylib
{
    public class MouseMap
    {

        // hold the mapping of genie mouse button to raylib mouse button
        private Dictionary<int, int> mouseMap;

        /*
            Constructor:
            Put all the mapping of supported genie keys to raylib keys inside keysMap
        */
        public MouseMap()
        {
            this.mouseMap = new Dictionary<int, int>();

            mouseMap.Add(Mouse.LEFT, (int) MouseButton.MOUSE_BUTTON_LEFT);
            mouseMap.Add(Mouse.MIDDLE, (int) MouseButton.MOUSE_BUTTON_MIDDLE);
            mouseMap.Add(Mouse.RIGHT, (int) MouseButton.MOUSE_BUTTON_RIGHT);

            mouseMap.Add(Mouse.EXTRA1, (int) MouseButton.MOUSE_BUTTON_EXTRA);

            mouseMap.Add(Mouse.SIDE, (int) MouseButton.MOUSE_BUTTON_SIDE);
            mouseMap.Add(Mouse.FORWARD,(int) MouseButton.MOUSE_BUTTON_FORWARD);
            mouseMap.Add(Mouse.BACK, (int) MouseButton.MOUSE_BUTTON_BACK);
        }

        /*
            Attempt to return the raylib version of the mouse button,
            given the genie version
        */
        public int getRaylibMouse(int genieMouseButton)
        {
            try
            {
                return this.mouseMap[genieMouseButton];
            }
            catch (KeyNotFoundException e)
            {
                if (e.Source != null)
                    Console.WriteLine("KeyNotFoundException source: {0}", e.Source);
                throw new KeyNotFoundException($"Genie mouse button {genieMouseButton} is not a valid mouse button");
            }
        }
    }
}