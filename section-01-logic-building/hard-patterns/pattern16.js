function printPattern(n) {
  let asciiValue = 65;
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= i; j++) {
      process.stdout.write(String.fromCharCode(asciiValue));
    }
    asciiValue++;
    console.log();
  }
}

printPattern(5);
