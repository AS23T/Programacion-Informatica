/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication4;
import java.util.*;
/**
 *
 * @author Alumnos
 */
public class JavaApplication4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        /*
        for (int i = 0; i < 10; i++) {
            System.out.println(i);
        }
        */
        
        try {
            
            Scanner a = new Scanner(System.in);
            
            System.out.println("Ingrese el N factorial");
            int numero = a.nextInt(); //Leo la variable de tipo objeto como entero y lo guardo en numero
            
            double factor = 1;
            
            for (int i = 1; i <= numero; i++) {
                
                factor = factor * i;
                
            }
            
            System.out.println("el factorial de "+ numero + " es igual a "+ factor);
            
        } catch (Exception Ex) { //ArithmeticException para la aritmetica especifica y Exception para un dato basico general
            
            System.out.println("Error, algo salio mal");
        }
    }
    
}
