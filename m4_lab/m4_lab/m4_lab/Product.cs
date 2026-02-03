using System;

public class Product : ProductIF
{

	private int id;
	private string name;
	private double price;



	public Product(int id, string name, double price)
	{
		this.id = id;
		this.name = name;
		this.price = price;
    }

	public int getId()
	{
		return this.id;
    }

	public string getName()
	{
		return this.name;
    }

	public double getPrice()
	{
		return this.price;
	}

	public void setPrice(double price)
	{
		this.price = price;
	}

	public void setName(string name)
	{
		this.name = name;
	}

}
