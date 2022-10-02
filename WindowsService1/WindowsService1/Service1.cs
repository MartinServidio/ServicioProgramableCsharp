using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Timers;

namespace Servicio1
{
    public partial class Service1 : ServiceBase
    {
        public System.Timers.Timer TimerServicio = new System.Timers.Timer();

        protected override void OnStart(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\DiaHoraInter.txt");
            string dia = lines[0];
            string hora = lines[1];
            string intervalo = lines[2];
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            String horaAct = DateTime.Now.ToString("HH:mm");

            TimerServicio = new System.Timers.Timer();
            TimerServicio.Elapsed += (_, __) => EjecutaUnaAccion();

            if (dia=="Lunes")
            {
                if (wk == DayOfWeek.Monday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Martes")
            {
                if (wk == DayOfWeek.Tuesday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Miercoles")
            {
                if (wk == DayOfWeek.Wednesday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Jueves")
            {
                if (wk == DayOfWeek.Thursday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Viernes")
            {
                if (wk == DayOfWeek.Friday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Sabado")
            {
                if (wk == DayOfWeek.Saturday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
            else if (dia == "Domingo")
            {
                if (wk == DayOfWeek.Sunday)
                    do
                    {
                        horaAct = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaAct != hora);
                TimerServicio.Start();
            }
        }

        public void EjecutaUnaAccion()
        {
            int i;
            for (i = 1; i <= 10; i++)
            { 
                File.AppendAllText(@"D:\INFORME.TXT", "LINEA: " + i + System.Environment.NewLine);
            }
            TimerServicio.Close();
    
        }
        protected override void OnStop()
        {
            TimerServicio.Close();
        }
        protected override void OnPause()
        {
            TimerServicio.Stop();
        }

        protected override void OnContinue()
        {
            TimerServicio.Start();
        }
    }
}

