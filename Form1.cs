using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace kalkulator
{
    public class Kompleksni
    {
        public int realni;
        public int imaginarni;

        public Kompleksni() { }

        public Kompleksni(int realni, int imaginarni)
        {
            this.realni = realni;
            this.imaginarni = imaginarni;
        }

        public void konvert(string s)
        {
            char[] znakovi = { '+', '-', '*', '/' };

            string[] niz = s.Split(znakovi, StringSplitOptions.RemoveEmptyEntries);

            if (Int32.TryParse(niz[0], out realni))
            {
                niz[1] = niz[1].Remove(niz[1].Length - 1);
                if (niz[1] == "")
                {
                    imaginarni = 1;
                }
                else
                {
                    imaginarni = Int32.Parse(niz[1]);
                }
                if (s.Contains('-') && (s.IndexOf('-') == 0))
                {
                    realni *= -1;
                    s = s.Remove(0, 1);

                    if (s.Contains('-'))
                    {
                        imaginarni *= -1;
                    }
                }
                else if(s.Contains('-'))
                {
                    imaginarni *= -1;
                }
            }
            else
            {
                realni = 0;
                niz[0] = niz[0].Remove(niz[0].Length - 1);
                if (niz[0] == "")
                {
                    imaginarni = 1;
                }
                else
                {
                    imaginarni = Int32.Parse(niz[0]);
                }
                if(s.Contains('-'))
                {
                    imaginarni *= -1;
                }
            }
        }

        public static Kompleksni operator +(Kompleksni k1, Kompleksni k2)
        {
            return new Kompleksni(k1.realni + k2.realni, k1.imaginarni + k2.imaginarni);
        }

        public static Kompleksni operator -(Kompleksni k1, Kompleksni k2)
        {
            return new Kompleksni(k1.realni - k2.realni, k1.imaginarni - k2.imaginarni);
        }

        public static Kompleksni operator *(Kompleksni k1, Kompleksni k2)
        {
            return new Kompleksni(k1.realni * k2.realni - k1.imaginarni * k2.imaginarni, k1.imaginarni * k2.realni + k1.realni * k2.imaginarni);
        }

        public static Kompleksni operator /(Kompleksni k1, Kompleksni k2)
        {
            Kompleksni pom = new Kompleksni();
            k2.imaginarni *= -1;
            pom = k1 * k2;
            k2.imaginarni *= -1;
            pom.realni /= k2.realni + k2.imaginarni;
            pom.imaginarni /= k2.realni + k2.imaginarni;
            return pom;
        }

        public string ispis()
        {
            string s = Convert.ToString(this.realni);
            if(this.imaginarni >= 0)
            {
                s += "+";
            }

            s += Convert.ToString(this.imaginarni);
            s += "i";

            return s;
        }
    }

    public class Rimski
    {
        public int prvi;

        public Rimski() { }

        public Rimski(int prvi)
        {
            this.prvi = prvi;
        }

        public void konvert(string s)
        {
            char[] niz = s.ToCharArray();
            int[] pom = new int[niz.Length];
            for(int i = 0; i < niz.Length; i++)
            {
                switch(niz[i])
                {
                    case 'I':
                        pom[i] = 1;
                        break;
                    case 'V':
                        pom[i] = 5;
                        break;
                    case 'X':
                        pom[i] = 10;
                        break;
                    case 'L':
                        pom[i] = 50;
                        break;
                    case 'C':
                        pom[i] = 100;
                        break;
                    case 'D':
                        pom[i] = 500;
                        break;
                    case 'M':
                        pom[i] = 1000;
                        break;
                }
            }

            for(int i = 0; i < pom.Length - 1; i++)
            {
                if (pom[i + 1] > pom[i])
                {
                    prvi -= pom[i];
                }
                else
                {
                    prvi += pom[i];
                }
            }
            prvi += pom[pom.Length - 1];
        }

        public static Rimski operator +(Rimski r1, Rimski r2)
        {
            return new Rimski(r1.prvi + r2.prvi);
        }

        public static Rimski operator -(Rimski r1, Rimski r2)
        {
            return new Rimski(r1.prvi - r2.prvi);
        }

        public static Rimski operator *(Rimski r1, Rimski r2)
        {
            return new Rimski(r1.prvi * r2.prvi);
        }

        public static Rimski operator /(Rimski r1, Rimski r2)
        {
            return new Rimski(r1.prvi / r2.prvi);
        }

        public string ispis()
        {
            if ((prvi > 3999) || (prvi < 0))
            {
                return "Broj nije moguce napisati rimskim ciframa";
            }
            else
            {
                char[] niz = new char[50];
                int br = 0;
                int k = 2;
                int mod = 1000;

                while (prvi > 0)
                {
                    if((prvi / mod) > 0)
                    {
                        switch (mod)
                        {
                            case 1000:
                                niz[br] = 'M';
                                break;
                            case 500:
                                niz[br] = 'D';
                                break;
                            case 100:
                                niz[br] = 'C';
                                break;
                            case 50:
                                niz[br] = 'L';
                                break;
                            case 10:
                                niz[br] = 'X';
                                break;
                            case 5:
                                niz[br] = 'V';
                                break;
                            case 1:
                                niz[br] = 'I';
                                break;
                        }

                        prvi -= mod;

                        br++;
                    }
                    else
                    {
                        mod /= k;
                        if(k == 2)
                        {
                            k = 5;
                        }
                        else
                        {
                            k = 2;
                        }
                    }
                }

                int pon = 0;
                char c = 'M';
                string s = "";

                for(int i = 0; i < br; i++)
                {
                    if (niz[i] == c)
                    {
                        pon++;
                    }
                    else
                    {
                        c = niz[i];
                        pon = 1;
                    }

                    if(pon == 4)
                    {
                        pon = 0;
                        switch(c)
                        {
                            case 'C':
                                if (i > 3)
                                {
                                    if (niz[i - 4] == 'D')
                                    {
                                        s = s.Remove(s.Length - 4);
                                        s += "CM";
                                    }
                                    else
                                    {
                                        s = s.Remove(s.Length - 3);
                                        s += "CD";
                                    }
                                }
                                else
                                {
                                    s = "";
                                    s += "CD";
                                }
                                break;
                            case 'X':
                                if (i > 3)
                                {
                                    if (niz[i - 4] == 'L')
                                    {
                                        s = s.Remove(s.Length - 4);
                                        s += "XC";
                                    }
                                    else
                                    {
                                        s = s.Remove(s.Length - 3);
                                        s += "XL";
                                    }
                                }
                                else
                                {
                                    s = "";
                                    s += "XL";
                                }
                                break;
                            case 'I':
                                if(i > 3)
                                {
                                    if (niz[i - 4] == 'V')
                                    {
                                        s = s.Remove(s.Length - 4);
                                        s += "IX";
                                    }
                                    else
                                    {
                                        s = s.Remove(s.Length - 3);
                                        s += "IV";
                                    }
                                }
                                else
                                {
                                    s = "";
                                    s += "IV";
                                }
                                break;
                        }
                    }
                    else
                    {
                        s += Convert.ToString(niz[i]);
                    }
                }
                return s;
            }
        }
    }

    class Dugi
    {
        BigInteger broj;
        int zarez;

        public Dugi() { }

        public Dugi(BigInteger broj, int zarez)
        {
            this.broj = broj;
            this.zarez = zarez;
        }

        public void konvert(string s)
        {
            if(s.Contains(','))
            {
                zarez = s.IndexOf(',');
            }
            else if (s.Contains('.'))
            {
                zarez = s.IndexOf('.');
            }

            s = s.Remove(zarez, 1);

            broj = BigInteger.Parse(s);

            zarez = s.Length - zarez;
        }

        public static Dugi operator +(Dugi d1, Dugi d2)
        {
            if(d1.broj < d2.broj)
            {
                d1.broj *= (BigInteger)Math.Pow(10, (d1.zarez - d2.zarez));
                d1.zarez = d2.zarez;
            }
            else
            {
                d2.broj *= (BigInteger)Math.Pow(10, (d2.zarez - d1.zarez));
            }

            return new Dugi(d1.broj + d2.broj, d1.zarez);
        }

        public static Dugi operator -(Dugi d1, Dugi d2)
        {
            if (d1.broj < d2.broj)
            {
                d1.broj *= 10 ^ (d2.zarez - d1.zarez);
                d1.zarez = d2.zarez;
            }
            else
            {
                d2.broj *= 10 ^ (d1.zarez - d2.zarez);
            }

            return new Dugi(d1.broj - d2.broj, d1.zarez);

        }

        public static Dugi operator *(Dugi d1, Dugi d2)
        {
            return new Dugi(d1.broj * d2.broj, d1.zarez + d2.zarez + 1);
        }

        public static Dugi operator /(Dugi d1, Dugi d2)
        {
            if(d1.broj > d2.broj)
            {
                d1.broj *= (BigInteger)d2.zarez;
                d2.broj *= (BigInteger)d2.zarez;
            }
            else
            {
                d1.broj *= (BigInteger)d1.zarez;
                d2.broj *= (BigInteger)d1.zarez;
            }

            return new Dugi(d1.broj / d2.broj, 0);

        }

        public string ispis()
        {
            if(Convert.ToString(broj).Length <= zarez)
            {
                return Convert.ToString(broj).Insert(0, "0,");
            }
            return Convert.ToString(broj).Insert(Convert.ToString(broj).Length - zarez, ",");
        }
    }

    public partial class Form1 : Form
    {
        private string prvi;
        private string drugi;
        private string znak;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            znak = "+";
            prvi = ulaz.Text;
            ulaz.Text = "";
            ulaz.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            znak = "-";
            prvi = ulaz.Text;
            ulaz.Text = "";
            ulaz.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            znak = "*";
            prvi = ulaz.Text;
            ulaz.Text = "";
            ulaz.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            znak = "/";
            prvi = ulaz.Text;
            ulaz.Text = "";
            ulaz.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            drugi = ulaz.Text;

            if(rbr.Checked)
            {
                Rimski rez = new Rimski();
                Rimski prvi_cinilac = new Rimski();
                Rimski drugi_cinilac = new Rimski();

                prvi_cinilac.konvert(prvi);
                drugi_cinilac.konvert(drugi);


                switch (znak)
                {
                    case "+":
                        rez = prvi_cinilac + drugi_cinilac;
                        break;
                    case "-":
                        rez = prvi_cinilac - drugi_cinilac;
                        break;
                    case "*":
                        rez = prvi_cinilac * drugi_cinilac;
                        break;
                    case "/":
                        rez = prvi_cinilac / drugi_cinilac;
                        break;
                }

                ulaz.Text = rez.ispis();
            }
            else if(rbk.Checked)
            {
                Kompleksni rez = new Kompleksni();
                Kompleksni prvi_cinilac = new Kompleksni();
                Kompleksni drugi_cinilac = new Kompleksni();

                prvi_cinilac.konvert(prvi);
                drugi_cinilac.konvert(drugi);

                switch(znak)
                {
                    case "+":
                        rez = prvi_cinilac + drugi_cinilac;
                        break;
                    case "-":
                        rez = prvi_cinilac - drugi_cinilac;
                        break;
                    case "*":
                        rez = prvi_cinilac * drugi_cinilac;
                        break;
                    case "/":
                        rez = prvi_cinilac / drugi_cinilac;
                        break;
                }

                ulaz.Text = rez.ispis();
            }
            else if(rbd.Checked)
            {
                Dugi prvi_cinilac = new Dugi();
                Dugi drugi_cinilac = new Dugi();
                Dugi rez = new Dugi();

                prvi_cinilac.konvert(prvi);
                drugi_cinilac.konvert(drugi);

                switch (znak)
                {
                    case "+":
                        rez = prvi_cinilac + drugi_cinilac;
                        break;
                    case "-":
                        rez = prvi_cinilac - drugi_cinilac;
                        break;
                    case "*":
                        rez = prvi_cinilac * drugi_cinilac;
                        break;
                    case "/":
                        rez = prvi_cinilac / drugi_cinilac;
                        break;
                }

                ulaz.Text = rez.ispis();
            }

            prvi = "";
            drugi = "";
        }
    }
}