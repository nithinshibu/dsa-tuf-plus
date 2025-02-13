/* 
N = 5, the pattern should look like as below:



**********
****  ****
***    ***
**      **
*        *
*        *
**      **
***    ***
****  ****
**********


N = 5, the pattern should look like as below:


//upper half

**********      i=0     (spaces=0)      (stars=5 on each side  --> n-i)  
****__****      i=1     (spaces=2)      (stars=4)  
***____***      i=2     (spaces=4)      (stars=3)  
**______**      i=3     (spaces=6)      (stars=2)  
*________*      i=4     (spaces=8)      (stars=1)  

// lower half

*________*      i=1     (spaces=8 --> 2 *n - 2 * i)      (stars=1 on each side  --> i)           
**______**      i=2     (spaces=6)                       (stars=2)   
***____***      i=3     (spaces=4)                       (stars=3)
****__****      i=4     (spaces=2)                       (stars=4)
**********      i=5     (spaces=0)                       (stars=5)


*/

function printPattern(n) {
  upperHalfPattern(n);
  lowerHalfPattern(n);
}

function upperHalfPattern(n) {
  for (let i = 0; i < n; i++) {
    for (let j = 0; j < n - i; j++) {
      process.stdout.write("*");
    }
    for (let k = 0; k < i; k++) {
      process.stdout.write(" ");
    }
    for (let k = 0; k < i; k++) {
      process.stdout.write(" ");
    }
    for (let j = 0; j < n - i; j++) {
      process.stdout.write("*");
    }
    console.log();
  }
}

function lowerHalfPattern(n) {
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

printPattern(5);
