/* 

1
12
123
1234
12345

*/

function printPattern(n) {
  for (let i = 0; i < n; i++) {
    for (let j = 1; j <= i + 1; j++) {
      process.stdout.write(j.toString());
    }
    console.log();
  }
}

printPattern(5);
