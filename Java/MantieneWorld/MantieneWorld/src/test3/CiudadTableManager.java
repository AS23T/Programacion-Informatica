/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package test3;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JTable;
import javax.swing.JComboBox;
import javax.swing.table.DefaultTableModel;

public class CiudadTableManager {
    private JTable tabla;
    private DefaultTableModel modelo;

    public CiudadTableManager(JTable tabla) {  // ya no recibe el combo
        this.tabla = tabla;
        inicializarModelo();
    }

    private void inicializarModelo() {
        modelo = new DefaultTableModel() {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        modelo.setColumnIdentifiers(new String[]{"País", "Ciudad", "Habitantes"});
        tabla.setModel(modelo);
    }

    public void cargarPorPais(String pais) {
        modelo.setRowCount(0);  // ya no toca el combo
        creaconexion gc = new creaconexion();
        try {
            Connection cn = gc.obtieneconexion();
            PreparedStatement ps = cn.prepareStatement(
                "SELECT country.Name, city.Name, city.Population " +
                "FROM country, city " +
                "WHERE CountryCode = country.Code AND country.Name = ? " +
                "ORDER BY city.Name ASC"
            );
            ps.setString(1, pais);
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                modelo.addRow(new Object[]{
                    rs.getString("country.Name"),
                    rs.getString("city.Name"),
                    rs.getInt("city.Population")
                });
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }

    public void refrescarFila(String ciudad, int nuevaPoblacion) {
        for (int i = 0; i < modelo.getRowCount(); i++) {
            if (modelo.getValueAt(i, 1).equals(ciudad)) {
                modelo.setValueAt(nuevaPoblacion, i, 2);
                break;
            }
        }
    }

}