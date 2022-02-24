namespace genie.cast {
    public class Actor {

        // Private member variables (Fields)
        private string path;
        private int width;
        private int height;
        
        private float x;
        private float y;
        private float vx;
        private float vy;

        private float rotation;
        private float rotationVel;

        private bool flipped;


        // Public methods:

        // Constructor
        public Actor(string path, int width, int height,
                    float x = 0, float y = 0,
                    float vx = 0, float vy = 0,
                    float rotation = 0, float rotationVel = 0,
                    bool flipped = false) {
            this.path = path;

            this.width = width;
            this.height = height;

            this.x = x;
            this.y = y;

            this.vx = vx;
            this.vy = vy;

            this.rotation = rotation;
            this.rotationVel = rotationVel;

            this.flipped = flipped;
        }
        
        
        // Set/Get methods for path
        public string GetPath() {
            return this.path;
        }

        public void SetPath(string path) {
            this.path = path;
        }

        
        // Set/Get methods for width and height
        public int GetWidth() {
            return this.width;
        }

        public void SetWidth(int width) {
            this.width = width;
        }

        public int GetHeight() {
            return this.height;
        }

        public void SetHeight(int height) {
            this.height = height;
        }

        // Actor
        public (float x, float y) GetPosition() {
            return (this.x, this.y);
        }

        // Set/Get methods for x and y
        public float GetX() {
            return this.x;
        }

        public void SetX(float x) {
            this.x = x;
        }

        public float GetY() {
            return this.y;
        }

        public void SetY(float y) {
            this.y = y;
        }

        // Set/Get methods for vx and vy
        public float GetVx() {
            return this.vx;
        }

        public void SetVx(float vx) {
            this.vx = vx;
        }

        public float GetVy() {
            return this.vy;
        }

        public void SetVy(float vy) {
            this.vy = vy;
        }

        // Getters for top-left corner of the rectangle
        public (float, float) GetTopLeft() {
            return (this.x - this.width/2, this.y - this.height/2);
        }
        
        public (float, float) GetTopRight()
        {
            return (this.x + this.width / 2, this.y - this.height / 2);
        }

        public (float, float) GetBottomLeft()
        {
            return (this.x - this.width / 2, this.y + this.height / 2);
        }

        public (float, float) GetBottomRight()
        {
            return (this.x + this.width / 2, this.y + this.height / 2);
        }

        // Set/Get methods for rotation and rotation_vel
        public float GetRotation() {
            return this.rotation;
        }

        public void SetRotation(float rotation) {
            this.rotation = rotation;
        }

        public float GetRotationVel() {
            return this.rotationVel;
        }

        public void SetRotationVel(float rotationVel) {
            this.rotationVel = rotationVel;
        }

        // Set/Get methods for flipped
        public bool GetFlipped() {
            return this.flipped;
        }

        public void SetFlipped(bool flipped) {
            this.flipped = flipped;
        }

        // Move functions:
        public void MoveWithVelocity() {
            this.x += this.vx;
            this.y += this.vy;
        }

        public void Rotate() {
            this.rotation += this.rotationVel;
        }
    }
}