using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using Playground.Classes;
using System.Collections.Concurrent;

namespace Playground
{
    class Program
    {
        #region Delegate Properties and Members
        private static double results = 0d;
        private delegate Person ReturnPersonDelegate();
        private static ReturnPersonDelegate ReturnPersonMethod;
        private delegate void EmployeeParameterDelegate(Employee employee);
        private static EmployeeParameterDelegate EmployeeParameterMethod;
        private delegate void LambdaDelegate(string s);

        private static Employee ReturnEmployee()
        {
            return new Employee();
        }

        private static void PersonParameter(Person person)
        {

        }

        #endregion

        static void Main(string[] args)
        {
            #region MCSD Certification Toolkit

            #region StringManipulation

            //StringBuilder alphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //StringBuilder line = new StringBuilder();
            //StringBuilder result = new StringBuilder();

            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    line.Append(alphabet[i]);
            //    Console.WriteLine(line);
            //    result.Append(line + "\n");
            //}

            //Console.WriteLine(result);
            //Book bk = new Book();
            //float cost = 1.23835f;

            //Console.WriteLine(bk.ToString());
            //Console.WriteLine(cost);
            //Console.WriteLine(cost.ToString());
            //Console.WriteLine(cost.ToString("0.00"));
            //char[] ca = { 'T' };

            //Console.WriteLine("{0:C}", 103445.02);
            //checked
            //{
            //    long bignum = 6000000000000;
            //    //int over = (int)bignum;
            //}

            //decimal num = 1234.56M;
            //Console.WriteLine(num.ToString("c"));

            //string travis = "12345";


            #endregion

            #region Classes

            //Employee trav = new Employee("Travis", "Myers", "DSRE");

            //List<Book> readingList = new List<Book>();
            //Book book1 = new Book("The Great Gatsby", 1000);
            //Book book2 = new Book("Great Expectations", 950);
            //Book book3 = new Book("Moby Dick", 900);
            //Book book4 = new Book("1982", 850);
            //Book book5 = new Book("Hucklberry Finn", 800);

            //readingList.Add(book1);
            //readingList.Add(book2);
            //readingList.Add(book3);
            //readingList.Add(book4);
            //readingList.Add(book5);

            //PrintTitles(readingList);

            //readingList.Sort();

            //PrintTitles(readingList);
            //BookComparer bookComparer = new BookComparer();
            //bookComparer.SortBy = BookComparer.CompareField.NumberOfPages;
            //readingList.Sort(bookComparer);

            //PrintTitles(readingList);

            #endregion

            #region IEnumerable<Genre>

            //Genre hardback = new Genre("Hard Cover");
            //Genre classics = hardback.AddChild("Classics");
            //hardback.AddChild("Contemporary");
            //hardback.AddChild("Modern");
            //classics.AddChild("English");
            //classics.AddChild("American");

            //IEnumerator<Genre> genreEnumerator = hardback.GetEnumerator();

            //while (genreEnumerator.MoveNext())
            //{
            //    Console.WriteLine(new string(' ', 4 * genreEnumerator.Current.Depth) + genreEnumerator.Current.Name + Environment.NewLine);
            //}

            //foreach (Genre item in hardback.GetEnumerable())
            //{
            //    Console.WriteLine(new string(' ', 4 * item.Depth) + item.Name + Environment.NewLine);
            //}

            #endregion

            #region Delegates

            //book1.InstanceCurrentPage = CWPageNumber;
            //Console.WriteLine(book1.InstanceCurrentPage());

            //// Covariant delegate returns compatible child class from Person delegate
            //ReturnPersonMethod = ReturnEmployee;

            //// Contravariant delegate parameter Person is assigned method that accepts Employee parameter
            //// compatible parameters since the Employee is a child of Person
            //EmployeeParameterMethod = PersonParameter;

            //var del1 = ReturnPersonMethod();
            //Console.WriteLine(del1.GetType());

            //EmployeeParameterMethod(trav);

            #endregion

            #region Built-in Delegates / Anonymous Delegate

            //EmployeeParameterMethodAction = PersonParameter;
            //ReturnPersonMethodFunction = ReturnEmployee;

            //// Action Employee
            //EmployeeParameterMethodAction(trav);
            //// Function Person
            //var del2 = ReturnPersonMethodFunction();

            //// Square a number returns float, anonymous delegate method
            //Console.WriteLine(SquareFunction(3));

            //// Anonymous delegate assigned to a seperate thread
            //Thread t = new Thread(
            //        delegate()
            //        {
            //            MessageBox.Show("Hello World", "Congratulations", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //        }
            //    );

            //t.Start();

            #endregion

            #region Lambda Expressions

            //// Lambda Expression, single statement
            //Action notify = () => MessageBox.Show("Hello World", "Congratulations", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            //// Lambda Expression generic Action method
            //Action<string, string, MessageBoxButtons, MessageBoxIcon> notify2 = (message, caption, buttons, icon) => MessageBox.Show(message, caption, buttons, icon);

            //notify();
            //notify2("Action!!", "Generic Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ////Async Lambdas
            //DoSomething("Doing something\n");

            //Console.WriteLine("Press any Key to start downloading a file");
            //Console.ReadKey();

            //DoSomething += async (string message) =>
            //{
            //    Console.WriteLine("Done yet?");

            //    await DoSomethingAsync();
            //    Console.WriteLine("Done yet?");
            //};

            //Thread.Sleep(10000);

            //DoSomething("Async work");

            #endregion

            #region Events

            //BankAccount acct = new BankAccount();
            //MoneyMarketAccount mmacct = new MoneyMarketAccount();
            //mmacct.Overdrawn += Acct_Overdrawn;
            //acct.Overdrawn += Acct_Overdrawn;

            //mmacct.Credit(100);
            //mmacct.DebitFee(500);

            //acct.Credit(50);
            //acct.Debit(100);

            #endregion

            #region Exceptions

            //int result = Factorial(3);
            //int result2 = Factorial(6);
            //int result3 = FactorialLambda(9);
            //Thread.Sleep(1);

            //long userinput = 1;
            //while (userinput != -1)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter a number");

            //    long.TryParse(Console.ReadLine(), out userinput);

            //    try
            //    {
            //        Console.WriteLine("The Factorial of {0} is " + FactExceptHandled(userinput), userinput);
            //    }
            //    catch (ArgumentOutOfRangeException)
            //    {
            //        Console.WriteLine("Number must be equal or greater than zero!");
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("Sorry, number is too big for the data type, try lower...");
            //    }
            //    Console.Write("Press any key to continue...");
            //    Console.ReadKey();
            //}

            #endregion

            #region Threading

            //Stopwatch sw = Stopwatch.StartNew();
            ////RunSequential();
            ////RunWithThreads();
            ////RunInThreadPool();
            //Console.WriteLine("Finished in {0}", sw.ElapsedMilliseconds);

            #endregion

            #region BackgroundWorker

            //BackgroundWorker IOReader = new BackgroundWorker();
            //IOReader.DoWork += IOReader_DoWork;
            //IOReader.RunWorkerCompleted += IOReader_RunWorkerCompleted;
            //IOReader.ProgressChanged += IOReader_ProgressChanged;
            //IOReader.RunWorkerAsync();

            //Console.WriteLine("Press any key");
            //Console.ReadKey();

            #endregion

            #region Task

            //Stopwatch sw = Stopwatch.StartNew();
            ////RunConcurrentTasks();
            //const int NUM_OPERATIONS = 3;
            //int userInput = 0;

            //while (userInput != 1)
            //{
            //    Console.WriteLine("Press enter to start or enter 1 to quit");
            //    int.TryParse(Console.ReadLine(), out userInput);
            //    sw.Restart();

            //    for (int i = 0; i < NUM_OPERATIONS; i++)
            //    {
            //        //
            //    }                

            //    Console.WriteLine("Time elapsed for operation {0}", sw.ElapsedMilliseconds);
            //}

            //Console.WriteLine("Finished in {0}", sw.ElapsedMilliseconds);

            #endregion

            #region EventWaitHandle

            //Console.WriteLine("Don't wait for calculations...");
            //RunInThreadPool();
            //Console.WriteLine("Wait for calculations...");
            //RunInThreadPoolWithEventWaitHandle();

            #endregion

            #region Barriers

            //BarrierMethod();

            #endregion

            #region Barrier with Cancellation

            //CancellationTokenSource ctokensource = new CancellationTokenSource();
            ////Add this token to the barrier wait method
            ////Call cancel on all tasks subscribed to the token
            ////are cancelled
            //Barrier bar = new Barrier(5);
            //bar.SignalAndWait(ctokensource.Token);
            //ctokensource.Cancel();

            #endregion

            #region Locks

            ////Lock a counter variable
            //int counter = 0;
            ////increment by adding a number to the counter
            //Interlocked.Add(ref counter, 1);
            ////Increment by one using built-in
            //Interlocked.Increment(ref counter);

            #endregion

            #region Reflection

            //Assembly assmb = Assembly.LoadFrom("C:\\MS.IT.PhoneAuth.PFClient.dll");
            //string modulename = "";
            //foreach (Module m in assmb.GetModules())
            //{
            //    Console.WriteLine("Module name: {0}", m.Name);
            //    modulename = m.Name;
            //    Console.WriteLine("Assembly : {0}", m.Assembly);
            //    Console.WriteLine("Module version: {0}", m.ModuleVersionId);
            //}

            //Module phoneauth = assmb.GetModule(modulename);

            //Type pfutil;

            //foreach (Type t in assmb.GetTypes())
            //{
            //    Console.WriteLine("Type name: {0}", t.Name);
            //    if (t.Name == "PFUtil")
            //    {
            //        pfutil = t;                    
            //    }
            //}

            #endregion

            #region Type Class

            //Person p1 = new Person("Travis", "Myers");
            //Person p2 = new Person("Kim", "Myers");
            //Person p3 = new Person("Christian", "Myers");
            //p1.PersonId = 47;
            //p2.PersonId = 40;
            //p3.PersonId = 296;
            //bool db = Person.PutPerson(p1);
            //db = Person.PutPerson(p2);
            //db = Person.PutPerson(p3);

            //System.Type mytype = p1.GetType();
            //Type enumType = p1.CountryOfBirth.GetType();

            //Console.WriteLine(enumType.GetEnumName(1));

            //foreach (string s in enumType.GetEnumNames())
            //{
            //    Console.WriteLine(s);
            //}

            //ConstructorInfo[] ctorinfo = mytype.GetConstructors();

            //foreach (ConstructorInfo ci in ctorinfo)
            //{
            //    foreach (ParameterInfo info in ci.GetParameters())
            //    {
            //        Console.WriteLine("name: {0} , type: {1}", info.Name, info.ParameterType);
            //    }
            //    Console.WriteLine(ci.GetMethodBody());
            //}

            #endregion

            #region Type Continued



            #endregion

            #region CodeDOM

            //CodeCompileUnit calculator = new CodeCompileUnit();
            //CodeNamespace playground = new CodeNamespace("Playground.Classes");

            //string[] imports = {"System", "System.Collections.Generic", "System.Linq", "System.Text", "System.Threading.Tasks" };

            //foreach (string s in imports)
            //{
            //    playground.Imports.Add(new CodeNamespaceImport(s));
            //}

            //calculator.Namespaces.Add(playground);

            //CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            //CodeGeneratorOptions options = new CodeGeneratorOptions();
            //options.BlankLinesBetweenMembers = false;
            //options.BracingStyle = "C";

            //using (StreamWriter sourceWriter = new StreamWriter(@"c:\Users\trmye\desktop\Calculator." + provider.FileExtension))
            //{
            //    provider.GenerateCodeFromCompileUnit(calculator, sourceWriter, options);
            //}

            #endregion

            #region Lambda Chapter 8

            //LambdaDelegate cwLambdaExp = new LambdaDelegate(LambdaExpressions.WriteToConsole);
            //cwLambdaExp += LambdaExpressions.WriteToConsoleInReverse;
            //cwLambdaExp("Zup");

            ////Anon
            //LambdaDelegate fw = delegate (string s)
            //{
            //    Console.WriteLine("anon: {0}", s);
            //};

            //fw("This delegate method has no name");



            #endregion

            #region Palindrome
            //string possiblePalindrome = "racecar";
            //var isPalindrome = GetStringIsPalindrome(possiblePalindrome);
            //Console.WriteLine(possiblePalindrome + " palindrome results " + isPalindrome);

            #endregion

            #region Data
            //int[,] twoDimIntArray = new int[3, 2];
            //twoDimIntArray[0,0] = 1;
            //twoDimIntArray[0,1] = 2;
            //twoDimIntArray[1,0] = 3;
            //twoDimIntArray[1,1] = 4;
            //twoDimIntArray[2,0] = 5;
            //twoDimIntArray[2,1] = 6;

            //string apple = "Apple";
            //string banana = "banana";
            //string orange = "orange";
            //string grape = "grape";
            //string kiwi = "kiwi";

            //ArrayList fruits = new ArrayList(5);

            //fruits.Add(grape);
            //fruits.Add(kiwi);
            //fruits.Add(apple);
            //fruits.Add(orange);
            //fruits.Add(banana);

            //PrintFruit(fruits);
            //fruits.Sort();
            //PrintFruit(fruits);

            #endregion

            #region DTO

            //using (var db = new MCSDDATABASE())
            //{
            //    db.dbConnection.Open();
            //    //db.sqlCommand.CommandType = CommandType.Text;
            //    //db.sqlCommand.CommandText = "INSERT INTO Person (FirstName, LastName) " +
            //    //                            "VALUES ('Joe', 'Smith')";
            //    //db.sqlCommand.ExecuteNonQuery();

            //    db.sqlCommand.CommandType = CommandType.StoredProcedure;
            //    db.sqlCommand.CommandText = "PersonInsert";
            //    db.sqlCommand.Parameters.Add(new SqlParameter("@FirstName", "Maddie"));
            //    db.sqlCommand.Parameters.Add(new SqlParameter("@LastName", "Myers"));
            //    db.sqlCommand.ExecuteNonQuery();
            //}

            //using (var db = new MCSDDATABASE())
            //{
            //    db.dbConnection.Open();

            //    db.sqlCommand.CommandType = CommandType.Text;
            //    db.sqlCommand.CommandText = "SELECT * FROM Person";

            //    SqlDataReader sdr = db.sqlCommand.ExecuteReader();

            //    if (sdr.HasRows)
            //    {
            //        while (sdr.Read())
            //        {
            //            Console.WriteLine(
            //                "First Name: {0},\tLast Name: {1}",
            //                sdr["FirstName"], sdr["LastName"]
            //                );
            //        }
            //    }

            //    sdr.Close();
            //}

            //using (var db = new MCSDDATABASE())
            //{
            //    db.dbConnection.Open();

            //    db.sqlCommand.CommandType = CommandType.Text;
            //    db.sqlCommand.CommandText = "SELECT * FROM Person FOR XML AUTO, XMLDATA";

            //    System.Xml.XmlReader xr = db.sqlCommand.ExecuteXmlReader();

            //    StreamWriter sw = new StreamWriter("C:\\Users\\trmye\\Desktop\\xml.txt");

            //    sw.Close();
            //    xr.Close();
            //}

            //Console.WriteLine("");

            #endregion

            #region DataAdapter

            //using (var db = new MCSDDATABASE())
            //{
            //    db.dbConnection.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Person", db.dbConnection);

            //    SqlCommand delete = new SqlCommand("DELETE FROM Person WHERE PersonId = @PersonId");

            //    sda.DeleteCommand = delete;

            //    //db.sqlCommand.CommandType = CommandType.StoredProcedure;
            //    //db.sqlCommand.CommandText = "PersonInsert";
            //    //db.sqlCommand.Parameters.Add(new SqlParameter("@PersonId", "1"));
            //    //db.sqlCommand.Parameters.Add(new SqlParameter("@FirstName", "Maddie"));
            //    //db.sqlCommand.Parameters.Add(new SqlParameter("@LastName", "Myers"));
            //    //db.sqlCommand.ExecuteNonQuery();

            //    DataSet personDataSet = new DataSet();
            //    sda.Fill(personDataSet, "Person");

            //    //personDataSet.Tables[0].Rows[0].Delete();

            //    //sda.Update(personDataSet.Tables[0]);
            //}

            #endregion

            #region Entity Framework

            //using (var db = new MCSDEntities())
            //{
            //    //var buicks = from a in db.Automobiles
            //    //             select a;
            //    //foreach (var buick in buicks)
            //    //{
            //    //    Console.WriteLine(buick.Name);
            //    //}

            //    Automobile ford = new Automobile()
            //    {
            //        Name = "Ford Mustang"
            //    };
            //    db.Automobiles.Add(ford);
            //    db.SaveChanges();
            //}

            #endregion

            #region IO Operations

            //string workingDirectoryString = Directory.GetCurrentDirectory();

            //DirectoryInfo workingDirectoryInfo = new DirectoryInfo(workingDirectoryString);
            //using (FileStream ioTestFileStream = new FileStream($"{workingDirectoryInfo}\\ioTestFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{

            //foreach (FileInfo info in workingDirectoryInfo.GetFiles())
            //{
            //    Console.WriteLine(info.Name);
            //}

            //foreach (DirectoryInfo info in workingDirectoryInfo.GetDirectories())
            //{
            //    Console.WriteLine(info.Name);
            //}


            //string hello = "\nhello world";
            //var length = ioTestFileStream.Length;
            //ioTestFileStream.Write(new UTF8Encoding(true).GetBytes(hello), 0, hello.Length);

            //ioTestFileStream.Close();

            //FileInfo ioTestFile = new FileInfo($"{workingDirectoryInfo}\\ioTestFile.txt");
            //using (StreamWriter ioTestFileStreamWriter = ioTestFile.AppendText())
            //{
            //    ioTestFileStreamWriter.WriteLine(@"One line of text.");
            //    ioTestFileStreamWriter.Close();
            //}

            //using (StreamReader fileReader = new StreamReader($"{workingDirectoryInfo}\\ioTestFile.txt"))
            //{
            //    var fileString = fileReader.ReadToEnd();
            //}

            //using (StreamWriter fileWriter = new StreamWriter($"{workingDirectoryInfo}\\ioTestFile.txt"))
            //{
            //    fileWriter.WriteLine("replace the file contents");
            //    fileWriter.WriteLine("add another line of text...");
            //}

            //using (BinaryWriter binaryWriter = new BinaryWriter(ioTestFileStream))
            //{   
            //    binaryWriter.Write("ABC");
            //    binaryWriter.Write(true);
            //    binaryWriter.Write(1);
            //    binaryWriter.Close();
            //}
            //}
            #endregion

            #region Serialization

            //BankAccount savings = new BankAccount();
            //savings.Balance = 20.00M;

            //IFormatter customFormatter = new BinaryFormatter();
            ////using (Stream accountStream = new FileStream("SavingsAccount.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            ////{
            ////    customFormatter.Serialize(accountStream, savings);
            ////    accountStream.Close();
            ////}

            //BankAccount savings2 = new BankAccount();

            //using (Stream accountStream = new FileStream("SavingsAccount.bin", FileMode.Open, FileAccess.Read))
            //{
            //    savings2 = (BankAccount)customFormatter.Deserialize(accountStream);
            //    Console.WriteLine(savings2.Balance);
            //}

            #endregion

            #region XML Serialization

            ////BankAccount serializedXMLBankAccount = new BankAccount();
            ////serializedXMLBankAccount.Balance = 30.00M;

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(BankAccount));
            ////using (StreamWriter xmlStreamWriter = new StreamWriter("XMLBankAccount.xml"))
            ////{
            ////    xmlSerializer.Serialize(xmlStreamWriter, serializedXMLBankAccount);
            ////    xmlStreamWriter.Close();
            ////}

            //using (Stream readXmlFileStream = new FileStream("XMLBankAccount.xml", FileMode.Open, FileAccess.Read))
            //{
            //    BankAccount xmlDeserializeBankAccount = (BankAccount)xmlSerializer.Deserialize(readXmlFileStream);
            //}

            #endregion

            #region JSON Serialization

            //BankAccount bankAccountJSON = new BankAccount();
            //bankAccountJSON.Balance = 50.00M;
            //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(BankAccount));

            //using (Stream jsonStream = new FileStream("BankAccount.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    jsonSerializer.WriteObject(jsonStream, bankAccountJSON);
            //}

            #endregion

            #region LINQ

            //int[] numbers = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            //                            11, 12, 13, 14, 15, 16, 17, 18,
            //                            19, 20};

            //var evenNumbers = from num2 in numbers
            //                  where num2 % 2 == 0 && num2 > 5
            //                  orderby num2 descending
            //                  select num2;

            //foreach (var number in evenNumbers)
            //{
            //    //Console.WriteLine(number);
            //}

            //List<Hometown> hometowns = new List<Hometown>()
            //{
            //    new Hometown() { City = "Philadelphia", State = "PA" },
            //    new Hometown() { City = "Ewing", State = "NJ" },
            //    new Hometown() { City = "Havertown", State = "PA" },
            //    new Hometown() { City = "Fort Washington", State = "PA" },
            //    new Hometown() { City = "Trenton", State = "NJ" },
            //    new Hometown() { City = "Cleveland", State = "OH" }
            //};

            //var orderedHometowns = from h in hometowns orderby h.State orderby h.City select h;

            //foreach (var town in orderedHometowns)
            //{
            //    //Console.WriteLine($"{town.City}, {town.State}");
            //}

            //List<Person> people = new List<Person>()
            //{
            //    new Person()
            //    {
            //        FirstName = "John",
            //        Lastname = "Smith",
            //        Address = "First St",
            //        City = "Havertown",
            //        State = "PA",
            //        ZipCode = "19084"
            //    },
            //    new Person()
            //    {
            //        FirstName = "Jane",
            //        Lastname = "Doe",
            //        Address = "Second St",
            //        City = "Ewing",
            //        State = "NJ",
            //        ZipCode = "08560"
            //    },
            //    new Person()
            //    {
            //        FirstName = "Jack",
            //        Lastname = "Jones",
            //        Address = "Third St",
            //        City = "",
            //        State = "",
            //        ZipCode = "19034"
            //    }
            //};

            //var lastNames = from p in people select p.Lastname;

            //foreach (var name in lastNames)
            //{
            //    //Console.WriteLine(name);
            //}

            //var wholeNames = from p in people select new { First = p.FirstName, Last = p.Lastname};

            //foreach (var name in wholeNames)
            //{
            //    //Console.WriteLine($"{name.Last}, {name.First}");
            //}

            ////JOIN
            //var peopleHometowns = from p in people
            //                      join h in hometowns on p.State equals h.State
            //                      select new { Name = $"{p.Lastname}, {p.FirstName} ", City = h.City};

            //foreach (var row in peopleHometowns)
            //{
            //    //Console.WriteLine(row.Name + row.City);
            //}

            ////LEFT OUTER JOIN
            //var leftOuterJoin = from p in people
            //                    join h in hometowns on p.State equals h.State
            //                    into peopleCitys
            //                    from item
            //   in peopleCitys.DefaultIfEmpty(new Hometown {City = "Los Angeles", State = "CA" })
            //                    select new { Name = $"{p.Lastname}, {p.FirstName} ", item.City };

            //foreach (var person in leftOuterJoin)
            //{
            //    //Console.WriteLine(person.Name + person.City);
            //}

            //var groupPeopleByState = from p in people
            //                         group p by p.State;

            #endregion

            #region Input Validation



            #endregion

            #endregion

            #region Chapter 1 Exam Ref 70-483

            #region Tasks and the UI

            #endregion

            #region Thread
            //Thread wodThread = new Thread((data) =>
            //{
            //    WorkOnData(data);
            //});
            //wodThread.Start(25);
            //Console.ReadKey();

            //Thread.CurrentThread.Name = "Main Thread";
            //DisplayThreadCulture(Thread.CurrentThread);

            #region Concurrent

            //ConcurrentQueue<string> cQueue = new ConcurrentQueue<string>();
            //cQueue.Enqueue("Kim");
            //cQueue.Enqueue("Trav");
            //cQueue.Enqueue("Christian");
            //cQueue.Enqueue("Maddie");

            //string str;
            //if (cQueue.TryPeek(out str))
            //{
            //    Console.WriteLine("Peek: {0}", str);
            //}

            //if (cQueue.TryDequeue(out str))
            //{
            //    Console.WriteLine("Dequeue: {0}", str);
            //}

            #endregion

            #endregion

            #region Random stuff
            //string testString = "Hello world travis second try";
            //StringBuilder sb = new StringBuilder();
            //string[] testStringArray = testString.Split(' ');
            //foreach (var item in testStringArray)
            //{
            //    sb.Insert(0, " " + item);
            //}

            //Console.WriteLine(sb.ToString());
            #endregion

            #region Perform Symmetric and Asymmetric Encryption

            
            #endregion

            #endregion
        }

        private static void DisplayThreadCulture(Thread t)
        {
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Culture : {0}", t.CurrentCulture);
            Console.WriteLine("Priority : {0}", t.Priority);
            Console.WriteLine("Context : {0}", t.ExecutionContext);
            Console.WriteLine("Context : {0}", t.ExecutionContext.ToString());
            Console.WriteLine("IsBackground? : {0}", t.IsBackground);
            Console.WriteLine("IsPool? : {0}", t.IsThreadPoolThread);            
        }

        private static void WorkOnData(object obj)
        {
            Console.WriteLine("Working on {0}", obj);
            Thread.Sleep(2000);
        }

        private static void PrintFruit(ArrayList list)
        {
            foreach (object o in list)
                Console.WriteLine(o.ToString());
        }

        private static object GetStringIsPalindrome(string possiblePalindrome)
        {
            char[] charArray = possiblePalindrome.ToCharArray();
            charArray.Reverse();
            String temp = charArray.ToString();
            String temp2 = (String)possiblePalindrome;
            return temp.Contains(possiblePalindrome);

        }

        private static void BarrierMethod()
        {
            var participants = 5;

            Barrier rendezvous = new Barrier(participants + 1,
                a =>
                {
                    Console.WriteLine("{0} participants are at rendez-vous point {1}",
                        a.ParticipantCount -1, a.CurrentPhaseNumber
                        );
                });

            for (int i = 0; i < participants; i++)
            {
                var localCopy = i;

                Task.Run(
                        () =>
                        {
                            Console.WriteLine("Task {0} left point A", localCopy);
                            Thread.Sleep(1000 * localCopy + 1); //Simulated work

                            if (localCopy % 2 == 0)
                            {
                                Console.WriteLine("Task {0} arrived at point B", localCopy);
                                rendezvous.SignalAndWait();                                
                            }
                            else
                            {
                                Console.WriteLine("Task {0} changed its mind and returned to A", localCopy);
                                rendezvous.RemoveParticipant();
                                return;
                            }

                            Thread.Sleep(1000 * (participants - localCopy)); //Simulate more work
                            Console.WriteLine("Task {0} arrived at point C", localCopy);
                            rendezvous.SignalAndWait();
                        }
                    );
            }

            Console.WriteLine("Main thread waiting for {0} tasks...", rendezvous.ParticipantCount -1);
            rendezvous.SignalAndWait();
            rendezvous.SignalAndWait();
            Console.WriteLine("Main thread is done");
        }

        private static void RunConcurrentTasks()
        {
            double results = 0d;

            const int NUM_REPITITIONS = 16;

            Task<double>[] multiTask = new Task<double>[NUM_REPITITIONS];

            for (int i = 0; i < NUM_REPITITIONS; i++)
            {
                multiTask[i] = Task.Run(() => DoIntensiveCalculation());
            }

            Task.WaitAll(multiTask);

            foreach (var task in multiTask)
            {
                results += task.Result;
            }

            Console.WriteLine("Result is {0}", results);
        }

        private static void IOReader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
        }

        private static void IOReader_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = ReadDataFromIO();            
        }

        private static void IOReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Console.WriteLine("IO read result {0}", e.Result); 
            }
        }

        private static void RunInThreadPool()
        {
            double result = 0d;

            ThreadPool.QueueUserWorkItem((x) => result = ReadDataFromIO());

            // TODO: Wait for thread to complete

            double result2 = DoIntensiveCalculation();
            result += result2;
            Console.WriteLine("Results {0}", result);
        }

        private static void RunInThreadPoolWithEventWaitHandle()
        {
            double result = 0d;
            EventWaitHandle calculationsDone = new EventWaitHandle(false, EventResetMode.ManualReset);

            ThreadPool.QueueUserWorkItem((x) =>
            {
                result += ReadDataFromIO();
                calculationsDone.Set();
            });

            double result2 = DoIntensiveCalculation();
            calculationsDone.WaitOne();

            result += result2;
            Console.WriteLine("Results {0}", result);
        }

        private static void RunWithThreads()
        {
            double result = 0d;

            Thread readData = new Thread(() => result = ReadDataFromIO());
            readData.Start();

            double result2 = DoIntensiveCalculation();
            readData.Join();

            result += result2;
            Console.WriteLine("Result is {0}", result);
        }

        private static void RunSequential()
        {
            double result = 0d;

            result += ReadDataFromIO();
            result += DoIntensiveCalculation();

            Console.WriteLine("The result is {0}", result);
        }

        private static double DoIntensiveCalculation()
        {
            double result = 100000000d;

            int maxInt = int.MaxValue;

            for (int i = 1; i < maxInt; i++)
            {
                result /= i;
            }

            return result + 10d;
        }

        private static Task<double> ReadDataFromIOAsync()
        {
            return Task.Run(new Func<double>(ReadDataFromIO));
        }

        private static double ReadDataFromIO()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Received data");
            return 10d;
        }

        private static int Factorial(int v)
        {
            if (v == 1)
            {
                return 1;
            }
            else
            {
                return v * Factorial(v - 1);
            }
        }

        private static long FactExceptHandled(long v)
        {
            if (v < 0)
            {
                throw new ArgumentOutOfRangeException("The number must be at least zero or greater");
            }

            checked
            {
                long result = 1;
                for (long i = 2; i <= v; i++) result *= i;
                return result; 
            }
        }

        private static int FactorialLambda(int v) => v == 1 ? 1 : v * FactorialLambda(v - 1);

        private static void Acct_Overdrawn(object sender, OverdrawnEventArgs e)
        {
            if (sender is BankAccount)
            {
                if (e.CurrentBalance < e.DebitAmount)
                {
                    Console.WriteLine("There is a $25.00 overdraft fee!");
                }
            }
        }

        private static int CWPageNumber()
        {
            return 500;
        }

        private static void PrintTitles(List<Book> readingList)
        {
            foreach (Book item in readingList)
            {
                Console.WriteLine(item.Title);
            }
        }

        private static Action<string> DoSomething = (message) => Console.WriteLine(message);

        private static async Task DoSomethingAsync() { await Task.Delay(5000); }

        private static Action<Employee> EmployeeParameterMethodAction;

        private static Func<Person> ReturnPersonMethodFunction;

        private static Func<float, float> SquareFunction = delegate (float x) { return x * x; };
    }
}
