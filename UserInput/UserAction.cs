using System.ComponentModel;

namespace CliTaskTracker.UserInput;

public enum UserAction
{
    Create,
    Update,
    Delete,
    List,
    MarkDone,
    MarkInProgress
}