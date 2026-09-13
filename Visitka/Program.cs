Console.WriteLine();
Console.WriteLine("Визитна карточка студента");

string name = "Александр";
string group = "ИСП-251";
int course = 2;

// код специальности всегда один, поэтому константа
const string speciality = "09.02.07";

double firstWork = 4.0;
double secondWork = 5.0;
double thirdWork = 5.0;

// Считаем реднее арифметическое за 3 работы 
double averageScore = (firstWork + secondWork + thirdWork) / 3;

bool scholarship = true;

int allWeeks = 18;
int lastWeeks = 2;

//Считаем сколько недель осталось
int weeks = allWeeks - lastWeeks;

Console.WriteLine($"ФИО: {name}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {speciality}");
Console.WriteLine($"Средний балл за 3 работы: {averageScore}");
Console.WriteLine($"Стипендия положена (>= 4.0): {scholarship}");
Console.WriteLine($"Учебных недель осталось в семестре: {weeks}");
