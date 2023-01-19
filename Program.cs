int moneyValue = 100;
int cardValue = 0;
int dealerCardValue = 0;
int round = 0;
int MoneyPlayer = 100;
int oldCardValue = 0;
int yourBet;
int oldDealerCardValue = 0;
const int minimum_bet = 10;
string card = "";
string input;
bool continuePlaying = true;
bool DealerWins = true;
bool playerWins = false;
bool moneyDoubled = true;




void newRound()
{
    round++;
}

void PrintWelcome()
{
    Console.WriteLine("Welcome to Blackjack");
    Console.WriteLine("");
    Console.Write("You have 100$ in your pocket!");
    Console.Write("");
    Console.Write("You lose if you don't have any money left");
}

void PrintRound()
{
    Console.WriteLine($"You are in the {round} round now and have {MoneyPlayer}$ left");
}

void HandoutRandomPlayerCard()
{
    cardValue = Random.Shared.Next(1, 13);
    string cardName = "";

    switch (cardValue)
    {
        case 1:
            card = "Ace";
            cardName = "ace";
            break;

        case 2:
            card = "2";
            break;

        case 3:
            card = "3";
            break;

        case 4:
            card = "4";
            break;

        case 5:
            card = "5";
            break;

        case 6:
            card = "6";
            break;

        case 7:
            card = "7";
            break;

        case 8:
            card = "8";
            break;

        case 9:
            card = "9";
            break;

        case 10:
            card = "10";
            break;

        case 11:
            card = "11";
            cardName = "jack";
            break;

        case 12:
            card = "12";
            cardName = "queen";
            break;

        case 13:
            card = "13";
            cardName = "king";

            break;
    }

    cardValue += oldCardValue;




}

void HandoutRandomDealerCard()
{
    cardValue = Random.Shared.Next(1, 13);
    string cardName = "";

    switch (dealerCardValue)
    {
        case 1:
            card = "Ace";
            cardName = "ace";
            break;

        case 2:
            card = "2";
            break;

        case 3:
            card = "3";
            break;

        case 4:
            card = "4";
            break;

        case 5:
            card = "5";
            break;

        case 6:
            card = "6";
            break;

        case 7:
            card = "7";
            break;

        case 8:
            card = "8";
            break;

        case 9:
            card = "9";
            break;

        case 10:
            card = "10";
            break;

        case 11:
            card = "11";
            cardName = "jack";
            break;

        case 12:
            card = "12";
            cardName = "queen";
            break;

        case 13:
            card = "13";
            cardName = "king";

            break;



    }

    dealerCardValue += oldDealerCardValue;




}

void PrintPlayerCard()
{
    string cardName = "";

    switch (cardValue)
    {
        case 1:
            card = "Ace";
            cardName = "ace";
            break;

        case 2:
            card = "2";
            break;

        case 3:
            card = "3";
            break;

        case 4:
            card = "4";
            break;

        case 5:
            card = "5";
            break;

        case 6:
            card = "6";
            break;

        case 7:
            card = "7";
            break;

        case 8:
            card = "8";
            break;

        case 9:
            card = "9";
            break;

        case 10:
            card = "10";
            break;

        case 11:
            card = "11";
            cardName = "jack";
            break;

        case 12:
            card = "12";
            cardName = "queen";
            break;

        case 13:
            card = "13";
            cardName = "king";

            break;



    }

    if (cardValue >= 2 || cardValue <= 10)
    {
        Console.WriteLine($"Your card has  the number {card}");
    }



    else if (cardValue == 11 || cardValue <= 13 || cardValue == 1)
    {
        Console.WriteLine($"Your card has  the number {card} and the name {cardName}  ");
    }



}

void PrintDealerCard()
{
    string cardName = "";

    switch (cardValue)
    {
        case 1:
            card = "Ace";
            cardName = "ace";
            break;

        case 2:
            card = "2";
            break;

        case 3:
            card = "3";
            break;

        case 4:
            card = "4";
            break;

        case 5:
            card = "5";
            break;

        case 6:
            card = "6";
            break;

        case 7:
            card = "7";
            break;

        case 8:
            card = "8";
            break;

        case 9:
            card = "9";
            break;

        case 10:
            card = "10";
            break;

        case 11:
            card = "11";
            cardName = "jack";
            break;

        case 12:
            card = "12";
            cardName = "queen";
            break;

        case 13:
            card = "13";
            cardName = "king";

            break;



    }

    if (cardValue >= 2 || cardValue <= 10)
    {
        Console.WriteLine($"Your card has  the number {card}");
    }



    else if (cardValue == 11 || cardValue == 13 || cardValue == 1 || cardValue == 12)
    {
        Console.WriteLine($"Your card has  the number {card} and the name {cardName}  ");
    }



}

void AskForBet()
{

    Console.WriteLine("How much money do you want to bet? The minimum amonut is 10$ an the maximum amount is the amount of your left money!");
    yourBet = int.Parse(Console.ReadLine()!);

    if (yourBet < minimum_bet)
    {

    }
}

void AskForCard()
{


    int temp = 0;
    do
    {
        Console.WriteLine("Do you want another card? yes or no?");
        input = Console.ReadLine()!;
        if (input == "yes")
        {
            continuePlaying = true;
            temp = 0;

        }
        else if (input == "no")
        {
            continuePlaying = false;
            temp = 0;
        }
        else
        {
            temp = 1;
        }


    } while (temp == 1);
}

void DetermineWinner()
{
    if (cardValue > 21)
    {
        DealerWins = true;
        if (DealerWins)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("You busted, Dealer won!");
        }
    }
    else if (dealerCardValue > 21)
    {
        playerWins = true;
        moneyValue += 2 * yourBet;
        if (playerWins)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Dealer busted, You won!");
        }
    }
    else if (dealerCardValue > cardValue)
    {
        DealerWins = true;
        if (DealerWins)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("You busted, Dealer won!");
        }
    }
    else if (cardValue > dealerCardValue)
    {
        playerWins = true;
        moneyValue += 2 * yourBet;
        if (playerWins)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Dealer busted, You won!");
        }
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Standoff");
        moneyValue += yourBet;
    }


}
void CheckIfMoneyDoubled()
{
    if (moneyValue >= 200)
    {
        moneyDoubled = true;
    }
}
void GameLogic()
{
    HandoutRandomPlayerCard();
    PrintPlayerCard();
}
PrintWelcome();
do
{

    newRound();
    PrintRound();

    HandoutRandomPlayerCard();
    PrintPlayerCard();
    AskForBet();
    HandoutRandomPlayerCard();
    PrintDealerCard();
    AskForCard();
    if (input == "yes")
    {
       GameLogic();
    }
    if (cardValue < 22 || input == "no")
    {
        Console.WriteLine("Dealer's turn...");

        HandoutRandomDealerCard();
        PrintDealerCard();

        DetermineWinner();
        CheckIfMoneyDoubled();
        dealerCardValue = 0;
        cardValue = 0;
    }
    while (moneyDoubled == false && moneyValue > 0) ;


    if (moneyDoubled)
    {
        System.Console.WriteLine($"You won, you now have {moneyValue}");
    }
    else
    {
        System.Console.WriteLine("You lost!");
    }
}while(moneyValue !< 10 || moneyDoubled == false );
