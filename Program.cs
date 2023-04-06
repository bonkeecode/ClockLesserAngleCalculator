Console.Write("Enter the hours (0-11): ");
int hours = int.Parse(Console.ReadLine());
Console.Write("Enter the minutes (0-59): ");
int minutes = int.Parse(Console.ReadLine());

// Output the result


    // Calculate the angle between the hour and minute hands
    double hourAngle = (hours % 12 + minutes / 60.0) * 30;
    double minuteAngle = minutes * 6;
    double angle = Math.Abs(hourAngle - minuteAngle);
    if (angle > 180)
    {
        angle = 360 - angle;
    }
    Console.WriteLine($"The lesser angle between the hour and minute hands is {angle:F2} degrees.");




    