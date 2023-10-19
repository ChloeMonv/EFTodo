
TodoContext context = new TodoContext();

Todo todo1 = new Todo(1, "Manger", false);
Todo todo2 = new Todo(2, "Pilotage", false);
Todo todo3 = new Todo(3, "TBM", true);

context.Add(todo1);
context.Add(todo2);
context.Add(todo3);

context.SaveChanges();


// todo3.Date = DateTime.Now;

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~Ensemble des Todo ~~~~~~~~~~~~~~~~~~~~~~~~");

foreach (Todo t in context.Todo)
{
    Console.WriteLine($"ID : {t.Id} , Tache : {t.Task} , Completé : {t.Completed}");

}

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~Todo a faire ~~~~~~~~~~~~~~~~~~~~~~~~");

foreach (Todo t in context.Todo)
{

    if (t.Completed == false) Console.WriteLine($"ID : {t.Id} , Tache : {t.Task} , Deadline : {t.Date}");

}

foreach (Todo t in context.Todo)
{

    if (t.Completed == false) t.Completed = true;

}

context.SaveChanges();

// context.Remove(todo1);
// context.Remove(todo2);
// context.Remove(todo3);

context.SaveChanges();
