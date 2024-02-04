using _10MetodosLinq.Entities;

var fruits = new List<string>();
fruits.Add("🍒");
fruits.Add("🍒");
fruits.Add("🍍");
fruits.Add("🍏");
fruits.Add("🍑");
fruits.Add("🫐");
fruits.Add("🍌");
fruits.Add("🍉");
fruits.Add("🍇");
fruits.Add("🍓");

//1 - Primeiro elemento
Console.WriteLine(fruits.First());
//Primeiro elemento ou valor padrão (padrão também pode ser definido)
Console.WriteLine(fruits.FirstOrDefault("Não encontrei!"));

//2 - Verificar se um elemento existe na lista
Console.WriteLine(fruits.Any(x => x == "🍌"));

//Any() é um tipo booleano, e eu posso passar uma expressão lambida para ele

//forma menos performatica e não recomendada
Console.WriteLine(fruits.Where(x => x == "🍌").Count() == 1);

//3 - Verificar se todos os elementos são do mesmo tipo
Console.WriteLine(fruits.All(x => x == "🍌"));

//Exemplo real
var students = new List<Student>();
students.Add(new Student() { Name = "A", Age = 18 });
students.Add(new Student() { Name = "B", Age = 18 });
students.Add(new Student() { Name = "C", Age = 30 });

Console.WriteLine(students.All(x => x.Age >= 18));

// 4 - Contar
Console.WriteLine(fruits.Count);
Console.WriteLine(students.Count(students => students.Age == 18));

// 5 - ElementAt - Índice
Console.WriteLine(fruits.ElementAt(1));

// 6 - Take
foreach (var fruit in fruits.Take(1))
{
    Console.WriteLine(fruit);
}

// 7 - Where

foreach (var fruit in fruits.Where(fruit => fruit == "🍒" || fruit == "🍌"))
{
    Console.WriteLine(fruit);
}

// 8 - Single
Console.WriteLine(fruits.First());
///Console.WriteLine(fruits.SingleOrDefault(fruit => fruit == "🍒"));

// 9 - Last
Console.WriteLine(fruits.Last());
Console.WriteLine(fruits.Last(fruit => fruit == "🍒"));

// 10 - Skip
foreach (var fruit in fruits.Skip(2))
{
    Console.WriteLine(fruit);
}

// 11 - MaxBy
var oldestStudent = students.MaxBy(student => student.Age);
Console.WriteLine(oldestStudent.Name);
//better than
var oldestStudent2 = students.OrderByDescending(student => student.Age).FirstOrDefault();
Console.WriteLine(oldestStudent.Name);

// 12 - MinBy
var youngestStudent = students.MinBy(student => student.Age);
Console.WriteLine(youngestStudent.Name);