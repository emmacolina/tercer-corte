using System;

namespace tercer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int ActividadPerro = 0;
            double peso = 0.0;
            int opcion = 0;
            int edad = 0;
                       
            do{
            	
            	Console.WriteLine("Bienvenidos a Programa para la nutrición de perros, tanto adultos");
            	Console.WriteLine("como cachorros, permita transformar la tabla de porciones de alimentos,");
            	Console.WriteLine("donde sólo indicando peso, actividad y edad del canino, muestre la cantidad");
            	Console.WriteLine("de alimentos en (gramos) debe comer el perro.\n\n");
            	
            	Console.WriteLine("Para Adulto presione 1, para Cachorro presione 2:");
                dato = Console.ReadLine();
                edad = Convert.ToInt32(dato);
                if (edad==1)
            	 {
            	
            	Console.WriteLine("Adulto");
            	
            	           
                Console.WriteLine("¿Cual es el peso de su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Tamaño Miniatura
                if(peso <= 5 && peso >= 2) 
                  {
                        switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60-115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55-100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45-85 gramos.");
                            break;
                         }
                 }       
                                
                //Pequeño
	                if (peso <= 10 && peso >=6)
	                   {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 115-190 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 100-170 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 85-145 gramos.");
	                                            break;
									 }                               		
	                              }
	                
	                //Mediano
	                 if (peso <= 15 && peso >=11)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 190-255 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 170-225 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 145-195 gramos.");
	                                            break;
									 }                               		
	                              }
	                
	                 //Grande1
	                 if (peso <= 25 && peso >=16)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 255-380 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 225-330 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 195-285 gramos.");
	                                            break;
									 }                               		
	                              }
	                
	                 //Grande2
	                 if (peso <= 40 && peso >=26)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 380-535 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 330-475 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 285-410 gramos.");
	                                            break;
									 }                               		
	                              }
	                 
	                  //Grande3
	                 if (peso <= 55 && peso >=41)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 525-680 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 475-600 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 285-410 gramos.");
	                                            break;
									 }                               		
	                              }
	                 
	                 //Grande4
	                 if (peso <= 70 && peso >=56)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 680-820 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 600-720 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 520-620 gramos.");
	                                            break;
									 }                               		
	                              }
	                 
	                 //Grande5
	                 if (peso <= 90 && peso >=71)
	                     {
	                          		  switch (ActividadPerro) {
	                                   case 1:
	                                            Console.WriteLine("Su perro debe comer entre 820-995 gramos de alimento.");
	                                            break;
	                                        case 2:
	                                            Console.WriteLine("Su perro debe comer entre 720-870 gramos.");
	                                            break;
	                                        case 3:
	                                            Console.WriteLine("Su perro debe comer entre 620-750 gramos.");
	                                            break;
									 }                               		
	                              }
	          }
                
                
                //
                 if (edad==2)
            	 {
            	
            	Console.WriteLine("Es Cachorro");
              }  
                //        	
            	           
                Console.WriteLine("¿Cual es el peso de su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Tamaño Miniatura
                if(peso <= 4 && peso >= 2) 
                  {
                        switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro con 2 meses debe comer entre 50 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 60 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 55 gramos de alimento.");
                            break;
                         }
                 }       
                                
                //Pequeño1
	                if (peso <= 9 && peso >=5)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 95 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 110-115 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 110 gramos de alimento.");
                            break;
									 }                               		
	                              }
                
                 //Pequeño2
                  if (peso <= 16 && peso >=10)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 155 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 185-190 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 185 gramos de alimento.");
                            break;
						 }                               		
	                   }
                  
                  //Mediano1
                  if (peso <= 24 && peso >=17)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 270 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 265-285 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 280 gramos de alimento.");
                            break;
						 }                               		
	                   }
                  //Mediano2
                  if (peso <= 32 && peso >=25)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 270 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 350-375 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 370 gramos de alimento.");
                            break;
						 } 
                   }
                  
                 //Mediano3
                 if (peso <= 39 && peso >=26)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 355 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 475-530 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro entre 6-12 meses debe comer entre 530 gramos de alimento.");
                            break;
						 } 
                   }
                 
                 //Grande1
                 if (peso <= 49 && peso >=40)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 405 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 545-625 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Debe mantener balanceada la alimentación de su mascosta.");
                            break;
						 } 
                   }
                 
                 //Grande2
                 if (peso <= 59 && peso >=50)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 450 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3-5 meses debe comer entre 605-685 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Tabla Limite, debe mantener balanceada la alimentación de su mascosta.");
                            break;
						 } 
                   }
                 
                 //Grande3
                 if (peso <= 69 && peso >=60)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 485 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro entre 3 meses debe comer entre 670 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Tabla Limite, debe mantener balanceada la alimentación de su mascosta.");
                            break;
						 } 
                   }
                 
                  //Grande4
                 if (peso <= 89 && peso >=70)
	                   {
	               		  switch (ActividadPerro) {
	                    case 1:
	                        Console.WriteLine("Su perro con 2 meses debe comer entre 580 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Tabla Limite, debe mantener balanceada la alimentación");
                            break;
                        case 3:
                            Console.WriteLine("Tabla Limite, debe mantener balanceada la alimentación de su mascosta.");
                            break;
						 } 
                   }
	            Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);
        }
    }
}
