using System;
using System.Threading;

namespace TrabajoConThreads 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*
            Thread t = new Thread(MetodoSaludo);
            t.Start();
            t.Join(); // Espera a que el hilo t termine antes de continuar

            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();
            t2.Join(); // Espera a que el hilo t2 termine antes de continuar

            Console.WriteLine("Hola alumnos desde thread(O HILO) 1!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 1!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 1!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 1!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 1!");

            */

            // MetodoSaludo();

            /*

            CuentaBancaria cuenta = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                hilosPersonas[i] = new Thread(() => cuenta.RetirarEfectivo(500));
                hilosPersonas[i].Start();
            }

            */

            /*
            
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for(int i =0; i < 5; i++)
                {
                    Console.WriteLine($"Hilo 1 - Iteración {i + 1}");
                    Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
                }

                tareaTerminada.TrySetResult(true); // Indica que la tarea ha terminado
            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hilo 2 - Iteración {i + 1}");
                    Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
                }
            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hilo 3 - Iteración {i + 1}");
                    Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
                }
            });



            hilo1.Start();

            var resultado = tareaTerminada.Task.Result; // Espera a que la tarea se complete

            hilo2.Start();

            hilo3.Start();
            */

            /*

            for(int i = 0; i < 500; i++)
            {
              //  Thread t = new Thread(EjecutarTarea);
               // t.Start();

                ThreadPool.QueueUserWorkItem(EjecutarTarea,i);
            }

            */

            /*

            Task tarea = new Task(EjecutarTareaDos);

            tarea.Start();
            */
            Task tarea = Task.Run(() => EjecutarTareaDos());
            Task tarea2 = tarea.ContinueWith((EjecutarOtraTarea));

            /*
            Task tarea2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    var miThread = Thread.CurrentThread.ManagedThreadId;
                    Console.WriteLine($"Thread nº: {miThread} ha comenzado su tarea {i}");
                    Thread.Sleep(1000); // Simula una tarea que tarda 1 segundo
                    Console.WriteLine($"Esta vuelta de bucle corresponde al Thread hilo:" + miThread + "Ejecutandose de4sde el main");
                }
            });

            tarea2.Start();
            */
            Console.ReadLine(); // Mantiene la consola abierta para ver los resultados

        }
        static void EjecutarOtraTarea(Task obj)
        {
            for (int i = 0; i < 100; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread nº: {miThread} ha comenzado su tarea {i}");
                Thread.Sleep(1000); // Simula una tarea que tarda 1 segundo
                Console.WriteLine($"Esta es otra tarea: Esta vuelta de bucle corresponde al Thread :" + miThread);
            }

        }
        static void EjecutarTareaDos()
        {
            for (int i = 0; i < 100; i++)
            {
               var miThread = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread nº: {miThread} ha comenzado su tarea {i}");
                Thread.Sleep(1000); // Simula una tarea que tarda 1 segundo
                Console.WriteLine($"Esta vuelta de bucle corresponde al Thread :" + miThread);
            }

        }   
        static void EjecutarTarea(object state)
        {
            int numeroTarea = (int)state!;
            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha comenzado su tarea {numeroTarea}");
            Thread.Sleep(1000); // Simula una tarea que tarda 1 segundo
            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha terminado su tarea {numeroTarea}");
        }

            static void MetodoSaludo()
        {

            Console.WriteLine("Hola alumnos desde thread(O HILO) 2!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 2!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 2!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 2!");
            Thread.Sleep(1000); // Pausa el hilo durante 1 segundo
            Console.WriteLine("Hola alumnos desde thread(O HILO) 2!");
        }
    }



    class CuentaBancaria
    {
        Double Saldo { get; set; }

        public CuentaBancaria(double saldoInicial)
        {
           this.Saldo = saldoInicial;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine($"No hay suficiente saldo para retirar. Hilo {Thread.CurrentThread.ManagedThreadId}");
                return 0;
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad}. Saldo restante: {Saldo}. Hilo {Thread.CurrentThread.ManagedThreadId}");
                return cantidad;
            }
        }
    }
}
