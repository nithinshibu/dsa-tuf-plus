/* 

____*____ i=0,n=4,
___***___
__*****__
_*******_
*********
*********
 *******
  *****
   ***
    *


*/


function printPattern(n) {
    printTop(n);
    printBottom(n);
}

function printTop(n) {
    for (let i = 0; i < n; i++) {
        for (let j = 0; j < n - i; j++) {
            process.stdout.write(" ");
        }
        for (let k = 0; k < 2 * i + 1; k++) {
            process.stdout.write("*");
        }
        for (let j = 0; j < n - i; j++) {
            process.stdout.write(" ");
        }
        console.log();
    }
}

function printBottom(n) {
    for (let i = 0; i < n; i++) {
        for (let j = 0; j <= i; j++) {
            process.stdout.write(" ");
        }
        for (let k = 0; k < 2 * n - 1 - 2 * i; k++) {
            process.stdout.write("*");
        }
        for (let j = 0; j <= i; j++) {
            process.stdout.write(" ");
        }
        console.log();
    }
}

printPattern(4);
