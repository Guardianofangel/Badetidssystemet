using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{

    public class BadetidsPeriode
    {
        // opgave 2
        private string type;
        private DayOfWeek ugeDag;
        private DateTime startTidspunkt;
        private DateTime slutTidspunkt;
        List<Kreds> kredse;

        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            this.type = type;
            this.ugeDag = ugeDag;
            this.startTidspunkt = startTidspunkt;
            this.slutTidspunkt = slutTidspunkt;
            kredse = new List<Kreds>();
        }
        public string Type
        {
            get { return type; }
            set { this.type = value; }      
        }
        public DayOfWeek UgeDag
        {
            get { return UgeDag; }
            set { this.UgeDag = UgeDag; }
        }
        public DateTime StartTidspunkt
        {
            get { return startTidspunkt; }
            set { this.startTidspunkt = value; }
        }
        DateTime SlutTidspunkt
        {
            get { return slutTidspunkt; }
            set { this.slutTidspunkt = value; }
        }
        public override string ToString()
        {
            string result = $"Type Aktivitet : {type}\nUgedag : {ugeDag}\nStarter : {startTidspunkt}\nSlutter : {slutTidspunkt}\n";
            foreach(var a in kredse)
            {
                result += a.ToString();
            }
            return result;

        }
        public void Create(Kreds kreds)
        {
            kredse.Add(kreds);
        }
        public void Remove(string iD)
        {
            foreach (var kreds in kredse)
            {
                if (iD.Equals(kreds.ID))
                {
                    kredse.Remove(kreds);
                   // Console.WriteLine( kreds);
                    break;
                }
            }
        }

    }
    
}
