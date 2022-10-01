namespace dias
{
    public  class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            double bisiesto = anyo % 4;

            Console.WriteLine("ingrese el año ");
            anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresa el mes");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el dia");
            dia = Convert.ToInt32(Console.ReadLine());


            if (mes == 1 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 2 && dia > 28)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 3 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 4 && dia > 30)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 5 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 6 && dia > 30)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 7 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 8 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 9 && dia > 30)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 10 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 11 && dia > 30)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            if (mes == 12 && dia > 31)
            {
                Console.Write("sobre paso la fecha");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            DateTime mifecha = new DateTime(anyo, mes, dia);
            mifecha = mifecha.AddDays(1);

            Console.WriteLine(mifecha);
        }
    }
}
