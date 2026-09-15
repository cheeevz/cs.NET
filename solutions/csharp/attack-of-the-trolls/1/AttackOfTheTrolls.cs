enum AccountType {
    Guest,
    User,
    Moderator
}

[Flags]
enum Permission {
    None   = 0,
    Read   = 1 << 0,  // 0001 = 1
    Write  = 1 << 1,  // 0010 = 2
    Delete = 1 << 2,  // 0100 = 4
    All    = Read | Write | Delete  // 0111 = 7
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType) {
            case AccountType.Guest :
                return Permission.Read;
            case AccountType.User :
                return Permission.Read | Permission.Write;
            case AccountType.Moderator :
                return Permission.All;
            default :
                return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current &~ revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        if (current == Permission.All) {
            return true;
        }
        return (current & check) == check;
    }
}
