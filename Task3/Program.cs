//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:



        int[,] matrix1 = { {2, 4}, {3, 2} };
        int[,] matrix2 = { {3, 4}, {3, 3} };

        int rowCount1 = matrix1.GetLength(0);
        int colCount1 = matrix1.GetLength(1);
        int colCount2 = matrix2.GetLength(1);

        int[,] result = new int[rowCount1, colCount2];

        
        if (colCount1 != matrix2.GetLength(0)) {
            Console.WriteLine("Матрицы несовместимы для умножения!");
        }
        else {
            for (int i = 0; i < rowCount1; i++) {
                for (int j = 0; j < colCount2; j++) {
                    for (int k = 0; k < colCount1; k++) {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("Результирующая матрица:");
            for (int i = 0; i < rowCount1; i++) {
                for (int j = 0; j < colCount2; j++) {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    



