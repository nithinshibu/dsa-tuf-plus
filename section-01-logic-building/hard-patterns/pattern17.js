/* 

N = 5, the pattern should look like as below:



____A____  i=1  (spaces =4)  1 character
___ABA___  i=2  (spaces =3)  3 character
__ABCBA__  i=3  (spaces =2)  5 character
_ABCDCBA_  i=4  (spaces =1)  7 character
ABCDEDCBA  i=5  (spaces =0)  9 character

Formula for the spaces is (n-i)

character formula = ( 2 * i - 1 )

*/

function printPattern(n) {
  let asciiValue = 65;
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= n - i; j++) {
      process.stdout.write(" ");
    }
    for (let j = 1; j <= 2 * i - 1; j++) {
      if (j < i) {
        process.stdout.write(String.fromCharCode(asciiValue++));
      } else {
        process.stdout.write(String.fromCharCode(asciiValue--));
      }
    }
    for (let j = 1; j <= n - i; j++) {
      process.stdout.write(" ");
    }
    asciiValue = 65;
    console.log();
  }
}

printPattern(5);
