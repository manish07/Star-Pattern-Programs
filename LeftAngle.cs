class LeftAngle {
    public static void LeftAngleStarPattern() {
        int rows = 5; // number of rows to be printed
        int i,j,k;
        for(i = 1; i <= rows; i++) // Outer loop for number of rows
        {
            for(j = 1; j <= rows - i; j++) // Inner loop for number of empty spaces
            {
                Console.Write(" "); // Printing empty spaces
            }
            for(k = 1; k <= i; k++) // Outer loop
            {
                Console.Write("*");
            }
            Console.WriteLine(); //Adding new line to the output
        }
    }
}