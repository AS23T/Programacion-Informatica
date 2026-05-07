package HomemadeJamCalculatorProgram;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

public class JamCalculatorClass {
    
    //Encapsulated attributes
    private final int capacityJar;
    private final int fruitJam;
    private int remainingJam;
    
    //Initialize the attributes, assigning an initial value to the remaining jam
    public JamCalculatorClass(int capacityJar, int fruitJam){
        this.capacityJar = capacityJar;
        this.fruitJam = fruitJam;
        this.remainingJam = 0; //Initializer
        
        
    }
    
    //ALL CALCULATIONS and updates using the attributes directly
    
    public int processDay(int amountFruit){ //TO OBTAIN THE FILLED BOTTLES
        //1. Multiply the number of fruits by the jam attribute for each fruit
        int jamOfDay = amountFruit * this.fruitJam;
        
        //2. Add the remaining jam amount + the previous day's jam amount
        this.remainingJam = this.remainingJam + jamOfDay;
        
        //3. Divide the remaining jam by the jar's capacity
        int filledJars = this.remainingJam / this.capacityJar;
        
        //4. I calculate the remaining jam percentage based on the jar's capacity
        this.remainingJam = this.remainingJam % this.capacityJar;
        
        return filledJars;
    }
    
    //The GET function to return the remaining jam attribute in a single-use method
    public int getRemainingJam(){
        return this.remainingJam;
    }
}
