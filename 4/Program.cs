////многомерные массивы

//string[,] table = new string [2, 5];
//String.Empty - инициализация строки
//table[0,0]  table[0,1]  table[0,2]  table[0,3] table[0,4]
//table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
    //for (int columns = 0; columns < 5; columns++)
    //{
    //    Console.WriteLine($"-{table[rows, columns]}-");
  //  }
//}
//void PrintArray(int [,] mart)
//{
 //for (int i = 0; i < mart.GetLength(0); i++)   //// matrix.GetLength(0) - кол-во строк
 //{
     //for (int j = 0; j < mart.GetLength(1); j++)  ///matrix.GetLength(1) - кол-во столбов
     //{
       //  Console.Write($"{mart[i, j]} ");
     //}
   //  Console.WriteLine();
 //}
//}
//void FillArray(int[,] mart)
//{
    //for (int i = 0; i < mart.GetLength(0); i++)
    //{
        //for (int j = 0; j < mart.GetLength(1); j++)
        //{
      //      mart[i,j] = new Random().Next (1,10);
    //    }
  //  }
//}

//int[,] martrix = new int[3, 4];
//PrintArray(martrix);
//FillArray(martrix);
//Console.WriteLine();
//PrintArray(martrix);


/////////Двухмерный массив и рекурсия - Предоставить черно белое изщбражение
/////int[,]pic = new int[23,25];  0 - закрашеный пиксель, 1 - незакрашеный

///int[,] pic = new int [23,25]{здесь должен быть рисунок};
//void PrintImage(int[,] image)
//{
    //for (int i = 0; i < image.GetLength(0); i++)
    //{
        //for (int j = 0; j < image.GetLength(1); j++)
        //{
          /////////////напоминание  ///Console.Write($"{image[i, j]} ");
          //  if (image[i,j] == 0) Console.Write($" ");
        //    else Console.Write($"+");
      //  }
    //    Console.WriteLine();
  //  }
//}
//void FillImage(int row, int col)  /// точка отсчета
//{
   //if (pic[row,col] == 0)
   //{
    //pic[row,col] = 1;    ///закраска 1ей
    //FillImage (row -1,col);               //// повторный вызов с другимвыбром точки(проверка в верх)
    //FillImage (row ,col-1);   //// в лево
    //FillImage (row +1,col);    /// вниз
    //FillImage (row ,col+1);   /// в паво
    //FillImage (row -1,col);  ///
  // }
//}

//PrintImage(pic);
//FillImage(13,13);
//PrintImage(pic);
///// нет рисунка для закраски


////////  Рекурсия (факториал) "!"- произведение чисел от 1 до задоного
////////   например факториал из 5и   5!=5*4*3*2*1 или 5*4!,4*3!,3*2!,2*1

//double Factorial(int n)
//{
    /////////////////// 1! = 1, 0!= 1
   // if(n == 1) return 1;
  //  else return n * Factorial(n-1);
//}
//for (int i = 1; i < 40; i++)
//{
  //  Console.WriteLine($"{i}! = {Factorial(i)}");
//}

//////  рекурсия фибоначчи(каждое следующее число задается через предыдущее)
////  f(1) = 1, f(2) = 1.  f(n) = f(n-1)+ f(n-2)

//double Fibonacci(int n)
//{
  //if(n == 1 || n == 2) return 1;
  //else return Fibonacci(n-1) + Fibonacci(n-2);
//}
//for (int i = 1; i < 40; i++)
//{
  //Console.WriteLine(Fibonacci(i));
//}

/////////// Зайти в директорию.Обойти все директорий внутри


