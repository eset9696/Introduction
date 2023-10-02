using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{

	internal class Program
	{
		readonly static string delimeter = "\n-------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Fraction fraction1 = new Fraction( 2, 1, 4);
			fraction1.Print();
			Fraction fraction2 = new Fraction( 1, 2, 4);
			fraction2.Print();
            Console.WriteLine(fraction1 == fraction2);
			Fraction fraction3 = fraction1 + fraction2;
			fraction1.Print();
			fraction2.Print();
			fraction3.Print();

        }
	}
	class Fraction
	{
		private int integer;
		private int numerator;
		private int denominator;

		public int get_integer()
		{
			return integer;
		}
		public int get_numerator()
		{
			return numerator;
		}

		public int get_denominator()
		{
			return denominator;
		}

		public void set_integer(int integer)
		{
			this.integer = integer;
		}

		public void set_numerator(int numerator)
		{
			this.numerator = numerator;
		}

		public void set_denominator(int denominator)
		{
			if(denominator == 0) denominator = 1;
			this.denominator = denominator;
		}

		public Fraction(int numerator, int denominator)
		{
			set_integer(0);
			set_numerator(numerator);
			set_denominator(denominator);
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			set_integer(integer);
			set_numerator(numerator);
			set_denominator(denominator);
		}

		public Fraction(ref Fraction other)
		{
			set_integer(other.get_integer());
			set_numerator(other.get_numerator());
			set_denominator(other.get_denominator());
		}

		public static Fraction operator++(Fraction fraction)
		{
			return new Fraction(fraction.integer + 1, fraction.numerator, fraction.denominator);
		}

		public static Fraction operator --(Fraction fraction)
		{
			return new Fraction(fraction.integer - 1, fraction.numerator, fraction.denominator);
		}

		public static Fraction operator +(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return new Fraction(
				t_left.numerator * t_right.denominator + t_right.numerator * t_left.denominator,
				t_left.denominator * t_right.denominator).ToProper().Reduce();
		}

		public static Fraction operator -(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return new Fraction(
				t_left.numerator * t_right.denominator - t_right.numerator * t_left.denominator,
				t_left.denominator * t_right.denominator).ToProper().Reduce();
		}

		public static Fraction operator *(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return new Fraction(
				t_left.numerator * t_right.numerator,
				t_left.denominator * t_right.denominator).ToProper().Reduce();
		}

		public static Fraction operator /(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return (t_left * t_right.Inverted()).Reduce();
		}

		public static bool operator <(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return t_left.numerator * t_right.denominator < t_right.numerator * t_left.denominator;
		}
		public static bool operator >(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return t_left.numerator * t_right.denominator > t_right.numerator * t_left.denominator;
		}

		public static bool operator ==(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(ref left);
			Fraction t_right = new Fraction(ref right);
			t_left.ToImproper();
			t_right.ToImproper();
			return t_left.numerator * t_right.denominator == t_right.numerator * t_left.denominator;
		}
		public static bool operator !=(Fraction left, Fraction right)
		{
			return !(left == right);
		}

		public static bool operator <=(Fraction left, Fraction right)
		{
			return !(left > right);
		}
		public static bool operator >=(Fraction left, Fraction right)
		{
			return !(left < right);
		}
		public Fraction ToImproper() 
		{
			this.numerator += this.integer * this.denominator;
			this.integer = 0;
			return this;
		}

		public Fraction ToProper()
		{
			this.integer += this.numerator / this.denominator;
			this.numerator %= this.denominator;
			return this;
		}

		public Fraction Inverted()
		{
			Fraction result = new Fraction(this.get_denominator(), this.get_integer() * this.get_denominator() + this.get_numerator());
			return result;
		}

		public Fraction Reduce()
		{
			this.ToProper();
			int more, less, rest;
			more = denominator;
			less = numerator;
			if (less ==0) return this;
			do
			{
				rest = more % less;
				more = less;
				less = rest;
			} while (rest != 0);
			int GCD = more;
			numerator /= GCD;
			denominator /= GCD;
			return this;
		}

		public void Print()
		{
			if (get_integer() != 0)Console.Write(get_integer());
			if (get_numerator() != 0) 
			{
				if(get_integer() != 0) Console.Write("(");
                Console.Write($"{get_numerator()}/{get_denominator()}");
				if (get_integer() != 0) Console.Write(")");
            }
            else if(get_integer() == 0)Console.WriteLine(0);
			Console.WriteLine();
		}
	}
}
