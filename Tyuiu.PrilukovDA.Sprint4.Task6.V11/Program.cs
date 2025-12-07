using Tyuiu.PrilukovDA.Sprint4.Task6.V11.Lib;

DataService ds = new DataService();

string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

Console.WriteLine(ds.Calculate(array));