using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		//int integer;
		//int numerator;
		int denominator;


		public int Integer
		{
			get;
			set;
		}

		public int Numerator
		{
			get;
			set;
		}

		public int Denominator
		{
			get { return denominator; }
			set 
			{ 
				if (value == 0) value = 1;
				denominator = value; 
			}
		}


		public int getDenominator()
		{
			return denominator;
		}


		public void setDenominator(int denominator)
		{
			if(denominator == 0) denominator = 1;
			this.denominator = denominator;
		}

		public Fraction() 
		{
			Integer = 0;
			Numerator = 0;
			Denominator = 1;
            Console.WriteLine($"DefaultConstructor \t\t{this.GetHashCode()}");
        }

		public Fraction(int integer) 
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine($"1 parameter Constructor \t{this.GetHashCode()}");
		}

		public Fraction(double number)
		{
			number += 1e-10;
			Integer = (int)number;
			number -= Integer;
			Denominator = (int)1e+9;
			Numerator = (int) (number * Denominator);
			Reduce();
			Console.WriteLine($"1d parameter Constructor \t{this.GetHashCode()}");
		}

		public Fraction(string line): this(Convert.ToDouble(line.Replace('.', ',')))
		{
			Console.WriteLine($"1s parameter Constructor \t{this.GetHashCode()}");
		}

		public Fraction(int numerator, int denominator)
		{
			Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine($"2 parameter Constructor \t{this.GetHashCode()}");
		}

		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine($"3 parameter Constructor \t{this.GetHashCode()}");
		}
		
		public Fraction(Fraction other)
		{
			this.Integer = other.Integer;
			this.Numerator = other.Numerator;
			this.Denominator = other.Denominator;
			Console.WriteLine($"Copy Constructor \t{this.GetHashCode()}");
		}

		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}

		public override string ToString()
		{
			string output = "";
			if (Integer != 0) output += Integer.ToString();
			if (Numerator != 0)
			{
				if (Integer != 0) output += "(";
				output += $"{Numerator}/{Denominator}";
				if (Integer != 0) output += ")";
			}
			else if (Integer == 0) output += 0.ToString();
			return output;
		}

		public Fraction toImproper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
			return this;
		}

		public Fraction toProper()
		{
			Integer += Numerator / Denominator;
			Numerator %= Denominator;
			return this;
		}

		public Fraction Inverted()
		{
			Fraction inverted = new Fraction(Denominator, Integer * Denominator + Numerator);
			return inverted;
		}

		public Fraction Reduce()
		{
			this.toProper();
			int more, less, rest;
			more = Denominator;
			less = Numerator;
			if (less == 0) return this;
			do
			{
				rest = more % less;
				more = less;
				less = rest;
			} while (rest != 0);
			int GCD = more;
			Numerator /= GCD;
			Denominator /= GCD;
			return this;
		}

		public static Fraction operator ++(Fraction fraction)
		{
			return new Fraction(fraction.Integer + 1, fraction.Numerator, fraction.Denominator);
		}

		public static Fraction operator --(Fraction fraction)
		{
			return new Fraction(fraction.Integer - 1, fraction.Numerator, fraction.Denominator);
		}

		public static Fraction operator *(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return new Fraction(t_left.Numerator * t_right.Numerator, +t_left.Denominator * t_right.Denominator).toProper();
		}

		public static Fraction operator /(Fraction left, Fraction right)
		{
			return (left * right.Inverted()).toProper();
		}

		public static Fraction operator +(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return new Fraction(
				t_left.Numerator * t_right.Denominator + t_right.Numerator * t_left.Denominator,
				t_left.Denominator * t_right.Denominator).toProper();
		}

		public static Fraction operator -(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return new Fraction(
				t_left.Numerator * t_right.Denominator - t_right.Numerator * t_left.Denominator,
				t_left.Denominator * t_right.Denominator).toProper();
		}

		public static bool operator <(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return t_left.Numerator * t_right.Denominator < t_right.Numerator * t_left.Denominator;
		}
		public static bool operator >(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return t_left.Numerator * t_right.Denominator > t_right.Numerator * t_left.Denominator;
		}

		public static bool operator ==(Fraction left, Fraction right)
		{
			Fraction t_left = new Fraction(left);
			Fraction t_right = new Fraction(right);
			t_left.toImproper();
			t_right.toImproper();
			return t_left.Numerator * t_right.Denominator == t_right.Numerator * t_left.Denominator;
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
	}
}
