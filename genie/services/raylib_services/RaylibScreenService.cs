using Raylib_cs;
using genie.cast;

namespace genie.services.raylib {

    public class RaylibScreenService {
        
        private int fps;
        private Dictionary<string, Texture2D> textureCache;
        private Dictionary<(bool, bool, bool, bool), (int, int)> circleSectorsDict;

        /***************************************************************
        * Constructor:
        *   - Initialize window
        *   - Set target FPS
        *   - Initialize the circle sectors dictionary
        ****************************************************************/
        public RaylibScreenService((int, int) windowSize, string title = "Genie Game", int fps = 60) {
            // 
            Raylib.InitWindow(windowSize.Item1, windowSize.Item2, title);

            this.SetFPS(fps);

            this.textureCache = new Dictionary<string, Texture2D>();

            this.circleSectorsDict = new Dictionary<(bool, bool, bool, bool), (int, int)>();
            this.circleSectorsDict.Add((false, false, false, false), (0, 360));
            this.circleSectorsDict.Add((false, false, false, true), (0, 90));
            this.circleSectorsDict.Add((false, false, true, false), (0, -90));
            this.circleSectorsDict.Add((false, false, true, true), (-90, 90));
            this.circleSectorsDict.Add((false, true, false, false), (-90, -180));
            // this.circleSectorsDict.Add((false, true, false, true), ((-90, -180), (0, 90)));
            this.circleSectorsDict.Add((false, true, true, false), (0, -180));
            this.circleSectorsDict.Add((false, true, true, true), (90, -180));

            this.circleSectorsDict.Add((true, false, false, false), (90, 180));
            this.circleSectorsDict.Add((true, false, false, true), (0, 180));
            // this.circleSectorsDict.Add((true, false, true, false), ((90, 180), (0, -90)));
            this.circleSectorsDict.Add((true, false, true, true), (-90, 180));
            this.circleSectorsDict.Add((true, true, false, false), (90, 270));
            this.circleSectorsDict.Add((true, true, false, true), (0, 270));
            this.circleSectorsDict.Add((true, true, true, false), (90, 360));
            this.circleSectorsDict.Add((true, true, true, true), (0, 360));
        }

        /***************************************************************
        * Whatever needs to be done to initialize / re-initialize Screen Service
        ****************************************************************/
        public void Initialize() {
            // Nothing for now
        }

        /***************************************************************
        * (Private) Load Texture:
        * Return a texture given an Actor
        ****************************************************************/
        private Texture2D LoadTexture(Actor actor) {
            string imagePath = actor.GetPath();
            
            Image image_f = Raylib.LoadImage(imagePath);
            Raylib.ImageFlipHorizontal(ref image_f);
            
            Texture2D texture = Raylib.LoadTexture(imagePath);
            Texture2D texture_f = Raylib.LoadTextureFromImage(image_f);
            
            // When saving a texture, save both the normal image
            // and the flipped image
            if (!this.textureCache.Keys.Contains(imagePath)) {
                this.textureCache.Add(imagePath, texture);
                this.textureCache.Add(imagePath + "_f", texture_f);
            }

            return actor.GetFlipped() ? texture_f : texture;
        }

        /***************************************************************
        * Load textures
        ****************************************************************/
        public void LoadTexturesToCache(List<Actor> actors) {
            foreach (Actor actor in actors) {
                this.LoadTexture(actor);
            }
        }

        /***************************************************************
        * Set the fps to the declared fps
        ****************************************************************/
        public void SetFPS(int fps = 60) {
            this.fps = fps;
            Raylib.SetTargetFPS(fps);
        }

        /***************************************************************
        * BeginDrawing()
        ****************************************************************/
        public void BeginDrawing()
        {
            Raylib.BeginDrawing();
        }

        /***************************************************************
        * BeginDrawing()
        ****************************************************************/
        public void FillScreen((int r, int g, int b, int a) color)
        {
            Raylib.ClearBackground(new Color(color.r, color.g, color.b, color.a));
        }

        /***************************************************************
        * UpdateScreen()
        ****************************************************************/
        public void UpdateScreen()
        {
            Raylib.EndDrawing();
        }

        /***************************************************************
        * CloseWindow()
        ****************************************************************/
        public void CloseWindow()
        {
            Raylib.CloseWindow();
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