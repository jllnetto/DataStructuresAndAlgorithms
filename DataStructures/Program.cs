using DataStructuresAndAlgorithms.DataStructures;

DynamicArray<string> array = new DynamicArray<string>(10);

array.Add("A");
array.Add("B");
array.Add("C");
array.Add("D");
array.Insert(1, "b");
array.Print();
array.Delete(1);
array.Print();