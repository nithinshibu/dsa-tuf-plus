/* 

N = 5, the pattern should look like as below:



*****  
*   *
*   *
*   *
*****

n=5


*****       i=1     printing 5 stars
*   *       i=2     printing 2 star
*   *       i=3     printing 2 star
*   *       i=4     printing 2 star
*****       i=5     printing 5 stars



*/

function printPattern(n) {
  for (let i = 1; i <= n; i++) {
    if (i === 1 || i === n) {
      for (let j = 1; j <= n; j++) {
        process.stdout.write("*");
      }
    } else {
      for (let j = 1; j <= 1; j++) {
        process.stdout.write("*");
      }
      for (let j = 1; j <= n - 2; j++) {
        process.stdout.write(" ");
      }
      for (let j = 1; j <= 1; j++) {
        process.stdout.write("*");
      }
    }
    console.log();
  }
}

printPattern(5);
