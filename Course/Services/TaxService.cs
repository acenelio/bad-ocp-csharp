using System;

namespace Course.Services {
    class TaxService {

        public double Tax(double amount, string country) {

            if (country == "BRA") {
                if (amount <= 100.00) {
                    return amount * 0.2;
                }
                else {
                    return amount * 0.15;
                }
            }
            else if (country == "USA") {
                return amount * 0.12;
            }
            else {
                throw new ArgumentException("Invalid country");
            }
        }
    }
}
