/* 

N = 5, the pattern should look like as below:



1 

0 1 

1 0 1 

0 1 0 1 

1 0 1 0 1

*/

function printPattern(n) {
    let flag = true;
    for (let i = 1; i <= n; i++) {
        for (let k = 1; k <= i; k++) {
            if (flag === true) {
                process.stdout.write("1 ");
            } else {
                process.stdout.write("0 ");
            }
            flag = !flag;

        }
        for (let j = 0; j < n - i; j++) {
            process.stdout.write(" ");
        }
        if (i % 2 === 0) {
            flag = true;
        }
        console.log();
    }

}

printPattern(5);


/* 

Tuf solution:-

class Solution {
    // Function to print pattern11
    pattern11(n) {
        // First row starts by printing a single 1.
        let start = 1;

        // Outer loop for the number of rows
        for (let i = 0; i < n; i++) {
            /* If the row index is even, start 
            with 1; if odd, start with 0 
            if (i % 2 === 0) start = 1;
             
            else start = 0;
        

            /* Alternatively print 1's and 0's 
            in each row by using inner for loop
            let row = "";
            for (let j = 0; j <= i; j++) {
                row += start+" ";
                start = 1 - start;
            }

            // Output the row
            console.log(row);
        }
    }
}

let N = 5;

// Create an instance of Solution class
let sol = new Solution();

sol.pattern11(N);


*/