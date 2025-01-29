/* 

    n=4

        *
      * * *
    * * * * *
  * * * * * * * 


    n=4
    i=1   _ _ _ * _ _ _   (3 spaces on each side)    [1 star]
    i=2   _ _ * * * _ _   (2 spaces)  [3 stars]
    i=3   _ * * * * * _   (1 spaces)  [5 stars]
    i=4   * * * * * * *   (0 space)   [7 stars]

    which means (n-i) number of spaces
    in case of stars , (2*i-1)


    */

function printPattern(n) {
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= n - i; j++) {
      process.stdout.write(" ");
    }

    for (let k = 1; k <= i * 2 - 1; k++) {
      process.stdout.write("*");
    }

    for (let j = 1; j <= n - i; j++) {
      process.stdout.write(" ");
    }
    console.log();
  }
}

printPattern(4);
