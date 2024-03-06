using FP.Patterns.Command.Exercice2;

TextDocument document = new();
TextEditor editor = new();

ICommand insertCommand1 = new InsertCommand(document, 0, "Hello, ");
editor.ExecuteCommand(insertCommand1);

ICommand insertCommand2 = new InsertCommand(document, 7, "world!");
editor.ExecuteCommand(insertCommand2);

Console.WriteLine($"Current content: {document.Content}");

// Delete text
ICommand deleteCommand = new DeleteCommand(document, 7, 6); // Deleting "world!"
editor.ExecuteCommand(deleteCommand);

Console.WriteLine("Current content: " + document.Content); // Output: Hello,

// Undo delete
editor.Undo();
Console.WriteLine("Current content after undo: " + document.Content); // Output: Hello, world!

// Redo delete
editor.Redo();
Console.WriteLine("Current content after redo: " + document.Content); // Output: Hello,

// Undo insert
editor.Undo();
Console.WriteLine("Current content after undo: " + document.Content); // Output: (empty)

Console.ReadLine();