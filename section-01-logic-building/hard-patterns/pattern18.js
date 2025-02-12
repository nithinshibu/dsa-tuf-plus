/* 
N = 5, the pattern should look like as below:



E           i=1

D E         i=2

C D E       i=3

B C D E     i=4 

A B C D E   i=5


Starting from A (ascii = 65)

i=1 , ascii starting should be  = 69 (E) ==> A + (n - i) ==> 65 + (5 -1) = 69
i=2, ascii starting should be =68(D)


*/

function printPattern(n) {
  let asciiValue = 65;
  for (let i = 1; i <= n; i++) {
    asciiValue = asciiValue + (n - i);
    for (let j = 1; j <= i; j++) {
      process.stdout.write(String.fromCharCode(asciiValue++) + " ");
    }
    asciiValue = 65;
    console.log();
  }
}

printPattern(5);
