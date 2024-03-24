using task;
using Type = task.Type;

Console.WriteLine("Welcome aboard!");
Ship ship1 = new Ship("Cruiser201-2",10000,"tri-x2",500,15);
Ship ship2 = new Ship("Tribal2-2",10000,"tri-x3",500,15);

Product banana = new Product(150, "banana-1", Type.Refrigerated, 13, false);
Product chocolate = new Product(100, "chocolate-1", Type.Refrigerated, 18, false);
Product fish = new Product(255, "fish-1", Type.Refrigerated, 2, false);
Product meat = new Product(355, "meat-1", Type.Refrigerated, -15, false);
Product gas = new Product(300, "oxygen", Type.Gas, 0, false);
Product XA21 = new Product(300, "xa21", Type.Gas, 0, false);
Product milk = new Product(100, "milk-1",Type.Liquid, 0, false);
Product acid = new Product(250, "acid-1", Type.Liquid, 0, true);

L_Container lContainer_T = new L_Container(100,100,Type.Liquid,true);
L_Container lContainer_F = new L_Container(100,100,Type.Liquid,false);
G_Container gContainer = new G_Container(100,100,Type.Gas);
R_Container rContainer = new R_Container(100, 100, Type.Refrigerated,10);
R_Container rContainer_2 = new R_Container(100, 100, Type.Refrigerated,40);

Console.WriteLine("Liquid Container(Hazardous) before\n" + lContainer_T);
lContainer_T.loadTheCargo(acid);
Console.WriteLine("Liquid Container(Hazardous) after adding acid product.\n" + lContainer_T);

Console.WriteLine("Ship 1 before adding any containers " + ship1);
ship1.loadContainer(lContainer_T);
Console.WriteLine("Ship 1 after adding container " + ship1);

Console.WriteLine("Ship 2 before adding/transferring any containers " + ship2);
Console.WriteLine("Transfer the container");
ship1.transferContainer(ship2);
Console.WriteLine("Ship 2 after transferring container " + ship2);