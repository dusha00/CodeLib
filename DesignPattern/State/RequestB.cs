namespace State
{
    public class RequestB : State
    {
        public override void Handler(Context context)
        {
            context.State = new RequestB();
        }
    }
}