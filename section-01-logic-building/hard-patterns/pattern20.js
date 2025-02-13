/* 

N = 5, the pattern should look like as below:



*        *
**      **
***    ***
****  ****
**********
****  ****
***    ***
**      **
*        *


n=5

*        *      i=1     stars=1 (i), space=8 (2*n-2*i)
**      **      i=2     stars=2 (i), space=6 (2*n-2*i)              
***    ***      i=3     stars=3 (i), space=4 (2*n-2*i)      
****  ****      i=4     stars=4 (i), space=2 (2*n-2*i)    
**********      i=5     stars=5 (i), space=0 (2*n-2*i)           

n=4
****  ****      i=1,   stars=4 (n-i+1), space = 2 (2*i)
***    ***      i=2,   stars=3 , space=4
**      **      i=3,   stars=2,  space= 6
*        *      i=4,   stars=1,  space= 8



*/

function printPattern(n) {
  printUpperHalfPattern(n);
  printLowerHalfPattern(n - 1);
}

function printUpperHalfPattern(n) {
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= i; j++) {
      process.stdout.write("*");
    }
    for (let k = 1; k <= 2 * n - 2 * i; k++) {
      process.stdout.write(" ");
    }
    for (let j = 1; j <= i; j++) {
      process.stdout.write("*");
    }
    console.log();
  }
}

function printLowerHalfPattern(n) {
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= n - i + 1; j++) {
      process.stdout.write("*");
    }
    for (let k = 1; k <= 2 * i; k++) {
      process.stdout.write(" ");
    }
    for (let j = 1; j <= n - i + 1; j++) {
      process.stdout.write("*");
    }
    console.log();
  }
}

printPattern(5);
