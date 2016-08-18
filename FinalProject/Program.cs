//Inventory Project

//Create a Project in your github directory named FinalProject.

//I will check your github account for FinalProject.

//You must design a database application that is to keep track of inventory items.You may use any standard C# programming
//language feature to complete the project.

//The program must be able to complete the following tasks:
//1.Add an item
//2.Change an item (by giving its item number)
//3.Delete an item(by giving its item number)
//4.List all items in the database
//5.Quit

//The database must be able to hold at least 10 items and at most 100 items.

//No file I/O is necessary.

//No fancy screen I/O is necessary (just System.Console functionality).

//Each item must have the following information associated with it (Hint: A array of structs might work well here.):
//•Item #
//•Description
//•Price per item
//•Quantity on hand
//•Our cost per item
//•Value of item(price * quantity on hand)

//The program should have some sort of menu to select which option and display the results to the screen.

//Submit a link to your github that points to your solution.For example, http://github.com/student/it-foundation/FinalProject


using System;

namespace FinalProject
{

    struct ItemData
    {
        public int itemIDNo;
        public string sDescription;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
        public double dblPricePerItem;
        public double dblValueOfItem;
    }

    class MyInventory
    {
        public static void Main()
        {
            // use an integer to keep track of the count of items in your inventory
            int icount = 0;

            // create an array of your ItemData struct
            ItemData[] itemprop = new ItemData[10];

            // use a never ending loop that shows the user what options they can select
            // as long as no one Quits, continue the inventory update
            // in that loop, show what user can select from the list
            // read the user's input and then create what case it falls

            int optx = 0;
            while (optx != 5)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Change an item");
                Console.WriteLine("3. Delete an item");
                Console.WriteLine("4. List all items in inventory");
                Console.WriteLine("5. Quit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Please enter your selection: ");

                string strx = Console.ReadLine(); // read user's input

                optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

                Console.WriteLine(); // provide an extra blank line on screen

                switch (optx)
                {
                    case 1: // add an item to the list if this option is selected
                        {
                            Console.Write("         Item ID: ");
                            itemprop[icount].itemIDNo = int.Parse(Console.ReadLine());

                            Console.Write("     Description: ");
                            itemprop[icount].sDescription = (Console.ReadLine());

                            Console.Write("Quantity on Hand: ");
                            itemprop[icount].iQuantityOnHand = int.Parse(Console.ReadLine());

                            Console.Write("       Unit Cost: ");
                            itemprop[icount].dblOurCostPerItem = double.Parse(Console.ReadLine());

                            Console.Write("      Unit Price: ");
                            itemprop[icount].dblPricePerItem = double.Parse(Console.ReadLine());

                            itemprop[icount].dblValueOfItem = itemprop[icount].dblPricePerItem * itemprop[icount].iQuantityOnHand;

                            icount++;

                            break;
                        }

                    case 2: //change items in the list if this option is selected
                        {
                            Console.Write("Item ID: ");
                            string strchgid = Console.ReadLine();
                            int chgid = int.Parse(strchgid);
                            bool fFound = false;

                            for (int x = 0; x < icount; x++)
                            {
                                if (itemprop[x].itemIDNo == chgid)
                                {
                                    fFound = true;

                                    Console.Write("Description: ");
                                    itemprop[x].sDescription = (Console.ReadLine());

                                    Console.Write("Quantity on Hand: ");
                                    itemprop[x].iQuantityOnHand = int.Parse(Console.ReadLine());

                                    Console.Write("Unit Cost: ");
                                    itemprop[x].dblOurCostPerItem = double.Parse(Console.ReadLine());

                                    Console.Write("Unit Price: ");
                                    itemprop[x].dblPricePerItem = double.Parse(Console.ReadLine());

                                    itemprop[x].dblValueOfItem = itemprop[x].dblPricePerItem * itemprop[x].iQuantityOnHand;
                                }

                                else if (!fFound) // and if not found
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Item {0} not found", chgid);
                                    Console.WriteLine();
                                }

                            }

                            break;

                        }

                    case 3: //delete items in the list if this option is selected
                        {
                            Console.Write("Item ID: ");
                            string strnewid = Console.ReadLine();
                            int newid = int.Parse(strnewid);

                                for (int x = 0; x < icount; x++)
                                {
                                    if (itemprop[x].itemIDNo == newid)
                                    {
                                        // moving elements downwards, to fill the gap at [index]
                                        itemprop[x] = itemprop[x + 1];

                                        // finally, let's decrement Array's size by one
                                        Array.Resize(ref itemprop, itemprop.Length - 1);

                                        --icount;

                                        Console.WriteLine("Item deleted");
                                        Console.WriteLine();
                                    }

                                }

                            break;
                        }

                    case 4:  //list all items in current database if this option is selected
                        {
                            Console.WriteLine("Item ID       Description       QOH  Unit Cost  Unit Price  Extended Price");
                            Console.WriteLine("-------  ---------------------  ---  ---------  ----------  --------------");

                            for (int x = 0; x < icount; x++)
                            {
                                Console.Write("{0,-7}  ", itemprop[x].itemIDNo);
                                Console.Write("{0,-21}  ", itemprop[x].sDescription);
                                Console.Write("{0,3}  ", itemprop[x].iQuantityOnHand);
                                Console.Write("{0,9}  ", itemprop[x].dblOurCostPerItem);
                                Console.Write("{0,10}  ", itemprop[x].dblPricePerItem);
                                Console.WriteLine("{0,14}", itemprop[x].dblValueOfItem);
                            }

                            Console.WriteLine();
                            Console.WriteLine();

                            break;
                            }

                    case 5: //quit the program if this option is selected
                        {
                            Console.Write("Are you sure that you want to quit (y/n)? ");
                            string strresp = Console.ReadLine();

                            if (strresp != "y") //( code )
                            {
                                optx = 0;   //as long as it is not 5, the process is not breaking
                            }

                            break;
                        }

                    default:
                        {
                            Console.Write("Invalid Option, try again");
                            Console.WriteLine();
                            break;
                        }
                    }
                }
            }
        }
    }
