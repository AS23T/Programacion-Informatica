package mariobrossproblem;

import java.util.*;

public class MARIOBROSSProblem {

    public static void main(String[] args) {
        
        //Constructor for the Scanner system class with a single input
        Scanner input = new Scanner(System.in);
        
        //Input of an integer representing N walls
        System.out.println("Enter the N walls for Mario (0 < N <= 50):\n");
        
        //Input validation when you don't have an integer
        while(!input.hasNextInt()){
            System.out.println("Error, enter numbers only");
            input.next();
        }
        int N = input.nextInt();
        
        //Input range validation for the Errors
        while(N <= 0 || N > 50) {
            System.out.println("Error, out of range. Try again:");
            
            //Input validation when you don't have an integer
            while(!input.hasNextInt()) { 
                System.out.println("Error, enter numbers only");
                input.next();
            }
            
            N = input.nextInt();
        }
        
        //Integer array constructor with the heights in the N walls
        int[] elevations = new int[N];
        
        System.out.println("Enter the heights for the walls (0 < heights <= 10)");
        //For integers where i (the index) equals 0, i must be less than N, and i must be incremented by 1 in each cycle
        for (int i = 0; i < N; i++) {
            //Shows wich position are you in
            System.out.println("Enter height for N walls" + (i + 1) + ":");
            
            while(!input.hasNextInt()) { 
                System.out.println("Error, enter numbers only");
                input.next();
            }
            
            //Local variable h to use it freely
            int h = input.nextInt();
            
            //Input range validation for the Errors
            while(h <= 0 || h > 10) {
                System.out.println("Error, height is out of range. Try again:");
                
                while (!input.hasNextInt()) {
                    System.out.println("Error, enter numbers only");
                    input.next();
                }
                
                h = input.nextInt();
            }
            //By variable, entries of heights in i
            elevations[i] = h;
        }
        
        //Constructor of the AnalyzeJumps class as an analyzer
        AnalyzeJumps analyzer = new AnalyzeJumps();
        //I call the Result class to assign it as a value, using the analyzer to call the analyze method of the AnalyzeJumps class, and pass it the input data elevations
        Result result = analyzer.analyze(elevations);
        
        //I print the result of the operation on a single line, assigning it the value of a method using get
        System.out.println("Up jumps made " + result.getUpJumps() + " Down jumps made " + result.getDownJumps());
        
    }
}
