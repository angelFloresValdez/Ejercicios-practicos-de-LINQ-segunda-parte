using Ejercicios_LINQ_Parte_2;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// var carros = new List<Carro>() {
//         new Carro { Nombre = "Bmw", Año = 2023, FechaFabricacion = new DateTime(2023, 1, 2), Viejo = true },
//         new Carro { Nombre = "Toyota", Año = 2023, FechaFabricacion = new DateTime(2020, 11, 22), Viejo = false },
//          new Carro { Nombre = "Audi", Año = 2023, FechaFabricacion = new DateTime(2023, 12, 31), Viejo = true },
//          new Carro { Nombre = "Nissan", Año = 2015, FechaFabricacion = new DateTime(2015, 05, 02), Viejo = true },        
// };

//ThenBy y ThenByDescending
// var CarrosOrdenadosPorAño=carros.OrderBy(c => c.Año).ThenBy(c=>c.Nombre);
// var CarrosOrdenadosPorAño=carros.OrderBy(c => c.Año).ThenByDescending(c=>c.Nombre);

// foreach (var carro in CarrosOrdenadosPorAño)
// {
//     Console.WriteLine($"{carro.Nombre} Salio en el año {carro.Año}");
// }

//------------------------------------------------------------------------------------

//LINQ Select
//  var Carrito= carros.Select(c=>c.Nombre).ToList();

//   foreach (var car in Carrito)
//          {
//             Console.WriteLine(car);
//          }
//-----------------------------------------------------------------------------------
// var marcasYaños=carros.Select(x=>new {Nombre=x.Nombre,Año=x.Año}).ToList();
//   foreach (var marca in marcasYaños)
//          {
//              Console.WriteLine(marca);
//          }
//-----------------------------------------------------------------------------------
// var NombreYañoDTO=carros.Select(c=>new CarroDTO{Nombre=c.Nombre, Año=c.Año}).ToList();

// var num = Enumerable.Range (1,10).ToList();
// var triplicar=num.Select(numero=>3*numero).ToList();
// foreach (var resultado in triplicar)
// {
//     Console.WriteLine(resultado);
// }

//-----------------------------------------------------------------------------------
// var carroEIndice=carros.Select((c,indice)=>new {carro=c,indice=indice+1,}).ToList();   //si yo no quiero que el indice 
// foreach(var item in carroEIndice)                                                     //empiece desde cero si no de uno
// {                                                                                     //en donde dice indice le pongo +1
//   Console.WriteLine($"{item.indice}) {item.carro.Nombre}");
// }

//------------------------------------------------------------------------------------

//Count  


// var carros = new List<Carro>() {
//                             new Carro { Nombre = "Nissan Gtr", Fallas=true },
//                             new Carro { Nombre = "Merdeces AMG", Fallas=true },
//                             new Carro { Nombre = "Bmw M4", Fallas=false },
//                             new Carro { Nombre = "Nissan Versa", Fallas=false }
//     };

// Console.WriteLine($"La cantidad de carros es {carros.Count()}");

// Console.WriteLine($"La cantidad de carros que tienen fallas {carros.Count(c=>c.Fallas)}");

//------------------------------------------------------------------------------------

//Suma, Max y min 
// using System.Linq;
// var carros = new List<Carro>() {
//               new Carro { Nombre = "Nissan Gtr", Año = 2018, },
//               new Carro { Nombre = "Merdeces AMG", Año = 2022, },
//               new Carro { Nombre = "Bmw M4",Año = 2015, },
//               new Carro { Nombre = "Nissan Versa",Año = 2024, }
//                                 };
// Console.WriteLine($"La suma de los años de los carros es: {carros.Sum(c => c.Año)}");
// Console.WriteLine($"El año Maximo de los carros es {carros.Max(c => c.Año)}");
// Console.WriteLine($"El año Minimo de los carros es {carros.Min(c => c.Año)}");


//      var num=Enumerable.Range(1,25);
//  Console.WriteLine($"La suma de los numeros es {num.Sum()}");

//------------------------------------------------------------------------------------

//Aggregate
// var num =Enumerable.Range(1,10);
// var r=num.Aggregate((x,y)=>x*y);
// Console.WriteLine("El resultado es:"+r);

// var rcvi=num.Aggregate(5,(x,y)=>x*y);
// Console.WriteLine("El resultado con el valor inicial es:"+rcvi);

//------------------------------------------------------------------------------------

//Contains
// var num =Enumerable.Range(1,10);
// var num9=num.Contains(9);
// Console.WriteLine("¿La secuencia contiene el número 9? " + num9);

// var num11=num.Contains(11);
// Console.WriteLine("¿La secuencia contiene el número 11? " + num11);

//------------------------------------------------------------------------------------

//Any

//  var carros = new List<Carro>() {
//                             new Carro { Nombre = "Nissan Gtr", Año = 2018, Fallas=true },
//                             new Carro { Nombre = "Merdeces AMG", Año = 2022,Fallas=false  },
//                             new Carro { Nombre = "Bmw M4",Año = 2015, Fallas=true  },
//                             new Carro { Nombre = "Nissan Versa",Año = 2024,Fallas=false  }
//                               };
// var carromenor= carros.Any(c=>c.Año<2024);
// Console.WriteLine("¿Hay algún carro cuyo año es menor a 2024? " + carromenor);

// var carromayor2024=carros.Any(c=>c.Año>2024);
// Console.WriteLine("¿Hay algún carro cuyo año es mayor a 2024? " + carromayor2024);

//------------------------------------------------------------------------------------

//GroupBy Parte uno
//  var carros = new List<Carro>() {
//                             new Carro { Nombre = "Nissan Gtr", Año = 2018, Fallas=true },
//                             new Carro { Nombre = "Merdeces AMG", Año = 2022,Fallas=false  },
//                             new Carro { Nombre = "Bmw M4",Año = 2015, Fallas=true  },
//                             new Carro { Nombre = "Nissan Versa",Año = 2024,Fallas=false  },
//                             new Carro { Nombre = "Audi R8", Año = 2020, Fallas = false },
//                             new Carro { Nombre = "Toyota Supra", Año = 2021, Fallas = true },
//                             new Carro { Nombre = "Ford Mustang", Año = 2019, Fallas = false }
//                               };

// var carrosfallos= carros.GroupBy(c => c.Fallas);
// foreach (var fallas in carrosfallos)
// {
//     Console.WriteLine($"Grupo de los carros que presentan alguna falla = {fallas.Key}(Total: {fallas.Count()})");
//     foreach (var carro in fallas)
//     {
//         Console.WriteLine($"- {carro.Nombre}");
//     }
// }

//GroupBy Parte 2
// var agrupPorAño = carros.GroupBy(c => (c.Año / 5) * 5);
// foreach (var grupoAño in agrupPorAño)
// {
//     Console.WriteLine($"Grupo de los carros por rango de año {grupoAño.Key}-{grupoAño.Key + 4}"); 

//     foreach (var car in grupoAño)
//     {
//         Console.WriteLine($"- {car.Nombre} (Año: {car.Año})");
//     }
//  }

 //------------------------------------------------------------------------------------

// Join

//  var carros = new List<Carro>() {
//                             new Carro { Nombre = "Gtr", AgenciaId=1 },
//                             new Carro { Nombre = "Mercedes AMG", AgenciaId=2   },
//                             new Carro { Nombre = "Bmw M4", AgenciaId=3   },
//                             new Carro { Nombre = "Versa",AgenciaId=1   },
//                             new Carro { Nombre = "Audi R8", AgenciaId=4  },
//                             new Carro { Nombre = "Supra",AgenciaId=5  },
//                             new Carro { Nombre = "Mustang", AgenciaId=6  }
//                               };

var agencia=new List<Agencia>() 
{
  new Agencia{ Id=1, Name="Nissan Motors"},
  new Agencia{ Id=2, Name="Mercedes Benz"},
  new Agencia{ Id=3, Name="Bmw Motors"},
  new Agencia{ Id=4, Name="Audi Motors"},
  new Agencia{ Id=5, Name="Toyota"},
  new Agencia{ Id=6, Name="Ford"},
  new Agencia{ Id=7, Name="Kia Motors"},
};

// var carroYAgencia=carros.Join(agencia,c=>c.AgenciaId, a=>a.Id,(carros,agencia)=> new 
// {
//     carros=carros,
//     agencia=agencia
// });
// foreach (var grup in carroYAgencia)
// {
//     Console.WriteLine($"{grup.carros.Nombre} Pertenece a la Agencia de {grup.agencia.Name}");
// }

 //------------------------------------------------------------------------------------

// GroupJoin 
// var agenciayCarros= agencia.GroupJoin(carros,a=>a.Id, c=>c.AgenciaId,
// (agencia,carros)=>new {Agencia=agencia,carros=carros});
// foreach (var grup in agenciayCarros)
// {
//     Console.WriteLine($"Los siguientes carros se encuentran la agencia de: {grup.Agencia.Name}");

//     foreach (var carrito in grup.carros)
//     {
//         Console.WriteLine($"- {carrito.Nombre}");
//     }
// }

//------------------------------------------------------------------------------------

// Distinct y DistinctBy

char[] letras = { 'A', 'B', 'C', 'D', 'E','E','E' }; 

var letrasNoRepetidas= letras.Distinct();

//  Console.WriteLine("Letras únicas:");
//         foreach (var letra in letrasNoRepetidas)
//         {
//             Console.WriteLine(letra);
//         }

//  var carros = new List<Carro>() {
//                             new Carro { Nombre = "Gtr", AgenciaId=1 },
//                             new Carro { Nombre = "Mercedes AMG", AgenciaId=2},
//                             new Carro { Nombre = "Bmw M4", AgenciaId=3   },
//                             new Carro { Nombre = "Versa",AgenciaId=1   },
//                             new Carro { Nombre = "Mercedes AMG"},
//                             new Carro { Nombre = "Supra",AgenciaId=5  },
//                             new Carro { Nombre = "Mustang", AgenciaId=6  }
//                               };

// var CarrosSinRepetir=carros.DistinctBy(c=>c.Nombre);
// Console.WriteLine("Carros sin repetir por nombre:");
//         foreach (var carro in CarrosSinRepetir)
//         {
//             Console.WriteLine($"{carro.Nombre}");
//         }

//------------------------------------------------------------------------------------

// Union y UnionBy
char[] letras1 = { 'A', 'B', 'C', 'D', 'E' };

char[] letras2 = { 'A', 'E', 'I', 'O', 'U' };

var UnionLetras=letras1.Union(letras2);

Console.WriteLine("Resultado de la unión de letras:");

        foreach (var letra in UnionLetras)
        {
            Console.WriteLine(letra);
        }


var carros1 = new List<Carro>() {
                            new Carro { Nombre = "Gtr", AgenciaId=1 },
                            new Carro { Nombre = "Mercedes AMG", AgenciaId=2},
                            new Carro { Nombre = "Bmw M4", AgenciaId=3   },
                              };

var carros2=new List<Carro>() {
     new Carro { Nombre = "Versa",AgenciaId=1   },
                            new Carro { Nombre = "Supra",AgenciaId=5  },
                            new Carro { Nombre = "Bmw M4", AgenciaId=3 }          
};

var unionCarros=carros1.UnionBy(carros2, c=> c.Nombre);
 Console.WriteLine("Resultado de la unión de carros:");

        foreach (var carro in unionCarros)
        {
            Console.WriteLine(carro.Nombre);
        }

//------------------------------------------------------------------------------------

// Concat
  char[] letra1 = { 'A', 'B', 'C', 'D', 'E' };
  char[] letra2 = { 'F', 'G', 'H', 'I', 'J' };



var r= letra1.Concat(letra2);
Console.WriteLine("Resultado de la concatenacion:");

        foreach (var letra in r)
        {
            Console.WriteLine(letra);
        }