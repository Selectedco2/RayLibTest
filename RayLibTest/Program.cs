global using Raylib_cs;

Raylib.InitWindow(800, 600, "Test");
Raylib.SetTargetFPS(60);


Player player = new();

while (!Raylib.WindowShouldClose())
{
    player.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DarkPurple);
    
    Raylib.EndDrawing();
}