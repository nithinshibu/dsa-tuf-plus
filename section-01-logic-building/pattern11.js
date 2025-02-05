/* 

N = 5, the pattern should look like as below:



1 

0 1 

1 0 1 

0 1 0 1 

1 0 1 0 1

*/

function printPattern(n) {
    let flag = true;
    for (let i = 1; i <= n; i++) {
        for (let k = 1; k <= i; k++) {
            if (flag === true) {
                process.stdout.write("1 ");
            } else {
                process.stdout.write("0 ");
            }
            flag = !flag;

        }
        for (let j = 0; j < n - i; j++) {
            process.stdout.write(" ");
        }
        if (i % 2 === 0) {
            flag = true;
        }
        console.log();
    }

}

printPattern(5);