#include <Servo.h>

Servo escalera;
//Potenciometro:
//pin VCC: 5V
//pin OUT: A0
//pin GND: GND

int pinPot = A0;          // Potenciómetro conectado al pin A0
int pos = 0;              // Posición actual del servo
int limiteSuperior = 75;  // Ángulo máximo
int limiteInferior = 17;   // Ángulo mínimo

void setup() {
  escalera.attach(9);     // Pin del servo
  escalera.write(pos);    // Mantiene la posición inicial
  delay(200);
}

void loop() {
  // Leer el valor del potenciómetro (0–1023)
  int valor = analogRead(pinPot);

  // Convertir el valor del potenciómetro a ángulo (limitado)
  pos = map(valor, 0, 1023, limiteInferior, limiteSuperior);

  // Mover el servo a esa posición
  escalera.write(pos);

  delay(15);  // Pequeña pausa para suavizar el movimiento
}
