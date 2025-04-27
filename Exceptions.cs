
    public class NullLoginOrPass : Exception
{
    public NullLoginOrPass(string mess) : base(mess)
    {

    }
}
public class ShortLogin : Exception
{
    public ShortLogin(string mess) : base(mess)
    {

    }
}
public class ShortPass : Exception
{
    public ShortPass(string mess) : base(mess)
    {

    }
}
