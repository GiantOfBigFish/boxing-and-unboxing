// See https://aka.ms/new-console-template for more information
using System.Collections;
using BenchmarkDotNet.Running;
using boxing_and_unboxing;

Console.WriteLine("Hello, this is an playgroud to see what boxing is and figure out how afeects the memory and the speed.");
int someNumber = 420;
//implicity convert to object, this is boxing
object boxingNumber = someNumber;
//why is call boxing?
//When a variable of a *value type* needs to be converted into a *reference type*,
//an object box is allocated to hold the value, and the value is copied into the box.

//Unboxing is just the opposite.
//When an object box is cast back to its original value type,
//the value is copied out of the box and into the appropriate storage location.
int unboxingNumber = (int)boxingNumber;


//let's see an benchmark
BenchmarkRunner.Run<Benchy>();

