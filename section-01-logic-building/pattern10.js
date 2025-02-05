/* 

N = 5

*____
**___
***__
****_
*****
****_
***__
**___
*____

*/

function printPattern(n) {
    printPatternTop(n);
    printPatternBottom(n);
}

function printPatternTop(n) {
    for (let i = 1; i <= n; i++) {
        for (let k = 1; k <= i; k++) {
            process.stdout.write("*");
        }
        for (let j = 1; j <= n; j++) {
            process.stdout.write(" ");
        }
        console.log();
    }
}
function printPatternBottom(n) {
    for (let i = 1; i <= n; i++) {
        for (let k = 1; k <= n - i; k++) {
            process.stdout.write("*");
        }
        for (let j = 1; j <= i; j++) {
            process.stdout.write(" ");
        }
        console.log();
    }
}

printPattern(5);


/* 

--optimal approach

class Solution {
    //Function to print pattern10
    pattern10(n) {
        // Outer loop for number of rows.
        for (let i = 1; i <= 2 * n - 1; i++) {
           //  stars would be equal to the
            // row no. uptill first half
            let stars = i <= n ? i : 2 * n - i;
            
            // for printing the stars in each row.
            for (let j = 1; j <= stars; j++) {
                process.stdout.write("*");
            }
            
            // As soon as the stars for each iteration are printed,
            //we move to the next row and give a line break
            console.log();
        }
    }
}

let N = 5;

//Create an instance of Solution class
let sol = new Solution();

sol.pattern10(N);


*/