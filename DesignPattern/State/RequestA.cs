namespace State
{
    public class RequestA:State
    {
        public override void Handler(Context context)
        {
             context.State=new RequestA(); 
        }
    }
}