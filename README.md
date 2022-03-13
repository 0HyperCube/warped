<h1 align="center">Warped</h1>

A pixel art dungeon crawler written in unity.
You walk through 10 levels (floors) each with a unique colour scheme, killing or doging several variaties of mosters that spawn from portals scattered through the level. You can kill enemies with a single punch.

## Player controls
- <kbd>W</kbd><kbd>A</kbd><kbd>S</kbd><kbd>D</kbd> / arrow keys -> move (including diagonals)
- <kbd>Space</kbd> -> Punch in the current direction your character is facing
- <kbd>E</kbd> -> interact with quest NPC (if in range)
- <kbd>Esc</kbd> -> Pause menu

## Enemies
- Several variaties of enemies with different attack speeds / movement speeds / damage
- Enemies move towards the player if they have a direct line of site, otherwise they stay still
- When enemies are within a certain distance of the player, they start an animation with them moving forward
- If their animation finishes and they are near the player, they apply their damage output

## Hud (heads up display)
- 5 hearts (can be half hearts) show your hp similar to minecraft. HP is only stored to half a heart. After being damaged you (possibly) gain some invincibility
- A possilble timer for speedrunning
- Possibly a level number
- Your current quest

## NPCs & quests
- There are a number of neutral npcs on the map
- If you press <kbd>e</kbd> then you see their dialogue box
- They will request a room to be cleard or items to be collected and returned to them
