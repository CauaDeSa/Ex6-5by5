float height, weight;
double bmi;
string sex;

do
{
    Console.Write("\nType your height, weight and sex to calculate your Body Mass Index!\n\n");

    do
    {
        Console.Write("Weight: ");
        weight = float.Parse(Console.ReadLine());
    } while (weight <= 0);

    do
    {
        Console.Write("Height: ");
        height = float.Parse(Console.ReadLine());
    } while (height <= 0);

    do
    {
        Console.Write("Sex (m/f): ");
        sex = Console.ReadLine();
    } while (sex != "m" && sex != "f");

    bmi = weight / (Math.Pow(height, 2));

    switch (bmi)
        case (bmi < 20.7 && sex == "m") || (bmi < 19.1 && sex == "f"):
        Console.WriteLine("Below normal!");
        break;

    case (bmi < 26.4 && sex == "m") || (bmi < 25.8 && sex == "f"):
        Console.WriteLine("Healthy range!");
        break;

    case (bmi < 27.8 && sex == "m") || (bmi < 27.3 && sex == "f"):
        Console.WriteLine("A little overweight!");
        break;

    case (bmi < 32.3 && sex == "m") || (bmi < 31.1 && sex == "f"))
            Console.WriteLine("Overweight!");
        break;

    default:
        Console.WriteLine("Obesity range!");
        break;

        Console.WriteLine($"Your BMI: {bmi:0.00}");

        Console.Write("\nDo you wanna test again? (y/n) : ");
    } while (Console.ReadLine() == "y") ;