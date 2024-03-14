class AllStarPatterns {

    /* 
    Left angle triangle star pattern:
    *
    **
    ***
    ****
    *****
    */
    public static void LeftAngleStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            for(j = 1; j <= i; j++) // Inner loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }

/* 
Right angle triangle star pattern:
    *
   **
  ***
 ****
*****
*/
    public static void RightAngleStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j,k;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(k = 1; k <= i; k++) // Outer loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }

/* 
Pyramid Star Pattern:
    *
   ***
  *****
 *******
*********
*/
    public static void PyramidStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j = 1;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            DiamondPatternInnerLogic(rows, i, j);
            /*
            for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(j = 1; j <= 2*i - 1; j++) // Outer loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
            */
        }
    }

/* Output
Left angle triangle star pattern:
*****
****
***
**
*
*/
    public static void InvertedLeftAngleStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            for(j = i; j <= rows; j++) // Inner loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }

/* Output
Inverted right angle triangle star pattern:
*****
 ****
  ***
   **
    *
*/
    public static void InvertedRightAngleStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j;
        for(i = rows; i >= 1; i--) // Outer loop for number of rows
        {
            for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(j = 1; j <= i; j++) // Outer loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }

/**
Inverted pyramid star pattern
*********
 *******
  *****
   ***
    *
*/
    public static void InvertedPyramidStarPattern() {
        int rows = 5; // number of rows to be printed
        int i, j=1;
        for(i = rows; i >= 1; i--) // Outer loop for number of rows
        {
            DiamondPatternInnerLogic(rows, i, j);
            /*
            for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(j = 1; j <= 2*i - 1; j++) // Outer loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
            */
        }
    }

/**
Diamond star pattern
    *
   ***
  *****
 *******
*********
*********
 *******
  *****
   ***
    *
*/
    public static void DiamondStarPattern() {
        PyramidStarPattern();
        InvertedPyramidStarPattern();  
    }

/*
Parallelogram star pattern
 *****
  *****
   *****
    *****
     *****
*/
    public static void ParallelogramStarPattern(){
        int rows = 5; // number of rows to be printed
        int i,j;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            for(j = 1; j <= i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(j = 1; j <= rows; j++) // Outer loop for number of stars
            {
                Console.Write("*"); // Printing star
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }

    private static void DiamondPatternInnerLogic(int rows, int i, int j){
        for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
        {
            Console.Write(" "); // Printing empty spaces
        }
        for(j = 1; j <= 2*i - 1; j++) // Outer loop for number of stars
        {
            Console.Write("*"); // Printing star
        }
        Console.WriteLine(); //Adding new line to the output
    }
}