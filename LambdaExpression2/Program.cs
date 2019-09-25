using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINQ
            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] brojevi2 = { 2, 3, 5, 10 };
            int[] brojevi3 = {2,-3,2,-3,10,12,10 };

            var t3 = brojevi2.Select(b => b + 1).ToList();

            var t4 = brojevi2.Select(b => b + 1).Where(b => b > 2 && b < 10).ToList();

            var t6 = brojevi2.Take(3);

            var t7 = brojevi2.Skip(1).Take(3);

            var t8 = brojevi2.Take(3).Skip(1);

            var t9 = brojevi2.TakeWhile(b => b <= 2); //uzimaj brojeve sve dok je b manje jednako 2

            var t10 = brojevi3.SkipWhile(b => b <= 2); //preskaci sve sto je dva manje jednako dva

            var t11 = brojevi3.OrderBy(b => b); //poredat ce od najmanjeg prema najvecem,slozeni tip podataka
            //postavit po kojem propertiju poredat npr : (b=>b.Cijena);

            var knjige = new List<Knjiga>();
            var t12 = knjige.OrderBy(k => k.Naslov).ThenBy(k => k.Cijena); //provjerit ce naslov i poredat po naslovu abecedno

            var t13 = knjige.OrderByDescending(k => k.Naslov).ThenBy(k => k.Cijena); //descending obrnuto poreda

            var t14 = brojevi3.Distinct(); //pokaze ono sto se ponavlja

            var t15 = brojevi3.Union(brojevi2); //spojit ce sve al nece one koji se ponavljaju dodavat

            var t16 = brojevi3.Intersect(brojevi2); //presjek,dohvati one koji se ponavljaju

            var t17 = brojevi3.Except(brojevi2); //uzet ce sve brojeve u brojevima 3 a izostavit ce one brojeve koji 
            //se nalaze u brojevima 2

            var t18 = brojevi2.Length; //brzo   //cw
            // slicno
            var t19 = brojevi2.Count(); //sporo   //cw

            var t20 = brojevi2.Where(x => x > 2).Count(); //vratit ce sve brojeve koji su veci od 2

            var t21 = brojevi2.Where(x => x > 2).Sum(); //zbroj svih brojeva koji su veci od 2

            var t22 = brojevi2.Where(x => x > 2).Max(); //ispisat najveci broj koji je veci od 2

            var t23 = brojevi2.Min();     //nije lista pa se ispisuje sa console.writeline(t23)

            var t24 = brojevi2.Average(); //prosjek

            var t25 = brojevi2.Concat(brojevi3); //nadodaje 2 liste il dva polja,dobit cemo oboje 

            var t26 = brojevi2.Distinct().OrderBy(x => x);

            var t27 = brojevi3.Distinct().OrderBy(x => x);

            var t28 = t26.SequenceEqual(t27);  //provjerit ce da li su nizovi isti

            var t29 = Enumerable.Range(0, 11).Select(x => x % 2 == 0); //kreira listu brojeva od 0 do 11 i onda dohvaca parne brojeve

            var t30 = Enumerable.Repeat(5, 2); //ponovi broj 5 dva puta
           

            var t31 = brojevi3.All(b => b == 2); //ako su svi brojevi unutar niza jednaki 2 onda ce vratiti true

            var t32 = brojevi3.Any(b =>b == 2); //ako je bilo koji broj unutar niza jednak 2 vrati true

            var t33 = brojevi3.Single();  //vraca jedan broj ako ima jedan broj u nizu,ako nema vraca gresku

            var t34 = brojevi3.Single(x=>x==2); //dohvaca sve elemente koji su dva,ako ima samo jedan takav vraca true,ako ne vraca
            //gresku

            var t35 = brojevi3.SingleOrDefault(x => x == 12); //rusi se ako ima vise od jednog,ako ima jednog ne rusi se

            var t36 = knjige.SingleOrDefault(x=>x.Naslov.Contains("b")); //pronaci ce sve knjige kojima naslov sadrzi slovo b
            // i onda ako ima vise od jedne srusit ce se,ako ima jedna ili nema ni jedna onda ce vratit tu knjigu

            var t37 = knjige.First(x => x.Naslov.Contains("p"));  //proci ce kroz sve knjige i onda ce pogledat naslove
            //i ako naslov sadrzi p napravit ce listu tih knjiga i onda ce uzet prvu sa takve liste

            var t38 = knjige.FirstOrDefault(x => x.Naslov.Contains("p"));

            var t39 = knjige.First(x => x.Naslov.StartsWith("p"));  //dohvati prvu knjigu sa liste knjiga kojima naslov pocinje sa p
            //npr:korisiti se za pretragu

            Console.WriteLine(t35);
            //foreach (var g in t30)
            //{
            //    Console.WriteLine(g);
            //}
            Console.Read();
        }
    }
}
