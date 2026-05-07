package HomemadeJamCalculatorProgram;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

import java.util.*;

public class ControllerMain {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //Title: A calculator to determine how many jars can be filled per gram of jam.
        
        Scanner input = new Scanner(System.in);
        int T = 0; //Capacity
        int M = -1; //Wildcard variable to break the loop in the quantity
        
        System.out.println("Confectionery IPVG");
        
        //1. Infinite validation for jam capacity in grams
        while(true){
            System.out.print("Enter the jar's capacity in grams, max 1000: ");
            T = input.nextInt();
            
            if (T > 0 && T <= 1000) {
                break;
            } else{
                System.out.println("Error, the value is out of range");
            }
        }
        
        //2. Infinite validation for the amount of jam in grams
        while(true){
            System.out.print("Enter the amount of jam per fruit in grams, max 200: ");
            M = input.nextInt();
            
            if (M >= 0 && M <= 200) {
                break;
            } else{
                System.out.println("Error, the value is out of range");
            }
        }
        
        //3. I call the construct to retrieve the class of JamCalculatorClass
        JamCalculatorClass Jam1 = new JamCalculatorClass(T, M);
        
        System.out.println("\n Daily Fruit Intake");
        
        //4. Infinite loop with a counter for entering fruit quantities, with checks at -1 to break the loop and verify out-of-range values
        //If not show the quantity of jars filled
        int dayCount = 1;
        while(true){
            System.out.print("Day " + dayCount + " - Enter the collected fruits, write -1 to terminate: ");
            int fruits = input.nextInt();
            if (fruits == -1) {
                break;
                
            }
            else if (fruits < -1) { //If the fruit value is less than -1, it would return a negative result, which is an error
                System.out.println("Error, the value is out of range");
            } else{ 
                int jarsPerDay = Jam1.processDay(fruits); //I create a variable to store the class instance named Jam1, and I call the processDay method on it, passing it the value of fruits
                System.out.println("Jars filled today: " + jarsPerDay); //Print the JARS THAT ARE FILLED
                dayCount++;                
            }
        }
        
        //5. PRINT THE LEFTOVER JAM whatever is left over from the class
        System.out.println("\n Final leftover result");
        System.out.println("Leftover jam: " + Jam1.getRemainingJam() + " grams"); //I concatenate the class created as Jam1 and the get method without parameters
        
        //XD
    }
}
