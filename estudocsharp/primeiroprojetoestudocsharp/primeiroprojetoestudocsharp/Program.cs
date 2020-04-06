    using System;
    using System.Globalization;


namespace primeiroprojetoestudocsharp
    {
        class Program
        {
            static void Main(string[] args)
            {
            /*int A, B, X; ------------- URI 1002 (SOMA SIMPLES) ---------------

            A = int.Parse(Console.ReadLine());

            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);

           Console.ReadLine();*/


            /*int A, B, SOMA; --------------------- URI 1003 (SOMA) ------------------

            A = int.Parse(Console.ReadLine()); 
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);


            Console.ReadLine();*/

            /*int a, b, PROD; --------------------- URI 1004 (CALCULO PROD) ----------------

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + PROD);

            Console.ReadLine();*/

            /*int A, B, C, D, DIFERENCA;   ------------ URI 1007 (DIFERENCA) ---------------


            A = int.Parse(Console.ReadLine());
             B = int.Parse(Console.ReadLine());
             C = int.Parse(Console.ReadLine());
             D = int.Parse(Console.ReadLine());

             DIFERENCA = A * B - C * D;

             Console.WriteLine("DIFERENCA = " + DIFERENCA);

             Console.ReadLine();*/


            /*double R, A, pi = 3.14159; --------------URI 1002 (CALCULO AREA)----------------

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));*/

            /*double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();*/

            /*int a, b; -------------------------URI 1008 (SALARIO)------------------------
            double c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = double.Parse(Console.ReadLine());
            
            d = b * c;

            Console.WriteLine("NUMBER = " + a);
            Console.WriteLine("SALARY = U$ " + d.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();*/


            /* int cod1, cod2, qntd1, qntd2;
             double preco1, preco2, total;

             string[] valores = Console.ReadLine().Split(' ');

             cod1 = int.Parse(valores [0]);
             qntd1 = int.Parse(valores[1]);
             preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

             valores = Console.ReadLine().Split(' ');
             cod2 int.Parse(valores[0]); 
             qntd2 int.Parse(valores[1]);
             preco2 double.Parse(valores[2], CultureInfo.InvariantCulture);

             total = preco1 * qntd1 + preco2 * qntd2;

             Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));*/

            /*int cod1, cod2, qte1, qte2; ------------------ URI 1010 (NAO CONSEGUI RESOLVER) ---------------
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();*/

            /*int X; ----------- URI 1014 ( CONSUMO ) ----------
            double Y, kml;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml =(double) X / Y;

            Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            Console.ReadLine();*/

            /*int distancia, tempo; ----------- URI 1016 (KM) -------------- 

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");

            Console.ReadLine();*/

            /*int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            // aqui eh importante colocar o .0 depois do 12, ou entao fazer o casting (double)
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));*/


            /*int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
           
            litros = distancia / 12.0;
           
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            
            Console.ReadLine();*/

            /*double b, a, area, perimetro, diagonal;

            
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * b + 2 * a; 
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();*/

            /*string nome1, nome2; ----------- idade media ---------------
            int idade1, idade2;
            double media;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine(" A idade média de " + nome1 + " e " + nome2 + " é de "
                + media.ToString("F1", CultureInfo.InvariantCulture) + " anos ");

            Console.ReadLine();*/


            /*string nome; ------------------- uri 1009 (salario com bonus) -------------------
            double salario, vendas, salario_total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario_total = vendas * 15.0 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + salario_total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();*/


            /*string Nome;
            double SalarioBruto, PlanoSaude = 290.94, Inss, IRRF, Passagem, ValorHr, ValorHrExtra, HrExtraFeita, ValorHrExtraFeita, SalarioBrutoCdesc, SalarioLiquido, HrCdesc;

            Nome = Console.ReadLine();
                        
            SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // calcular horas para descontar
            HrExtraFeita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PlanoSaude = PlanoSaude;
            Inss = SalarioBruto * 11.0 / 100;
            //IRRF = SalarioBruto * 22.5 / 100 - Inss;
            Passagem = SalarioBruto * 6.0 / 100;
            ValorHr = SalarioBruto / 176.0;
            ValorHrExtra = ValorHr * 1.50;
            ValorHrExtraFeita = HrExtraFeita * ValorHrExtra;
            HrCdesc = ValorHrExtraFeita * 11.0 / 100;
            //SalarioBrutoCdesc = SalarioBruto + ValorHrExtraFeita;
            SalarioLiquido = (SalarioBruto + ValorHrExtraFeita) - PlanoSaude - Inss - Passagem;


            Console.WriteLine("Nome do funcionario = " + Nome);
            Console.WriteLine("Salario Bruto = " + SalarioBruto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Plano de Saude = " + PlanoSaude.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Desconto Inss = " + Inss.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine("Imposto de Renda = " + IRRF.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Desconto Passagem = " + Passagem.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Hora = " + ValorHr.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Hora Extra = " + ValorHrExtra.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Total de Horas em R$ = " + ValorHrExtraFeita.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Total de Horas C/desconto = " + HrCdesc.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Salario Liquido = " + SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();*/


            /*double raio, volume;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));*/


            /*int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos + ":");*/

            /*int N, anos, meses, dias, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + "dia(s)");*/

            Console.ReadLine();








        }
    }
}

            


            











