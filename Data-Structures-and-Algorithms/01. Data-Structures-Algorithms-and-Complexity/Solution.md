## Data Structures, Algorithms and Complexity Homework

#### What is the expected running time of the following C# code?

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
  
  **Answer**: Assuming that the input array length is `n`, the `for` loop iterates `n` times. The nested `while` loop also iterates `n` times. Ignoring the operations that run in constant time (comparing, incrementing, decrementing etc), the algorithm runs in *O(n^2)*.

#### What is the expected running time of the following C# code?**

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
  **Answer** (assuming matrix of size `n * m`):
  - Worst case (the first column consists of only even numbers) - The algorithm will run in *O(n * m)* time, because for every `n`-th row we iterate `m` numbers.
  - Average case (half of the numbers in the first column are odd/even) - The algorithm will run in *O(n * m/2)* time.
  - Best case (the first column consists of only odd numbers) - The algorithm will run in *O(n)* time, because the inner `for` loop will not be executed.

#### What is the expected running time of the following C# code?

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
  **Answer** (assuming matrix of size `n * m`):
 - Worst case (`CalcSum` is called with zero as a second parameter) - The `for` loop will run in *O(n)* and the recursion will run in *O(m - 1)*, therefore the overall complexity of the algorithm will be *O(n * m)*.
 - Best case (`CalcSum` is called with second parameter `row` where `row` ? [`m` - 1; +8)) - The `for` loop will run in *O(n)* and the recursive call won't be reached at all. The overall complexity will be
 *O(n)*.
 
 