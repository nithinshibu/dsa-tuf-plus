function bubbleSort(array) {

    let n = array.length;
    let swapped = false;

    for (let i = 0; i < n - 1; i++) {
        swapped = false;
        for (let j = 0; j < n - 1 - i; j++) {

            if (array[j] > array[j + 1]) {
                let temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }

        }
        if (!swapped) {
            break;
        }
    }

    array.forEach(element => {
        console.log(element);
    });


}

// bubbleSort([0, 1, 0, 1, 1, 1, 0]);
bubbleSort([5, 1, 7, 3, 9, 10, 2, 0]);



/* 

Notes :- 

Outer Loop (i loop):

Runs n-1 times, where n is the length of the array.

After each iteration, the largest unsorted element "bubbles up" to its correct position.

Inner Loop (j loop):

Compares adjacent elements and swaps them if they are in the wrong order.

The range of the inner loop decreases with each outer loop iteration because the largest elements are already in place.

Optimization (swapped flag):

If no swaps occur during a full pass of the inner loop, the array is already sorted, and the algorithm terminates early.

Time Complexity:
Worst Case: 
O(n^2)(when the array is in reverse order)

Best Case: 
O(n) (when the array is already sorted)

Average Case: 

O(n^2)

Space Complexity:
O(1)
(in-place sorting, no additional memory is used)


What is n - 1 - i?

n is the length of the array.

i is the current iteration of the outer loop.

n - 1 - i ensures that the inner loop does not compare elements that are already in their correct positions.

Why is it needed?

After each outer loop iteration (i), the largest unsorted element "bubbles up" to its correct position at the end of the array.

For example:

After the first iteration (i = 0), the largest element is in the last position.

After the second iteration (i = 1), the second-largest element is in the second-to-last position.

And so on...

The inner loop (j loop) only needs to compare elements up to the last unsorted element.

Since the last i elements are already sorted, there's no need to compare them again.

How does it work?
In the inner loop, j ranges from 0 to n - 1 - i.

This means:

On the first iteration (i = 0), the inner loop compares all n - 1 pairs of adjacent elements.

On the second iteration (i = 1), the inner loop compares only the first n - 2 pairs (because the last element is already sorted).

On the third iteration (i = 2), the inner loop compares only the first n - 3 pairs (because the last two elements are already sorted).


For example :-

The intial array is as given below:-


int[] arr = { 5, 3, 8, 1, 2 };


Iteration 1 (i = 0):

Inner loop runs from j = 0 to j < 4 (n - 1 - i = 5 - 1 - 0 = 4).

[3, 5, 1, 2, 8]  // Largest element (8) is in the correct position

Compares and swaps adjacent elements as needed.

After this iteration, the largest element (8) is in the last position.

Iteration 2 (i = 1):

Inner loop runs from j = 0 to j < 3 (n - 1 - i = 5 - 1 - 1 = 3).

[3, 1, 2, 5, 8]  // Second-largest element (5) is in the correct position

Compares and swaps adjacent elements as needed.

After this iteration, the second-largest element (5) is in the second-to-last position.

Iteration 3 (i = 2):

Inner loop runs from j = 0 to j < 2 (n - 1 - i = 5 - 1 - 2 = 2).

[1, 2, 3, 5, 8]  // Third-largest element (3) is in the correct position

Compares and swaps adjacent elements as needed.

After this iteration, the third-largest element (3) is in the third-to-last position.

Iteration 4 (i = 3):

Inner loop runs from j = 0 to j < 1 (n - 1 - i = 5 - 1 - 3 = 1).

[1, 2, 3, 5, 8]  // Fourth-largest element (2) is in the correct position

Compares and swaps adjacent elements as needed.

After this iteration, the fourth-largest element (2) is in the fourth-to-last position.

Iteration 5 (i = 4):

Inner loop does not run because j < 0 (n - 1 - i = 5 - 1 - 4 = 0).

[1, 2, 3, 5, 8]  // Array is fully sorted

The array is already sorted.

Why is this optimization important?

Without n - 1 - i, the inner loop would always compare all n - 1 pairs, even when some elements are already sorted.

By using n - 1 - i, we reduce the number of unnecessary comparisons, making the algorithm more efficient.



*/