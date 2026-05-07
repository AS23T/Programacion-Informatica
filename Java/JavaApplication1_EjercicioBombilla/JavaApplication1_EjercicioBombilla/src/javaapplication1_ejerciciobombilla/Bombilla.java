/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javaapplication1_ejerciciobombilla;

/**
 *
 * @author Alumnos
 */
public class Bombilla {
    
    public boolean estado = false;
    public double tipo;
    public int serie;
    
    
    public void Encender(){
        estado = true;
    }
    
    public void Apagar(){
        estado = false;
    }
    
    public void ODetalle(){
        System.out.println("La Bombilla esta" + estado + "Es tipo" + tipo + "la serie" + serie);
    }
}
