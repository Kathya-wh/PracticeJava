using System;

namespace PracticeJava
{
    public class Program
    {
        public static void Main(string[] args)
        {
            import java.util.Scanner;

//Below are multiple exercises performed during the Java course

        public class Main
        {

            public static double salaryCalculator(double hoursPerWeek, double amountPerHour, int vacationDays)
            {
                if (hoursPerWeek < 0)
                {
                    return -1;
                }
                if (amountPerHour < 0)
                {
                    return -1;
                }
                double weeklyPaycheck = hoursPerWeek * amountPerHour;
                double unpaidTime = vacationDays * amountPerHour * 8;
                return (weeklyPaycheck * 52) - unpaidTime;

            }

            public static void main(String[] args)
            {
                double salary = salaryCalculator(40, 15, 8);
                System.out.println(salary);
            }




            public static void main(String[] args)
            {
                double result = Math.pow(2, 5);
                System.out.println(result);


            }


            public static void calculateTotalMealPrice(double listedMealPrice, double tipRate, double taxRate)
            {

                double tip = tipRate * listedMealPrice;
                double tax = taxRate * listedMealPrice;
                double result = listedMealPrice + tip + tax;
                System.out.println("Your total meal price is " + result);
            }

            public static void main(String[] args)
            {
                calculateTotalMealPrice(25, .18, .08);

            }

            public static void announceDeveloperTeaTime()
            {
                System.out.println("Waiting for developer tea time...");
                System.out.println("Type in a random word and press Enter to start developer tea time");
                Scanner input = new Scanner(System.in);
                input.next();
                System.out.println("It's developer tea time!");
            }
            public static void main(String[] args)
            {
                System.out.println("Welcome to your new job");

                //announceDeveloperTeaTime();

                System.out.println("Get promoted!");

                int studentAge = 15;
                double studentGPA = 3.45;
                boolean hasPerfectAttendance = true;


                String studentFirstName = "Breanna";
                String studentLastName = "White";
                char studentFirstInitial = studentFirstName.charAt(0);
                char studentLastInitial = studentLastName.charAt(0);


                System.out.println(studentAge);
                System.out.println(studentGPA);
                System.out.println(studentFirstInitial);
                System.out.println(studentLastInitial);
                System.out.println(hasPerfectAttendance);
                System.out.println(studentFirstName);
                System.out.println(studentLastName);
                System.out.println(studentFirstName + " " + studentLastName + " " + "has a GPA of " + studentGPA);
                System.out.println("What do you want to update it to?");
                Scanner input = new Scanner(System.in);
                studentGPA = input.nextDouble();

                System.out.println(studentFirstName + " " + studentLastName + " now has a GPA of " + studentGPA);

                System.out.println("Pick a number between 1 and 10");
                Scanner scanner = new Scanner(System.in);

                int inputtedNum = scanner.nextInt();

                if (inputtedNum < 5)
                {
                    System.out.println("Enjoy the good luck a friend brings you");
                }
                else
                {
                    System.out.println("Your shoe selection will make you very happy today");
                }

                Scanner input = new Scanner(System.in);
                boolean isOnRepeat = true;
                while (isOnRepeat)
                {
                    System.out.println("Playing current song");
                    System.out.println("Would you like to take this song off of repeat? If so, answer yes");
                    String userInput = input.next();

                    if (userInput.equals("yes")) ;
                    {
                        isOnRepeat = false;
                    }
                }
                System.out.println("Playing next song");

                //CHALLENGE

                String question = "How many cars do I own?";
                String choiceOne = "one car";
                String choiceTwo = "two cars";
                String choiceThree = "three cars";

                System.out.println(question);
                System.out.println("Choose one of the following: " +
                        choiceOne + ", " + choiceTwo + ",  or " + choiceThree + ".");
                System.out.println(choiceOne);
                System.out.println(choiceTwo);
                System.out.println(choiceThree);

                Scanner scanner = new Scanner(System.in);
                String input = scanner.next();



                if (choiceThree.equals(input))
                {
                    System.out.println("Happy to hear you know how many cars I have, Nice!");
                }
                else
                {
                    System.out.println("You are incorrect. The correct answer is " + choiceThree);
                }








            }

        }
    }
}
