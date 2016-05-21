namespace Mediator
{
    public class ParterB:AbstractCardPartner
    {
        public override void ChangeCount(int Count, AbstractMediator mediator)
        {
             mediator.BWin(Count);
        }
    }
}