﻿namespace FP.Patterns.Command.Exercice2
{
    public class TextEditor
    {
        private Stack<ICommand> _undoStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if( _undoStack.Count > 0 )
            {
                ICommand command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Redo()
        {
            if(_redoStack.Count > 0 )
            {
                ICommand command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
            else
            {
                Console.WriteLine("Nothing to redo.");
            }
        }
    }
}
