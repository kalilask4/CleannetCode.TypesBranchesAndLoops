// See https://aka.ms/new-console-template for more information

Console.Write("Привет! ");
Console.WriteLine("Как тебя зовут?");
String? userName = Console.ReadLine();
if (String.IsNullOrEmpty(userName)) {
    Console.WriteLine("Не видно ^^) Как тебя зовут?");
    userName = Console.ReadLine();
}
Console.WriteLine($"Поиграем, {userName}? (да)");
var yesOption = new[] { "да", "lf" }; //lf - если пользователь не сменил раскладку разрешим просто продолжить
var isPlaying = yesOption.Contains(Console.ReadLine().ToLower()) ?  true :  false;
var attemptCounter = 0;
while (isPlaying){
    (int startNum, int endNum) range = (0, 999);
    Random r = new Random();
    int secretNum = r.Next(range.startNum, range.endNum);
    Console.Write($"Я загадал число от {range.startNum} до {range.endNum}. ");
    Console.WriteLine("Попробуй угадать");
    //Console.WriteLine($"{secretNum}");
    var isGuesed = false;
    while (!isGuesed)
    {
        attemptCounter++;
        int goodUserNum =-1;
        var isGoodUserNum = false;
        Console.WriteLine($"Введи число от {range.startNum} до {range.endNum}");
        String? userInput = Console.ReadLine();
        
        while (!isGoodUserNum)
        {
            if (!String.IsNullOrEmpty(userInput) && int.TryParse(userInput, out goodUserNum) &&
                goodUserNum >= range.startNum && goodUserNum <= range.endNum)
            {
                isGoodUserNum = true;
            }
            else
            {
                Console.WriteLine($"Попробуй еще раз. Ты ввел - {userInput}," +
                                  $"а нужно - число от {range.startNum} до {range.endNum} ");
                userInput = Console.ReadLine();
            }
        }
        if (goodUserNum < secretNum)
        {
            Console.WriteLine($"Мое число больше твоего {goodUserNum}. \\_(°.° )_/");
        }
        else if (goodUserNum > secretNum)
        {
            Console.WriteLine($"Твое число {goodUserNum} больше моего. W(°O°)W");
        }
        else
        {
            Console.WriteLine($"Супер! Ты угадал! Мое число - {secretNum}. (*^-^*)<3");
            Console.WriteLine($"Попыток: {attemptCounter}. Ты молодец, {userName}!!");
            
            isGuesed = true;
            attemptCounter = 0;
        }
    }
    Console.WriteLine("Еще разок? (да)");
    isPlaying = Console.ReadLine() == "да" ?  true :  false;
}
Console.Write($"Пока, {userName}! Мне понравилось! (^*^)");

