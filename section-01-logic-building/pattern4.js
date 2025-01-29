/* 

n=4

1
22
333
4444


*/

function printPattern(n) {
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= i; j++) {
      process.stdout.write(i.toString());
    }
    console.log();
  }
}

printPattern(4);
