namespace SearchTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X = 10;
            int Y = 20;
                                                                                                                      خزنا القيمه 10 و القيمه 20 ف متغير من نوع int  عشان نفيش قيمه عشريه في المتغير 
                                                                                                                      
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
                                                                                                                      استخدمنا الكونسول والفورمات ب علامة الدولار عشان نقدر نضيف ونجمع القيم الي عندنا و الناتج يطلع بالشكل دا 
                          Equation: 10 +20 = 30$
                          
                                                                                                                                      والناتج طلع 30 عشان جمعناهم مع بعض ب opretor +  وزودنا الكولون وحرف ال c  عشان يبقا في علامة الدولار مع الناتج , ودي بتتغير علي حسب السيتينج بتاع السيستم معموله علي اي دوله يعني لو ف اوروبا هتتغير و هتتعمل علامة اليورو 

*************************************************************************************************
 another example 
 ********************
 namespace SearchTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 500;
            int Y = 3000;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:N0}");

        }
    }
}

 


        }
    }
}
