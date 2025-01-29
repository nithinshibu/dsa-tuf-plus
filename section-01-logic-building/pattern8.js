/* 

      * * * * * * *
       * * * * *
         * * * *
            *
    
      n=4 

      i=0   * * * * * * *  (0 spaces) [7 stars]
      i=1   _ * * * * * _  (1 spaces) [5 stars]
      i=2   _ _ * * * _ _  (2 spaces) [3 stars]
      i=3   _ _ _ * _ _ _  (3 spaces) [1 star]

    logic for space --> when i=0 , 0 spaces,when i=1 1 spaces , so inner loop j will go upto -> i       
    logic for star --> (2 * n - 1) - (2 * i)

*/
function printPattern(n) {
  for (let i = 0; i < n; i++) {
    for (let j = 0; j < i; j++) {
      process.stdout.write(' ');
    }

    for (let k = 1; k <= 2 * n - 1 - 2 * i; k++) {
      process.stdout.write('*');
    }
    for (let j = 0; j < i; j++) {
      process.stdout.write(' ');
    }
    console.log();
  }
}

printPattern(4);
