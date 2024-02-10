using Lab2;


Tree<int> tree = new (6);
tree.Add(3);
tree.Add(2);
tree.Add(5);
tree.Add(4);
tree.Add(8);
tree.Add(10);
int amount = tree.LeavesAmount();
Console.WriteLine(amount);
foreach (int i in tree)
    Console.WriteLine(i);