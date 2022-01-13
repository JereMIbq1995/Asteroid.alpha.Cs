using Raylib_CsLo;

namespace genie.services.raylib
{
    class ServicesTest {
        
        public ServicesTest() {
            // Nothing for now
        }

        /**********************************************************************
        * This function test the keyboard's detection of the 4 keys LEFT, RIGHT,
        * UP, and DOWN.
        * If none of the keys above are pressed, console will continually print
        *    the text "No key pressed..."
        * If any key is pressed, the console will print "<key> is pressed!"
        ***********************************************************************/
        public void TestKeyboardService() {
            RaylibKeyboardService keyboardService = new RaylibKeyboardService();

            Raylib.InitWindow(1280, 720, "Hello, Raylib-CsLo");
            Raylib.SetTargetFPS(60);

            while (!keyboardService.IsQuit()) {
                
                //Testing get keys states:
                List<int> keys = new List<int>();
                keys.Add(Keys.LEFT);
                keys.Add(Keys.RIGHT);
                keys.Add(Keys.UP);
                keys.Add(Keys.DOWN);

                Dictionary<int, bool> keysState = keyboardService.GetKeysState(keys);

                if (keysState[Keys.LEFT]) {
                    Console.WriteLine("LEFT is down!");
                }
                if (keysState[Keys.RIGHT]) {
                    Console.WriteLine("RIGHT is down!");
                }
                if (keysState[Keys.UP]) {
                    Console.WriteLine("UP is down!");
                }
                if (keysState[Keys.DOWN]) {
                    Console.WriteLine("DOWN is down!");
                }

                //Testing IsKeyPressed(), IsKeyReleased()
                if (keyboardService.IsKeyPressed(Keys.A)) {
                    Console.WriteLine("A is pressed!");
                }
                if (keyboardService.IsKeyPressed(Keys.D)) {
                    Console.WriteLine("D is pressed!");
                }
                if (keyboardService.IsKeyPressed(Keys.W)) {
                    Console.WriteLine("W is pressed!");
                }
                if (keyboardService.IsKeyPressed(Keys.S)) {
                    Console.WriteLine("S is pressed!");
                }

                if (keyboardService.IsKeyReleased(Keys.A) || keyboardService.IsKeyReleased(Keys.D) 
                    || keyboardService.IsKeyReleased(Keys.W) || keyboardService.IsKeyReleased(Keys.S)) {
                        Console.WriteLine("Something key was just released!");
                }

                //Testing IsKeyDown(), IsKeyUp()
                // Comment this part out to see clearer result of previous tests
                if (keyboardService.IsKeyDown(Keys.J))
                {
                    Console.WriteLine("J is pressed!");
                }
                if (keyboardService.IsKeyDown(Keys.L))
                {
                    Console.WriteLine("L is pressed!");
                }
                if (keyboardService.IsKeyDown(Keys.I))
                {
                    Console.WriteLine("I is pressed!");
                }
                if (keyboardService.IsKeyDown(Keys.K))
                {
                    Console.WriteLine("K is pressed!");
                }

                if (keyboardService.IsKeyUp(Keys.J) && keyboardService.IsKeyUp(Keys.L)
                    && keyboardService.IsKeyUp(Keys.I) && keyboardService.IsKeyUp(Keys.K))
                {
                    Console.WriteLine("J, L, I, K are all up!");
                }

                //All the drawing stuff...
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.SKYBLUE);
                Raylib.DrawFPS(10, 10);
                Raylib.DrawText("Press UP, DOWN, LEFT, or RIGHT and watch the console!", 100, 360, 30, Raylib.RED);
                Raylib.DrawText("Press W, S, A, or D and watch the console!", 100, 400, 30, Raylib.RED);
                Raylib.DrawText("Press I, K, J, or L and watch the console!", 100, 440, 30, Raylib.RED);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}