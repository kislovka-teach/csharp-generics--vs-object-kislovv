namespace DesignPatternsGof.Task1;

public class A
{
    public virtual void Do()
    {
        if (IsCon())
        {
            //Do smth smart A
        }
    }
    public bool IsCon()
    {
        return true;
    }
}

public class B : A
{
    public override void Do()
    {
        if (IsCon())
        {
            //Do smth smart B
            base.Do();    
        }
    }
}

public class C : B
{
    public override void Do()
    {
        if (IsCon())
        {
            //Do smth smart C
            base.Do();    
        }
        
    }
}