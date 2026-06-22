package eval2_swing;

public class Logica {
    
    private final double VALOR_UF = 40240.0;
    
    public String ValidarDatosEntrada(double valor_propiedad_UF, double pie_UF){
        if (valor_propiedad_UF < 1500 || valor_propiedad_UF > 5000) {
            return "Error: El valor de la propiedad debe estar entre 1500 y 5000 UF.";
        }
        
        double diezPorCientoPropiedad = valor_propiedad_UF * 0.10;
        
        if (pie_UF < diezPorCientoPropiedad) {
            return "Error: El ahorro (Pie) debe ser de al menos el 10% del valor de la propiedad.";
        }
        
        return "Aprobado: Datos iniciales válidos.";
    }
    
    public double calcularMontoAFinanciar(double valor_propiedad_UF, double pie_UF) {
        double monto = valor_propiedad_UF - pie_UF;
        return monto;
    }

    public double calcularCuotaPesos(double monto_a_financiar_UF, int plazo_year) {
        
        int plazo_meses = plazo_year * 12;
        
        double cuota = (monto_a_financiar_UF / plazo_meses) * VALOR_UF;
        
        return cuota;
    }
    
    public String evaluarAprobacionDirecta(double valor_propiedad_UF, double pie_UF, double cuota_pesos, double sueldo_liquido) {
    
    double porcentaje_pie = (pie_UF / valor_propiedad_UF) * 100;
    
    double porcentaje_cuota = (cuota_pesos / sueldo_liquido) * 100;
    
    if (porcentaje_pie >= 20 && porcentaje_cuota <= 25) {
        
        return "Felicidades: Crédito Pre-Aprobado (Bajo Riesgo)";
    } else {
        
        return "No cumple aprobación directa. Se requiere evaluar Complemento.";
        }
    }
    
    public String evaluarComplementoRenta(double cuota_pesos, double sueldo_titular, double sueldo_aval) {
    
    double sueldo_total = sueldo_titular + sueldo_aval;
    
    double porcentaje_cuota_total = (cuota_pesos / sueldo_total) * 100;
    
    if (porcentaje_cuota_total <= 25) {
        return "Aprobado con Complemento de Renta";
    } else {
        return "Rechazado: Capacidad de pago insuficiente";
        }
    }
}
