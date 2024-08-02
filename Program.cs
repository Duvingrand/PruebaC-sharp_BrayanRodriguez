
using PruebaC_sharp_BrayanRodriguez.Models;

Storage.AddCustomer(new Customer("Juan", "Cardenaz", "CC", "102547786", 2003, 12, 24, "nacopendejo@gmail.com", "3548851547","Calle 32*", "1","Tarjeta"));
Storage.AddCustomer(new Customer("Ana", "García", "CC", "103456789", 1987, 03, 15, "ana.garcia@email.com", "3123456789", "Avenida Libertador", "2", "Efectivo"));
Storage.AddCustomer(new Customer("Carlos", "Hernández", "CC", "104567890", 1992, 07, 22, "carlos.hernandez@email.com", "3109876543", "Calle 45", "2", "Transferencia"));
Storage.AddCustomer(new Customer("Marta", "López", "CC", "105678901", 1985, 11, 05, "marta.lopez@email.com", "3112345678", "Calle del Sol", "1", "Tarjeta"));
Storage.AddCustomer(new Customer("Pedro", "Martínez", "CC", "106789012", 1990, 02, 28, "pedro.martinez@email.com", "3145678901", "Calle 78", "3", "Efectivo"));
Storage.AddCustomer(new Customer("Lucía", "Ramírez", "CC", "107890123", 1988, 09, 09, "lucia.ramirez@email.com", "3156789012", "Calle 100", "2", "Transferencia"));


Storage.AddDriver(new Driver("Duvin", "Vinigrand", "CC", "1000442277", 2002, 08,09,"duvingrand@gmail.com", "3215776777", "calle 80b", "203053","B2",2));
Storage.AddDriver(new Driver("Edward", "Correa", "CC", "32918557", 2000, 04, 24, "Edwardcoco@gmail.com"," 321858536","calle 49","356346354","A2",5));

Storage.AddVehicle(new Vehicule("TGD-218", "carro", "2000", "2245", 5));

Storage.ReadAllDriver();