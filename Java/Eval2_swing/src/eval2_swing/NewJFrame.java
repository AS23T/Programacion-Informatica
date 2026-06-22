package eval2_swing;

public class NewJFrame extends javax.swing.JFrame {
    
    private static final java.util.logging.Logger logger = java.util.logging.Logger.getLogger(NewJFrame.class.getName());

    public NewJFrame() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jTextField_ValorUFPropiedad = new javax.swing.JTextField();
        jTextField_AhorroPrevioUFPie = new javax.swing.JTextField();
        jTextField_SueldoLiquidoMensual = new javax.swing.JTextField();
        jTextField_PlazoAñosCredito = new javax.swing.JTextField();
        jLabel_Mensaje1 = new javax.swing.JLabel();
        jButton_Calcular1 = new javax.swing.JButton();
        jLabel_MontoAFinanciarUF = new javax.swing.JLabel();
        jLabel_CuotaEnPesos = new javax.swing.JLabel();
        jLabel_Mensaje2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jTextField_ValorUFPropiedad.setText("ValorUFPropiedad");

        jTextField_AhorroPrevioUFPie.setText("AhorroPrevioUFPie");

        jTextField_SueldoLiquidoMensual.setText("SueldoLiquidoMensual");

        jTextField_PlazoAñosCredito.setText("PlazoAñosCredito");

        jLabel_Mensaje1.setText("Mensaje");

        jButton_Calcular1.setText("Calcular");
        jButton_Calcular1.addActionListener(this::jButton_Calcular1ActionPerformed);

        jLabel_MontoAFinanciarUF.setText("MontoAFinanciarUF");

        jLabel_CuotaEnPesos.setText("CuotaEnPesos");

        jLabel_Mensaje2.setText("Mensaje1");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel_Mensaje1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(57, 57, 57)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addComponent(jButton_Calcular1, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jTextField_SueldoLiquidoMensual, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel_MontoAFinanciarUF, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 38, Short.MAX_VALUE)
                                .addComponent(jTextField_ValorUFPropiedad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addGap(0, 0, Short.MAX_VALUE)
                                .addComponent(jTextField_PlazoAñosCredito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel_CuotaEnPesos, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(18, 18, 18)
                                .addComponent(jTextField_AhorroPrevioUFPie, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel_Mensaje2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextField_ValorUFPropiedad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel_MontoAFinanciarUF))
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jTextField_AhorroPrevioUFPie, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(10, 10, 10)
                        .addComponent(jLabel_CuotaEnPesos)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jTextField_SueldoLiquidoMensual, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton_Calcular1, javax.swing.GroupLayout.PREFERRED_SIZE, 49, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(jTextField_PlazoAñosCredito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 64, Short.MAX_VALUE)
                .addComponent(jLabel_Mensaje2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel_Mensaje1)
                .addGap(18, 18, 18))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton_Calcular1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton_Calcular1ActionPerformed
        try {
            double valor_propiedad = Double.parseDouble(jTextField_ValorUFPropiedad.getText());
            double valor_pie = Double.parseDouble(jTextField_AhorroPrevioUFPie.getText());
            double sueldo_liquido = Double.parseDouble(jTextField_SueldoLiquidoMensual.getText());
            int plazo_years = Integer.parseInt(jTextField_PlazoAñosCredito.getText());

            Logica logica_uno = new Logica();

            String mensaje_validacion = logica_uno.ValidarDatosEntrada(valor_propiedad, valor_pie);
            jLabel_Mensaje1.setText(mensaje_validacion);

            if (mensaje_validacion.contains("Error")) {
                jLabel_Mensaje1.setForeground(java.awt.Color.RED);
                jLabel_Mensaje2.setText("");
                return;
            } else {
                jLabel_Mensaje1.setForeground(java.awt.Color.GREEN);
            }

            double monto_financiar = logica_uno.calcularMontoAFinanciar(valor_propiedad, valor_pie);
            double cuota_mensual = logica_uno.calcularCuotaPesos(monto_financiar, plazo_years);

            jLabel_MontoAFinanciarUF.setText(String.format("Monto a financiar: %.2f UF", monto_financiar));
            jLabel_CuotaEnPesos.setText(String.format("Cuota: $ %.0f", cuota_mensual));

            String resultado_directo = logica_uno.evaluarAprobacionDirecta(valor_propiedad, valor_pie, cuota_mensual, sueldo_liquido);

            if (resultado_directo.contains("Felicidades")) {
                jLabel_Mensaje2.setText(resultado_directo);
                jLabel_Mensaje2.setForeground(java.awt.Color.BLUE);

            } else {
                jLabel_Mensaje2.setText("Evaluando complemento...");
                jLabel_Mensaje2.setForeground(java.awt.Color.ORANGE);

                String input_aval = javax.swing.JOptionPane.showInputDialog(this,
                        "Capacidad individual insuficiente.\nIngrese Sueldo Líquido del Cónyuge/Aval:");

                if (input_aval != null && !input_aval.trim().isEmpty()) {
                    double sueldo_aval = Double.parseDouble(input_aval);

                    String resultado_complemento = logica_uno.evaluarComplementoRenta(cuota_mensual, sueldo_liquido, sueldo_aval);
                    jLabel_Mensaje2.setText(resultado_complemento);

                    if (resultado_complemento.contains("Aprobado")) {
                        jLabel_Mensaje2.setForeground(java.awt.Color.GREEN);
                    } else {
                        jLabel_Mensaje2.setForeground(java.awt.Color.RED);
                    }

                } else {
                    jLabel_Mensaje2.setText("Rechazado: Evaluación cancelada o Aval no ingresado.");
                    jLabel_Mensaje2.setForeground(java.awt.Color.RED);
                }
            }
            
            
        } catch (NumberFormatException e) {
            jLabel_Mensaje1.setText("Error: Por favor, ingrese solo números válidos en todas las casillas.");
            jLabel_Mensaje1.setForeground(java.awt.Color.RED);

            jLabel_Mensaje2.setText("");
            jLabel_MontoAFinanciarUF.setText("MontoAFinanciarUF");
            jLabel_CuotaEnPesos.setText("CuotaEnPesos");
            
            
        }
        
        
        
        
        
    }//GEN-LAST:event_jButton_Calcular1ActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ReflectiveOperationException | javax.swing.UnsupportedLookAndFeelException ex) {
            logger.log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(() -> new NewJFrame().setVisible(true));
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton_Calcular1;
    private javax.swing.JLabel jLabel_CuotaEnPesos;
    private javax.swing.JLabel jLabel_Mensaje1;
    private javax.swing.JLabel jLabel_Mensaje2;
    private javax.swing.JLabel jLabel_MontoAFinanciarUF;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JTextField jTextField_AhorroPrevioUFPie;
    private javax.swing.JTextField jTextField_PlazoAñosCredito;
    private javax.swing.JTextField jTextField_SueldoLiquidoMensual;
    private javax.swing.JTextField jTextField_ValorUFPropiedad;
    // End of variables declaration//GEN-END:variables
}
