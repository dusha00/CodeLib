namespace Adapter
{
    public class USBInterface
    {
        public void USBReadMsg()
        {
            var adapter=new PS2ToUSB();
            adapter.ReadMsg();
        }
    }
}