using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teremfoglalas
{
    abstract class Terem
    {
        public string TeremNev { get; set; }
        public int TeremKapacitas { get; set; }

        protected Terem(string teremnev, int teremkapacitas)
        {
            TeremNev = teremnev;
            TeremKapacitas = teremkapacitas;
        }

        public abstract double ValosKapacitas();
    }

    class EloadoTerem : Terem
    {
        public bool Projektor { get; set; }

        public EloadoTerem(string teremnev, int teremkapacitas, bool projektor) : base(teremnev, teremkapacitas)
        {
            Projektor = projektor;
        }

        public override double ValosKapacitas()
        {
            if (Projektor)
            {
                return TeremKapacitas*1.15;
            }
            else
            {
                return TeremKapacitas;
            }
        }

        public override string ToString()
        {
            var proj = Projektor ? "projektoros" : "projektor nelkuli";
            return $"{TeremNev} Eloado terem; {ValosKapacitas()} hely; {proj}";
        }
    }

    class GepTerem : Terem
    {
        public int GepSzam { get; set; }

        public GepTerem(string teremnev, int teremkapacitas, int gepszam) : base(teremnev, teremkapacitas)
        {
            GepSzam = gepszam;
        }

        public override double ValosKapacitas()
        {
            var kap = TeremKapacitas*0.9 + 10;
            return kap < TeremKapacitas ? kap : TeremKapacitas;
        }

        public override string ToString()
        {
            return $"{TeremNev} Gepterem; {ValosKapacitas()} hely; {GepSzam} szamitogep";
        }
    }

    class SzeminariumTerem : Terem
    {
        public bool KretasTabla { get; set; }

        public SzeminariumTerem(string teremnev, int teremkapacitas, bool kretastabla) : base(teremnev, teremkapacitas)
        {
            KretasTabla = kretastabla;
        }

        public override double ValosKapacitas()
        {
            return KretasTabla ? TeremKapacitas - 6 : TeremKapacitas;
        }

        public override string ToString()
        {
            var tabla = KretasTabla ? "kretas tabla" : "filces tabla";
            return $"{TeremNev} Szeminarium terem; {ValosKapacitas()} hely; {tabla}";
        }
    }
}
