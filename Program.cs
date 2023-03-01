Person me = new();
me.PrintAll();
me = new("Иванова", "Кристина", Convert.ToDateTime("11.12.2003"), 'Ж');
me.PrintAll();
Person me1 = new(me);
me1.PrintAll();

Console.Write("Введите количество пользователей: ");
int n = Convert.ToInt32(Console.ReadLine());
Person[] arr = new Person[n];

for (int i = 0; i < n; i++)
{
    arr[i] = new Person();
    arr[i].InputSurname();
    arr[i].InputName();
    arr[i].InputBirthday();
    arr[i].InputSex();
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
    arr[i].PrintAll();
