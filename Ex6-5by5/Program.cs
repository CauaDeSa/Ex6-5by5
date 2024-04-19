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

    Console.Write("Sex: ");
    sex = Console.ReadLine();

    bmi = weight / (Math.Pow(height, 2));

    if (bmi < 18.49)
        Console.WriteLine("Below normal!");
    else if (bmi < 24.99)
            Console.WriteLine("Healthy range!");
        else if (bmi < 29.99)
                Console.WriteLine("Overweight!");
            else if (bmi < 34.99)
                    Console.WriteLine("Grade I obesity range");
                else if (bmi < 39.99)
                        Console.WriteLine("Grade II obesity range");
                     else
                        Console.WriteLine("Grade III obesity range");

    Console.WriteLine($"Your BMI: {bmi}");

    Console.Write("\nDo you wanna test again? (y/n) : ");
} while (Console.ReadLine() == "y");