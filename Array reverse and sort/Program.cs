string [] pallets ={"Brandon", "Ariana", "Bolton", "Angel"};
Console.WriteLine("Sorted ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
   Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
   Console.WriteLine($"--{pallet}");
}
