// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] nums = new int[8];
// int mas = 0;

// mas = new Random();
// nums[0] = new Random();
// nums[1] = 10;
// nums[2] = 100;
// nums[3] = 18;
// nums[4] = 78;
// nums[5] = 23;
// nums[6] = 63;
// nums[7] = 9;
// nums[8] = 87;
// nums[9] = 49;

int[] array = new int[8];
Random Rand = new Random();
for (int x = 0; x < 8; x++)
{
     array[x] = Rand.Next(1, 9);
}