using HW1;

int[] array = { 81, 6, 4, 5, 0, 8 };
foreach (var i in array)
{
    Console.WriteLine(i + " ");
}
Console.WriteLine();


SortingAlgorithms.SelectionSortRecursive(array);

foreach (var i in array)
{
    Console.WriteLine(i);
}


ListQueue<int> queue = new ListQueue<int >();

queue.Enqueue( 1 );
queue.Enqueue( 2 );
queue.Enqueue( 3 );
queue.Enqueue( 4 );

queue.printqueue();

queue.Dequeue();