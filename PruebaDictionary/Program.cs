using PruebaDictionary;

Student std1 = new(1, "Pedro", "López", 18);
Student std2 = new(2, "Susana", "Pérez", 20);
Student std3 = new(3, "Roberto", "Zapata", 17);
Student std4 = new(4, "Andrés", "Espinoza", 21);

Dictionary<int, Student> students = 
    new Dictionary<int, Student>();

students.Add(std1.Id, std1);
students.Add(std2.Id, std2);
students.Add(std3.Id, std3);
students.Add(std4.Id, std4);

foreach (var item in students.Values)
{
    Console.WriteLine("Nombre: {0}; Edad: {1}", item.Name, item.Age); 
}