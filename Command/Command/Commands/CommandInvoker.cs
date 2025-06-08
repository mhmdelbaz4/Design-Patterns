﻿using Command.Commands;

namespace Command.Command;
public class CommandInvoker
{
    private readonly List<ICommand> _commands = new();
    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }
    public void InvokeAll()
    {
        foreach (var command in _commands)
        {
            command.Invoke();
        }
        _commands.Clear();
    }
}
