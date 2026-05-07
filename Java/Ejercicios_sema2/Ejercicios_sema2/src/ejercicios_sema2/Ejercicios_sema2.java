/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package ejercicios_sema2;

import java.util.Scanner;

/**
 *
 * @author Alumnos
 */
public class Ejercicios_sema2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner entrada = new Scanner(System.in);
         
        System.out.println("Ingresa tu nombre señor sumador");
        
        String nombre = entrada.nextLine();
        
        
        
        
        System.out.println("ingrese numero 1 : ");
        
        String a1 = entrada.nextLine();
        
        int a = Integer.parseInt(a1);
        
                
        System.out.println("ingrese numero 2 : ");
        
        int b = entrada.nextInt();
        
        int c = a + b;
        
        System.out.println(nombre.toLowerCase() + "la suma de " + a + " + " + b + " es igual a " +c);
                
        /*switch (var) {
            case val:
                
                break;
            default:
                throw new AssertionError();
        }*/
    
    }    
    
}
