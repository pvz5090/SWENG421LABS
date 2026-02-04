using System;
namespace p2;
public interface ProductIF : IComparable
{
	public int getId();
	public string getName();
	public double getPrice();
	public void setPrice(double price);
	public void setName(string name);
}
