class Player
{
    Rectangle Hitbox = new(360, 550, 80, 20);
    public Color Color = Color.Black;
    public int Health = 100;
    public int HealthMax = 100;
    public int Level = 1;
    public int Exp = 0;
    public float Speed = 4;

    public void Update()
    {

    if (Raylib.IsKeyDown(KeyboardKey.Left)) Hitbox.X -= Speed;
    if (Raylib.IsKeyDown(KeyboardKey.Up)) Hitbox.Y -= Speed;
    if (Raylib.IsKeyDown(KeyboardKey.Right)) Hitbox.X += Speed;
    if (Raylib.IsKeyDown(KeyboardKey.Down)) Hitbox.Y += Speed;

    }

    public void draw()
    {
         Raylib.DrawRectangleRec(Hitbox, Color.Black);
    }
}

