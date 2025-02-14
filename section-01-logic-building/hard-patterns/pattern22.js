/* 

N = 5, the pattern should look like as below:



5 5 5 5 5 5 5 5 5 
5 4 4 4 4 4 4 4 5 
5 4 3 3 3 3 3 4 5 
5 4 3 2 2 2 3 4 5 
5 4 3 2 1 2 3 4 5 
5 4 3 2 2 2 3 4 5 
5 4 3 3 3 3 3 4 5 
5 4 4 4 4 4 4 4 5 
5 5 5 5 5 5 5 5 5


n=5

No of lines (row and columns) = 2 * n -1 



5 5 5 5 5 5 5 5 5 
5 4 4 4 4 4 4 4 5 
5 4 3 3 3 3 3 4 5 
5 4 3 2 2 2 3 4 5 
5 4 3 2 1 2 3 4 5 
5 4 3 2 2 2 3 4 5 
5 4 3 3 3 3 3 4 5 
5 4 4 4 4 4 4 4 5 
5 5 5 5 5 5 5 5 5



*/

function printPattern(n) {
  // Outer loop for the rows
  for (let i = 0; i < 2 * n - 1; i++) {
    // Inner loop for the columns
    for (let j = 0; j < 2 * n - 1; j++) {
      /* Initialising the top, down, left
        and right indices of a cell*/
      let top = i;
      let bottom = j;
      let right = 2 * n - 2 - j;
      let left = 2 * n - 2 - i;

      /* Minimum of 4 directions and then we 
        subtract from n because previously we 
        would get a pattern whose border has 0's, 
        but we want with border n's and then
        decreasing inside.*/
      process.stdout.write(
        n - Math.min(Math.min(top, bottom), Math.min(left, right)) + " "
      );
    }
    // Move to the next row
    console.log();
  }
}

printPattern(5);

/* 
The pattern you've shown is a number matrix that follows a specific rule: it starts with 5s on the border and decreases by 1 as you move inward, creating a concentric pattern.
Let's understand how the code works:

The function takes a parameter n (in this case 5) which determines the size and maximum number in the pattern.
The nested loops:

for (let i = 0; i < 2 * n - 1; i++) {
  for (let j = 0; j < 2 * n - 1; j++) {

Creates a 9x9 grid (when n=5) because 2*5-1 = 9
i represents rows, j represents columns

For each position (i,j), the code calculates four distances:

let top = i;                  // Distance from top
let bottom = j;               // Distance from left
let right = 2 * n - 2 - j;    // Distance from right
let left = 2 * n - 2 - i;     // Distance from bottom

The key formula:

n - Math.min(Math.min(top, bottom), Math.min(left, right))

This determines what number to print at each position by:

Finding the minimum distance to any border (top, bottom, left, or right)
Subtracting this from n to get the actual number



Let's see an example for position (4,4) (the center):

When i=4, j=4:

top = 4 (distance from top)
bottom = 4 (distance from left)
right = 4 (distance from right)
left = 4 (distance from bottom)
min of all these is 4
5 - 4 = 1 (that's why we get 1 in the center)



This creates the concentric pattern where:

Border positions have minimum distance 0, so they print 5 (5-0)
One step in has minimum distance 1, so they print 4 (5-1)
And so on until the center

The overall effect creates that "pyramid" or "valley" pattern where numbers decrease as you move inward from any direction.

*/
