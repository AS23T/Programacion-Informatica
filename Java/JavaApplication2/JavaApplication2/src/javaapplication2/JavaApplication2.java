/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication2;

import java.util.Scanner;
/**
 *
 * @author Alumnos
 */
public class JavaApplication2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /*
        Pedir al usuario un valor numerico entre 0 y 10
        Mostrar las diferentes clasificaciones para cada cantidad
        Si valor no esta entre 0 y 10, imprimir error
        */
        Scanner input = new Scanner(System.in);
        
        System.out.println("Ingrese el nombre de alumno");
        
        String nombre = input.nextLine();
        
        System.out.println("Ingrese calificacion");
        int calificacion = input.nextInt();
        
        if (calificacion<0 || calificacion>10) {
            System.out.println("Error");
            
        }
        else if (calificacion <5){
        
            System.out.println(nombre + " reprobado");
        }
        else if (calificacion>=5 && calificacion>7) {
            System.out.println(nombre + " aprobado");
        
        }
        else if (calificacion>=7 && calificacion<9) {
            System.out.println(nombre + " notable");
        }
        else{
            System.out.println(nombre + " sobresaliente");
        }
        
        
    }
    
}
