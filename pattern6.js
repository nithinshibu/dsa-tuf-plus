/* 


1234
123
12
1


*/
function printPattern(n) {
  for (let i = 1; i < n; i++) {
    for (let j = 1; j < n - i + 1; j++) {
      process.stdout.write(j.toString());
    }
    console.log();
  }
}

printPattern(5);
