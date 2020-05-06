using System;



public enum ProcessCodes : ushort
{
    Login,
    Register,
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
    Erorr
}