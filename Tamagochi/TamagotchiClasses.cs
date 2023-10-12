using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Tiger 
{
private int hunger;
private int boredom;
private List<string> words = new List<string>() {"Helloooo"};
private bool isLiving;
private Random generator;
public string name;

public Tiger()
{
generator = new Random();
isLiving = true;
}
}