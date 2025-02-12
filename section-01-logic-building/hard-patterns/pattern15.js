/* 

N = 5, the pattern should look like as below:



ABCDE

ABCD

ABC

AB

A

*/

function printPattern(n) {
  let asciiValue = 65;
  for (let i = 1; i <= n; i++) {
    for (let j = n; j >= i; j--) {
      process.stdout.write(String.fromCharCode(asciiValue));
      asciiValue++;
    }
    asciiValue = 65;
    console.log();
  }
}

printPattern(5);
