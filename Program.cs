
// 게임 시작 화면
Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
Console.WriteLine("\n");
Console.WriteLine("1. 상태 보기");
Console.WriteLine("2. 인벤토리");
Console.WriteLine("3. 상점");
Console.WriteLine("\n");
HaveChoice();


// 선택지 제공
void HaveChoice()
{
    Console.WriteLine("원하시는 행동을 입력해주세요.");
    Console.Write(">>");

    string input = Console.ReadLine();
    int choice;
    bool filter = int.TryParse(input, out choice);

    if (filter == true)
    {
        if (choice == 1)
        {
            Console.WriteLine("1번 선택");
        }
        else if (choice == 2)
        {
            Console.WriteLine("2번 선택");
        }
        else if (choice == 3)
        {
            Console.WriteLine("3번 선택");
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
        }
    }
    else
    {
        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
    }
}

void PrintInfo()
{
    Console.Clear();
    Console.WriteLine("<상태 보기>");
    Console.WriteLine($"ㅇㅇㅇ의 정보입니다.");
    Console.WriteLine("\n");
    
    Console.WriteLine("\n");
    Console.WriteLine("0. 나가기");
    Console.WriteLine("\n");
    HaveChoice();
}