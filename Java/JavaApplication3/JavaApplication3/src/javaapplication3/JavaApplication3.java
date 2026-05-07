/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication3;
import java.util.*;
/**
 *
 * @author Alumnos
 */
public class JavaApplication3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Random r = new Random();
        Scanner s = new Scanner(System.in);
        
        int numero = r.nextInt(100);
        String respuesta = s.nextLine();
        int intento= 0;
        
        int numerUser;
        
        do {
            System.out.println("Ingrese el numero que pense ");
            numerUser = s.nextInt();
            
            intento++;
        
        if (numero==numerUser) {
            System.out.println("Felicidades adivinaste, intentos = " + intento);
        }
        else{
            if (numerUser> numero) {
                System.out.println("El n es menor");
                
            }
            else{
                System.out.println("El n escogido es mayor");
            }
            System.out.println("Quiere seguir? S o N");
            respuesta = s.next();
        }
        } while (respuesta.equalsIgnoreCase("S"));
        
    }
    
}
