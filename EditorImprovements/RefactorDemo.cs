namespace EditorImprovements
{
    class RefactorDemo
    {
        public int Number { get; set; }        
        public void InitDemo()
        {
            var p = new Person();
            p.Name = "Test Testerson";
            p.Age = 13;
            p.Phone = "070-555-1212";
            p.Address = "Storgatan 1";
            p.ZipCode = "111 22";
            p.City = "Storstad";
        }
    }
}
