# Interfaces

## Practice: More Gary's Wholesale Garage

> this exercise will build on the C# project you build in the previous chapter.

Here are some types of vehicles from **Gary's Wholesale Garage**.

1. Scooter
1. Car
1. Jetski
1. RV
1. Motorcycle
1. Boat
1. Truck
1. Light aircraft

Now, all of these types of things have some attributes and behaviors in common.

- They all have an engine
- They all carry one, or more, passenger
- They all move
- They all accelerate in any direction

There are other attributes and behaviors that **some** specific kinds of these vehicles share, but others don't.

- Some use gas
- Some are electric
- Some use a propeller to move
- Some have wheels
- Some have doors
- Some use a jet to move

## Gas Fueling Problem

In your project you should have classes that resemble the code below.

```cs
public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
}
```

```cs
public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
}
```

```cs
public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
}
```

```cs
public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
}
```

Your challenge is to replace your `Main` method with the following code and make the appropriate changes and additions to your project in order to make this `Main` method work.

> **HINT:** An example addition to your code might be an `IElectricVehicle` interface.

```cs
namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<???> electricVehicles = new List<???>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(??? ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(??? ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(??? ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<???> gasVehicles = new List<???>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(??? gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
```

# Class Based Inheritance

## Practice: Custom Colors and Sounds

1. Move all common properties in your vehicles to a new **`Vehicle`** class.
1. Create an instance of each vehicle.
1. Define a different value for each vehicle's properties.
1. Create a `Drive()` method in the **`Vehicle`** class.
1. Override the `Drive()` method in all the other vehicle classes. Include the vehicle's color in the message _(i.e. "The blue Ram drives past. RRrrrrrummbbble!")_.
   ![output of all vehicles driving](https://github.com/nashville-software-school/bangazon-inc/blob/tabloid/book-1-orientation/chapters/images/all-vehicles-driving.gif?raw=true)
1. Create a `Turn(string direction)` mathod, and a `Stop()` method on **`Vehicle`**. Define a basic implementation of each.
1. Override all three of those methods on some of the vehicles. For example, the `Stop()` method for a plane would be to output the message _"The white Cessna rolls to a stop after rolling a mile down the runway."_
1. Make your vehicle instances perform all three behaviors.

![](https://github.com/nashville-software-school/bangazon-inc/blob/tabloid/book-1-orientation/chapters/images/inheritance-vehicles-drive.gif?raw=true)