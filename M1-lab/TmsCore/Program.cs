// Console.WriteLine("Hello, World!");




string? region = null;
string? upperRegion = region?.ToUpper();
Console.WriteLine($"Region(conditional): {upperRegion}");
string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region (coalesced): {displayRegion}");
region ??= "Addis Ababa";
Console.WriteLine($"Region(assigned): {region}");