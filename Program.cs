
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Xml.Serialization;

Start();

// 게임 시작 화면
void Start()
{
    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
    Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
    Console.WriteLine("\n");
    Console.WriteLine("1. 상태 보기");
    Console.WriteLine("2. 인벤토리");
    Console.WriteLine("3. 상점");
    Console.WriteLine("\n");
    StartChoice();
}

// 선택지 제공
void HaveChoice()
{
    Console.WriteLine("원하시는 행동을 입력해주세요.");
    Console.Write(">>");

    string input = Console.ReadLine();
    int choice;
    int anotherChoice;
    bool filter = int.TryParse(input, out choice);

    if (filter == true)
    {
        if (choice == 0)
        {
            Console.Clear();
            Start();
        }
        else if (choice > 0 && choice < 4)
        {
            anotherChoice = choice;
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

void StartChoice()
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
            PrintInfo();
        }
        else if (choice == 2)
        {
            Inven();
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
    PlayerInfo();
    Console.WriteLine("\n");
    Console.WriteLine("0. 나가기");
    Console.WriteLine("\n");
    HaveChoice();
}

void PlayerInfo()
{
    int level = 1;
    string chad = "전사";
    int att = 10;
    int def = 5;
    int sta = 100;
    int gold = 1500;

    Console.WriteLine($"Lv. {level}");
    Console.WriteLine($"chad ({chad})");
    Console.WriteLine($"공격력: {att}");
    Console.WriteLine($"방어력: {def}");
    Console.WriteLine($"체 력: {sta}");
    Console.WriteLine($"소지금: {gold} G");
}

void Inven()
{
    Console.WriteLine("<인벤토리>");
    Console.WriteLine("보유 중인 아이템입니다.");
    Console.WriteLine("\n");
    Console.WriteLine("[소지 아이템 목록]");
    Console.WriteLine("\n"); // 보유 목록 들어가야 함
    Console.WriteLine("1. 장착 관리");
    Console.WriteLine("0. 나가기");
    HaveChoice();
}

