/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1_ejerciciobombilla;

/**
 *
 * @author Alumnos
 */
public class JavaApplication1_EjercicioBombilla {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //System.out.println("Hola mundo");
        
        Bombilla B1 = new Bombilla();
        
        //B1.Encender();
        B1.Apagar();
        
        //1=calida
        //2=fria
        B1.tipo=1;
        B1.serie=001;
        
        B1.ODetalle();
        
        if (B1.estado==true) {
            System.out.println("Encendida");
        }
        else{
            System.out.println("Apagada");
        }
        
    }
    
}
