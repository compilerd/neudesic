using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bealiveman
{
	class alive
	{
	static void Main(string[] args)
	{
		int i, n, k, left = 0, pos = 0;
		Console.WriteLine("enter the number of people\n");
		n = int.Parse( Console.Readline());
		int[] a = new int[n+1];
		Console.WriteLine("enter the step at which person should be executed \n");
		k = int.Parse(Cosole.ReadLine());
		for(i=1;i<=n;i++)
		{
			a[i] = i;
		}
		i = 1;
		while(left!=n-1)
		{
			if(a[i]!=0)
			{
				pos++;
				if(pos==k)
				{
					a[i] = 0;
					left ++;
					pos = 0;
				}
			}
			i++;
			if(i>n)
			{
				i=1;
			}
			for(i=1;i<n;i++)
			{
				Console.WriteLine("\n");
				Console.WriteLine(a[i]+ "is the person alive\n");
				break;
			}
		}
	}
	}
}