import javax.swing.*;

public class Sueldo_total {

        public static void main(String[] args) {
            //recibe String de valores numericos brindados por usuario en cuadro de dialogo
            String datos;
            String sexo;
            double sueldo, afp = 0, isss, totalre, nsueldo, renta;

            System.out.println("Calculo de sueldo de Empleado\n");

            //Se ingresan los datos del empleado
            sexo = (String) JOptionPane.showInputDialog(null,
                    "Ingrese el sexo:\nSi es Masculino (M)\nSi es Femenino (F)",
                    "Sexo del Empleado", JOptionPane.QUESTION_MESSAGE,
                    null, //Icono por defecto
                    new Object[]{"M", "F"}, "F"); //opcion por defecto

            //Se da la instruccion de que mensaje debe de aparecer segun la opcion marcada
            if (sexo.equals("M"))
                datos = JOptionPane.showInputDialog(" Ingrese el sueldo del empleado: ");
            else
                datos = JOptionPane.showInputDialog(" Ingrese el sueldo de la empleada: ");
            sueldo = Double.parseDouble(datos);

            //Se declara los porcentajes pedidos en el enunciado
            //Habra retencion por un salario mayor a $472
            if (sueldo > 472) afp = (sueldo * 0.0625); //calcula  la retencion de 6.25% por AFP
            isss = sueldo * 0.03; //ISSS: 3%

            // Calcular renta según los tramos salariales
            if (sueldo > 2038.10) {
                renta = (((sueldo-afp-isss)-2038.10)  * 0.30) +288.57; //renta: 30%
            } else if (sueldo > 895.24) {
                renta = (((sueldo-afp-isss)-895.24)  * 0.20) +60.00; //renta: 20%
            } else if (sueldo > 472) {
                renta = (((sueldo-afp-isss)-472)  * 0.10) +17.67; //renta: 10%
            } else {
                renta = 0; // No hay retencion de renta
            }

            totalre = afp + isss + renta; //suma de retenciones de ley sobre salario
            nsueldo = sueldo - totalre; //salario neto

            if (sexo.equals("M")) datos = "El empleado ";
            else datos = "La empleada ";

            //Se obtiene la informacion ingresada con sus respectivos procedimientos
            JOptionPane.showMessageDialog(null,
                    datos + "tiene un sueldo base de $ " + sueldo +
                            "\n Descuento por AFP de $ " + afp +
                            "\n Descuento por ISSS de $ " + isss +
                            "\n Descuento por Renta de $ " + renta +
                            "\nMonto Total retenido: $ " + totalre +
                            "\nSueldo a pagar es de $" + nsueldo);

            System.out.println("Sueldo base: $" + sueldo +
                    "\n Descuento por AFP de $ " + afp +
                    "\n Descuento por ISSS de $ " + isss +
                    "\n Descuento por Renta de $ " + renta +
                    "\nMonto Total retenido: $ " + totalre +
                    "\nSueldo a pagar es de $" + nsueldo);
        }
    }
