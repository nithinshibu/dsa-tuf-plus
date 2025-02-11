/* 

n=5

1        1  i=1     (spaces=8)
12      21  i=2     (spaces=6)
123    321  i=3     (spaces=4)
1234  4321  i=4     (spaces=2)
1234554321  i=5     (spaces=0) 

Here the combination of printing will be numbers -> spaces -> numbers for every line

We can see that the numbers are aligning with the value of i (i--> n)

Line 01 : 1 (i=1)
Line 02 : 1 2 (i=2) and so on  (j---> i)

So 1st set of numbers will be in (j---> i) and the 2nd set of numbers are in reverse order (j=i-->1)


Now for the spaces calculation , i= 1 , space = 8 , n= 5 , so (2 * n - 2 * i)

--> 2 * 5 - 2 * 1 = 8 

*/

function printPattern(n) {
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j <= i; j++) {
      process.stdout.write(j.toString());
    }
    for (let j = 1; j <= 2 * n - 2 * i; j++) {
      process.stdout.write(" ");
    }
    for (let j = i; j >= 1; j--) {
      process.stdout.write(j.toString());
    }
    console.log();
  }
}

printPattern(5);
