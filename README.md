# boxing-and-unboxing
 _Hello, this is an playground to see what boxing is and figure out how affects the memory and the performance._
 
Here is an example of boxing (implicity convert to object):
```
object boxingNumber = 420;
```

## why is call boxing?
When a variable of a **value type** needs to be converted into a **reference type** an object box is allocated to hold the value, and the value is copied into the box.

Unboxing is just the opposite. When an object box is cast back to its original value type, the value is copied out of the box and into the appropriate storage location.

## See this benchmark
![Benchmark](benchmarkss.png?raw=true "Benchmark")


