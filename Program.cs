public class Program {
    
    static void Main(string[] args){
        Info1();
        for (int i = 0;i < 12;i++){
        string number = InputNumber();
        int number1 = CheckNumInt(number);
        int number2 = CheckNum(number1);
        InfoMo(number1);
        }
    }
    static void Info1(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1  : January");
        Console.WriteLine("2  : February");
        Console.WriteLine("3  : March");
        Console.WriteLine("4  : April");
        Console.WriteLine("5  : May");
        Console.WriteLine("6  : June");
        Console.WriteLine("7  : July");
        Console.WriteLine("8  : August");
        Console.WriteLine("9  : September");
        Console.WriteLine("10 : October");
        Console.WriteLine("11 : November");
        Console.WriteLine("12 : December");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
    public static string InputNumber(){
        Console.Write("Input number Info (1 - 12) : ");
        return Console.ReadLine();
    }
    public static int CheckNumInt(string number){
        if (int.TryParse(number, out int value)) {
            return value;
         }  

       throw new Exception("Please input numbers."); 
    }
    public static int CheckNum(int number1){
        if ((number1 > 0)&&(number1 < 13)) {
            return number1;
         }  

       throw new Exception("Please input numbers."); 
    }
    static void InfoMo(int number1){
        if (number1 == 1) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                               January 2022                                                      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                                         |      01      |     02     |");
            Console.WriteLine("     03      |      04      |       05       |      06      |     07     |      08      |     09     |");
            Console.WriteLine("     10      |      11      |       12       |      13      |     14     |      15      |     16     |");
            Console.WriteLine("     17      |      18      |       19       |      20      |     21     |      22      |     23     |");
            Console.WriteLine("     24      |      25      |       26       |      27      |     28     |      29      |     30     |");
            Console.WriteLine("     31      |                                                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 2) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                              February 2022                                                      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("             |      01      |       02       |      03      |     04     |      05      |     06     |");
            Console.WriteLine("     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
            Console.WriteLine("     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
            Console.WriteLine("     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
            Console.WriteLine("     28      |                                                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 3) {    
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                March 2022                                                       ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("             |      01      |       02       |      03      |     04     |      05      |     06     |");
            Console.WriteLine("     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
            Console.WriteLine("     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
            Console.WriteLine("     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
            Console.WriteLine("     28      |      29      |       30       |      31      |                                         ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 4) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                April 2022                                                       ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                            |     01     |      02      |     03     |");
            Console.WriteLine("     04      |      05      |        06      |      07      |     08     |      09      |     10     |");
            Console.WriteLine("     11      |      12      |        13      |      14      |     15     |      16      |     17     |");
            Console.WriteLine("     18      |      19      |        20      |      21      |     22     |      23      |     24     |");
            Console.WriteLine("     25      |      26      |        27      |      28      |     29     |      30      |             ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 5) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                 May 2022                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                                                        |     01     |");
            Console.WriteLine("     02      |      03      |       04       |      05      |     06     |      07      |     08     |");
            Console.WriteLine("     09      |      10      |       11       |      12      |     13     |      14      |     15     |");
            Console.WriteLine("     16      |      17      |       18       |      19      |     20     |      21      |     22     |");
            Console.WriteLine("     23      |      24      |       25       |      26      |     27     |      28      |     29     |");
            Console.WriteLine("     30      |      31      |                                                                         ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 6) {
             Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                June 2022                                                         ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                            |       01       |      02      |     03     |      04      |     05     |");
            Console.WriteLine("     06      |      07      |       08       |      09      |     10     |      11      |     12     |");
            Console.WriteLine("     13      |      14      |       15       |      16      |     17     |      18      |     19     |");
            Console.WriteLine("     20      |      21      |       22       |      23      |     24     |      25      |     26     |");
            Console.WriteLine("     27      |      28      |       29       |      30      |                                         ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 7) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                July 2022                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                            |     01     |      02      |     03     |");
            Console.WriteLine("     04      |      05      |        06      |      07      |     08     |      09      |     10     |");
            Console.WriteLine("     11      |      12      |        13      |      14      |     15     |      16      |     17     |");
            Console.WriteLine("     18      |      19      |        20      |      21      |     22     |      23      |     24     |");
            Console.WriteLine("     25      |      26      |        27      |      28      |     29     |      30      |     31     |");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 8) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                August 2022                                                      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("     01      |      02      |       03       |      04      |     05     |      06      |     07     |");
            Console.WriteLine("     08      |      09      |       10       |      11      |     12     |      13      |     14     |");
            Console.WriteLine("     15      |      16      |       17       |      18      |     19     |      20      |     21     |");
            Console.WriteLine("     22      |      23      |       24       |      25      |     26     |      27      |     28     |");
            Console.WriteLine("     29      |      30      |       31       |                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 9) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                              September 2022                                                     ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                             |      01      |     02     |      03      |     04     |");
            Console.WriteLine("     05      |      06      |        07      |      08      |     09     |      10      |     11     |");
            Console.WriteLine("     12      |      13      |        14      |      15      |     16     |      17      |     18     |");
            Console.WriteLine("     19      |      20      |        21      |      22      |     23     |      24      |     25     |");
            Console.WriteLine("     26      |      27      |        28      |      29      |     30     |                            ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 10) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                               October 2022                                                      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                                                         |      01      |     02     |");
            Console.WriteLine("     03      |      04      |       05       |      06      |     07     |      08      |     09     |");
            Console.WriteLine("     10      |      11      |       12       |      13      |     14     |      15      |     16     |");
            Console.WriteLine("     17      |      18      |       19       |      20      |     21     |      22      |     23     |");
            Console.WriteLine("     24      |      25      |       26       |      27      |     28     |      29      |     30     |");
            Console.WriteLine("     31      |                                                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 11) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                              November 2022                                                      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("             |      01      |       02       |      03      |     04     |      05      |     06     |");
            Console.WriteLine("     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
            Console.WriteLine("     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
            Console.WriteLine("     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
            Console.WriteLine("     28      |      29      |       30       |                                                        ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else if (number1 == 12) {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                              December 2022                                                     ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |      ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                                             |      01      |     02     |      03      |     04     |");
            Console.WriteLine("     05      |      06      |        07      |      08      |     09     |      10      |     11     |");
            Console.WriteLine("     12      |      13      |        14      |      15      |     16     |      17      |     18     |");
            Console.WriteLine("     19      |      20      |        21      |      22      |     23     |      24      |     25     |");
            Console.WriteLine("     26      |      27      |        28      |      29      |     30     |      31      |             ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        else Console.WriteLine("error");
    }
}
