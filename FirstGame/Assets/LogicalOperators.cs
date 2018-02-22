using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

// an operator is any symbol used to distinguish which opperation performs an expression.
// for logical operators we have and (&&) as well as or (||). These operators are used to perform logical operations on the given two variables.

int main()
{
	public int Power = 100;
	int m=40, n=20;
	int o=20, p=30;
	if (m>n && m !=0)
	{
		print("&& operator: Both conditions are true");
	}
	if (o>p) || p!=20)
	{
		print("|| Operator: Only one condition is true");
	}
	if (m + n == 60 && m + n <100)
	{
		print("Good Job mate");
	}

	if (power =< 100 && m>n)
	{
		print ("You mad bro?");
	}

	if (power < 100 && power > 50)
	{
		print("LOW HEALTH");
	}

	if (power < 20 || power = 0)
	{
		print("You're Dead");
	}

	if (10+2==12 || 3*4==12)
	{
		print("Do you know maths?");
	}

	if ("my hair is blue" && "my hair is short")
	{
		print("Good Looking Hair");
	}
	if (1080+2160 != 3000 && 2 + 4 != 5)
	{
		print("Accepted into Harvard ya genius!");
	}
}

}
