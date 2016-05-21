namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }
        public string Name { get; set; }
        public Approver(string name)
        {
            this.Name = name;
        }
        public abstract void ProcessRequest(PurchaseRequest request); 
    }
}