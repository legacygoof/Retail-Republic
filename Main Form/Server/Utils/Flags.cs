using System;



public enum ProcessCodes : ushort
{
    Login,
    Register,
    Message,
    Ban,
    Kick,
    Reboot,
    Version,
    Logger,
    Command,
    UpdateUsers,
    Fail
}

public enum ErrorCodes : ushort
{
    Login_Success,
    Exists,
    Invalid_Login,
    Banned,
    Token_Used,
    Is_Logged_In,
    Version_Success,
    Error
}