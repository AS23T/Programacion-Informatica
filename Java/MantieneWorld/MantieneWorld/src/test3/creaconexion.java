package test3;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Alumnos
 */
public class creaconexion {
    private final String url= "jdbc:mysql://localhost:3306/world";
    private final String user= "root";
    private final String pass= "";
    
    public Connection obtieneconexion() throws SQLException {
    
        Connection cn;
        
        cn = DriverManager.getConnection(url,user, pass);
        
        return cn;
    
    }
    
}
