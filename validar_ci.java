public static Boolean validarCI(String CI) {
        try {
            int[] arrayCoeficientes = new int[]{2, 9, 8, 7, 6, 3, 4};
            int sumaDigitos = 0;
            int digVerificador = 0;
            if (CI.length() == 7 || CI.length() == 8) {
                if (CI.length() == 7) {
                    CI = '0' + CI;
                }
                for (int i = 0; i < 7; i++) {
                    sumaDigitos = sumaDigitos + (arrayCoeficientes[i] * Integer.parseInt(CI.substring(i, i + 1)));
                }
                digVerificador = (sumaDigitos % 10 == 0) ? (sumaDigitos % 10) : (10 - (sumaDigitos % 10));

            } else {
                return false;
            }
            if (CI.equals("0000000") || CI.equals("00000000")) {
                return false;
            } else if (digVerificador == Integer.parseInt(CI.substring(7, 8))) {
                return true;
            } else {
                return false;
            }

        } catch (Exception e) {
            return false;
        }
    }