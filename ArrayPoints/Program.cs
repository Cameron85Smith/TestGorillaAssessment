
//int[] my_numbers = new int[] {1, 2, 3, 4, 5};
//int[] my_numbers = new int[] {15, 25, 35};
int[] my_numbers = new int[] {8, 8};



int returnValue = 0;

    foreach (var number in my_numbers)
    {
        if (number % 2 == 0 && number != 8)
            returnValue++;

        else if (number % 2 != 0 && number != 8)
            returnValue += 3;

        else if (number == 8)
            returnValue += 5;
}

System.Console.WriteLine(returnValue);