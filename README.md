# 2D-Ray-Casting

This is a program that simulates ray casting. The light source similar to the sun shoots rays in all directions and if rays intersect a boundary they stop at the boundary. This creates an effect similar to the sun casting a shadow. The light source is controlled by the mouse so the user can move it around. I used a bit of math (Line-Line intersection) from Wikipedia to determine whether a ray intersects a boundary. This was a fun project to make and Object Oriented Programming made it easier to make. Every ray is an object and so is the boundary, I then wrote a method that determines if each ray intersects each of the boundaries. The program works with multiple boundaries but its a bit buggy since I have to calculate the closest point of intersection(future fix) so I have it set to one boundary(numOfWalls = 1 in the Boundary class).

Running Code : Download Code Folder, Open 2D Ray Casting Folder, Open 2D Ray Casting.csproj (C# project).

Running Application : Download Run Folder, Open 2D Ray Casting.exe (Running the program generates the boundary at random positions on the screen so just keep running it till you get the position you want and move the lightsource using the mouse)
