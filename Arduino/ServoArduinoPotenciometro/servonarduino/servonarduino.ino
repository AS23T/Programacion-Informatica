#include <Servo.h>

Servo escalera;  
//ServoMotor:
///Cable color cafe pin: GND
//Cable color rojo pin: 5V
//Cable color naranja pin: 9

//Botones o Pulsadores simples de 2 pines(Input/Output)
int pinSubir = 2;       // Botón para subir pin: 2, tierra: GND 
int pinBajar = 3;       // Botón para bajar pin: 3, tierra: GND
int pos = 0;            // Comienza en la posición baja
int paso = 2;           // Movimiento gradual (más suave)
int limiteSuperior = 90;  // Ajusta según tu inclinación máxima
int limiteInferior = 5;   // Ajusta según tu posición baja

void setup() {
  escalera.attach(9);           // Pin del servo
  pinMode(pinSubir, INPUT_PULLUP);
  pinMode(pinBajar, INPUT_PULLUP);
  escalera.write(pos);          // Se queda donde lo deje
  delay(200);
}

void loop() {
  if (digitalRead(pinSubir) == LOW && pos < limiteSuperior) {
    pos += paso;
    escalera.write(pos);
    delay(20);
  }

  if (digitalRead(pinBajar) == LOW && pos > limiteInferior) {
    pos -= paso;
    escalera.write(pos);
    delay(20);
  }
}
