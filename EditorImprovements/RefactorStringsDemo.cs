namespace EditorImprovements
{
    class RefactorStringsDemo
    {
        public void StringInterpolationDemo()
        {
            var name = "Test Testerson";
            var greeting = string.Format("Hello {0}", name);
        }

        public void LongString()
        {
            var text = "Öl är en av de äldsta alkoholdryckerna i människans historia. Det är troligt att den första ölliknande drycken skapades genom att blött bröd jäste och därigenom skapades en lätt alkoholhaltig dryck.";
        }
    }
}
