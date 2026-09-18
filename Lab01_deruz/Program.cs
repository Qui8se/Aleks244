// Console.WriteLine("Hello, World!");



// string myName = "Александр";
// string groupName = "ИСП-251";
// int courseNumber = 2;
// double averageGrade = 4.6;
// bool isBudget = true;

// Console.WriteLine("Знакомство");
// Console.WriteLine($"Студент: {myName}");
// Console.WriteLine($"Группа: {groupName}");
// Console.WriteLine($"Курс: {courseNumber}");
// Console.WriteLine($"Средний балл:{averageGrade}");
// Console.WriteLine($"Бюджетное место: {isBudget}");




// Console.WriteLine();
// Console.WriteLine("Ремонт: комната");

// double roomWidth = 3.5;
// double roomLength = 4.2;

// double roomArea = roomWidth * roomLength;
// double roomPerimeter = (roomWidth + roomLength) * 2;

// Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
// Console.WriteLine($"Площадь: {roomArea} кв.м");
// Console.WriteLine($"Периметр: {roomPerimeter} м");






// Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 65000;
// int monthCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthCount;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");




// Console.WriteLine();
// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;
// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");





// Console.WriteLine();
// Console.WriteLine("Способы собрать строку");

// string firstName = "Анна";
// string lastName = "Cмирнова";

// способ 1: конкатенация через оператор +
// string fullNameConcat = firstName + " " + lastName;

// Способ 2: интерполяция через $""
// string fullNameInterp = $"{firstName} {lastName}";

// Способ 3: метод String.Concat
// string fullnameConcatMethod = string.Concat(firstName, " ", lastName);

// Console.WriteLine(fullNameConcat);
// Console.WriteLine(fullNameInterp);
// Console.WriteLine(fullnameConcatMethod);
// Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullnameConcatMethod}");




// Console.WriteLine();
// Console.WriteLine("Константы");
// //НДС фиксирован законом, поэтому const
// const double VatRate = 0.20;
// const string CollegeName = "ВФ ВолГУ";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Учебное заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}):{priceWithVat}");




// Console.WriteLine();
// int scholarship = 800;
// int monthlyExpenses = 4800;
// const int MonthsInSemester = 4; 

// int monthlyMoney = scholarship - monthlyExpenses;
// Console.WriteLine($"Остаток за месяц: {monthlyMoney}");


// int semesterMoney = MonthsInSemester * monthlyMoney;
// Console.WriteLine($"Остаток за семестр: {semesterMoney}");






// int totalMinutes = 500;
// int minutesPerLesson = 45;

// int lesson = totalMinutes / minutesPerLesson;
// int lessonOst = totalMinutes % minutesPerLesson;

// Console.WriteLine($"{totalMinutes} минут = {lesson} полных занятий + {lessonOst} минут");



