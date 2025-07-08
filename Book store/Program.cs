namespace Book_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryService inventoryService = new InventoryService();
            inventoryService.AddBook(new PaperBook("A1","c#",200,2,10));
            inventoryService.AddBook(new EBook("B1", ".Net", 150, 3, "PDF"));
            inventoryService.AddBook(new ShowcaseBook("c1", "java", 300, 2));
            Console.WriteLine();
            
                double paid1 = inventoryService.BuyBook("A1", 2, "abeerreda07@gmail.com", "obour city");
                Console.WriteLine(paid1);
                double paid2 = inventoryService.BuyBook("B1", 3, "abeerreda07@gmail.com", "");
                Console.WriteLine(paid2);
            inventoryService.RemoveBook(9);
        }
    }
}
