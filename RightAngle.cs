class RightAngle {
    public static void RightAngleStarPattern() {
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
}