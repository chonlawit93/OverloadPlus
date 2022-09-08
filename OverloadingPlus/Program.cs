// See https://aka.ms/new-console-template for more information
using OverloadingPlus.Helpers;

Console.WriteLine("Hello, World!");
Box box01cust01 = new Box
{
    Weight = 100,
    Volume = 6,
    Value = 10000
};


Box box02cust02 = new Box
{
    Weight = 300,
    Volume = 15,
    Value = 4000
};


bool equal = box01cust01.Equals(box02cust02);


//Box totalBox = new Box
//{
//    Value = box01cust01.Value + box02cust02.Value,
//    Volume = box01cust01.Volume + box02cust02.Volume,
//    Weight = box01cust01.Weight + box02cust02.Weight
//};

// This can be used in calculating total primary attribute in the assignment
Box totalBox = box01cust01 + box02cust02;

CalculateInsurance(totalBox);



static void CalculateInsurance(Box total)
{
    Console.WriteLine(total.Value * total.Volume / total.Weight);
}