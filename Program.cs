Console.Clear();
int parkingTime = 0;
int coins = 0;
float amount = 0;
float moneyTemp = 0;
float temp = 0;
int minutes = 0;
int hours = 0;


void PrintWelcome()

{
    Console.Write("Dear customer, please put in coins, 50 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)");
    Console.WriteLine("Zulässige Münzen: 50 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)");
    Console.WriteLine("Parkschein drucken mit d oder D");
}


void EnterCoins()
{

    do
    {

        System.Console.WriteLine("Put in 5(Cents), 10(Cents), 20(Cents), 50(Cents), 1(Euro), 2(Euro).");
        string input = Console.ReadLine()!;

        switch (input)
        {

            case "5":
                input += 0.05;
                break;

            case "10":
                input += 0.10;
                break;

            case "20":
                input += 0.20;
                break;

            case "50":
                input += 0.50;
                break;

            case "1":
                input += 1;
                break;

            case "2":
                input += 2;
                break;



            case "D":
                if (amount < 0.5f)
                {
                    float moneyTemp2 = amount * 100;
                    System.Console.WriteLine($"Min.Input 50 Cent, you put in: {moneyTemp2} Cent ");
                }
                { moneyTemp = 0; }
                break;

            case "d":
                if (amount < 0.5f)
                {
                    float moneyTemp2 = amount * 100;
                    System.Console.WriteLine($"Minimal Input is 50 Cent, you put in: {moneyTemp2} Cent ");
                }
                { moneyTemp = 0; }
                break;

            default:
                System.Console.WriteLine("Put in another coin");
                temp = 1;
                break;

        }
    }
    while (temp == 1);



}

void AddParkingTime
{
    switch (moneyTemp)
    {
        case "2";
        paringTime += 120;

        default;
        break;

        case "1";
        paringTime += 60;

        default;
        break;

        case "0.50";
        paringTime += 30;

        default;
        break;

        case "0.20";
        paringTime += 12;

        default;
        break;
                
        case "0.10";
        paringTime += 6;

        default;
        break;

        case "0.05";
        paringTime += 3;

        default;
        break;
    }

}

void PrintDonation()
{
    float donation = parkingTime - moneyTemp;
    if (parkingTime < moneyTemp)
    {
        System.Console.WriteLine($"Donation: {donation}");
    }
}
