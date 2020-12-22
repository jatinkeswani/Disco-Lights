# Disco-Lights
Make a game with two scenes:
1. First scene, which takes two inputs from user (row and column). This can be done by using
either dropdowns/textboxes/sliders or anything else that you can think of.
a. Each of the two fields (row and column) should meet the following constraints:
2 ≤ 𝑟𝑜𝑤 ≤ 10
2 ≤ 𝑐𝑜𝑙𝑢𝑚𝑛 ≤ 10
2. Second scene, generate a 2D grid (size = row x column) of objects (either circles or squares)
a. Gameplay:
i. This is a single player game
ii. When user clicks on any cell of the grid, that cell is highlighted along with all
the “reachable” cells. After 1 second, all these reachable cells along with the
selected cell are destroyed/killed from the grid.
iii. Game is continued till all the cells in the grid are destroyed.
Reachable Cells: All the cells that are connected to the selected cell in any 1 of the 4 diagonal directions
continually, are called reachable cells.

Selected cell - Yellow
Alive cells - Blue
Highlighted cells - Green
Dead cells - Red
