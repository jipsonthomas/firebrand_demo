using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo26_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Sheerkhan = new Animal();
            using (Human jenny = new Human(Sheerkhan))
            {
                jenny.Watch();
                Sheerkhan.Run();
                //jenny = null;
            }
            
            
            Sheerkhan.Run();
            Console.ReadKey();
        }
    }
    public class Human : IDisposable
    {
        private Animal _animal;
        private bool isDisposed = false;
        public Human(Animal animal)
        {
            // Constructor with no input is default constructor

            _animal = animal;

        }
        public void UnWatch()
        {
            _animal.OnRun -= animal_OnRun;
        }
        public void Watch()
        {
            _animal.OnRun += animal_OnRun;
        }

        void animal_OnRun(object sender, EventArgs e)
        {
            Console.WriteLine("Scream like a girl and run for your life!!!");
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!this.isDisposed)
            {
                if (isDisposing)
                {
                    // Release Manage resources...
                    this.UnWatch();

                }
                // Release unmanaged resources
                this.isDisposed = true;
            }
        }

        public void Dispose()
        {

            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        // Distructor to dispose the unmanaged code...
        ~Human()
        {
            this.Dispose(false);
        }
    }
    public class Animal
    {
        public event EventHandler OnRun;
        public void Run()
        {
            Console.WriteLine("The animal is running after you!");
            // If somebody listening then raise the event
            if (OnRun != null)
            {
                OnRun(this, new EventArgs());
            }

        }
    }
}
