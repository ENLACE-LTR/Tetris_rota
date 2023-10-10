using System.Drawing;
char opcion = ' ';
string[,] cubo = { { "▄▄","▄▄" } ,
                   { "▄▄","▄▄"}};
string[,] l = { { "▄▄", "▄▄", "▄▄", "▄▄" } };
string[,] l2 = { { "▄▄" }, { "▄▄" }, { "▄▄" }, { "▄▄" } };
string vacio = "[]";
string[,] tablerov = { { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },};
while (opcion != 's')
{
    
    Console.WriteLine("Bienvenido a TETRIS: \n[I]Iniciar\n[S]Salir");
    opcion = char.Parse(Console.ReadLine().ToLower());
    switch (opcion)
    {
        case 'i':
            tetris();
            break;

        default:
            Console.WriteLine("ingrese una opcion valida");
            break;
    }

}
void tetris()
{
    int i= 0;
    int derecha = 1;
    int izquierda = 0;
    char finciclo = ' ';
    while (finciclo != 's')
    {
        Thread.Sleep(1000);
        tablero();
        if (tablerov[19, 0] == cubo[1,0] && tablerov[19, 1] == cubo[1,1] )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FIIIIIIIIIIIIIIIIIIIIIIIIIIIIIN");
            finciclo = 's';
        }
        else
        {
            if(i!=0)
            { 
                tablerov[i - 1,0] = vacio;
                tablerov[i - 1,1] = vacio;
            }
            tablerov[i, izquierda] = cubo[0, 0];
            tablerov[i, derecha] = cubo[0, 1];
            tablerov[i+1, izquierda] = cubo[1, 0];
            tablerov[i+1, derecha] = cubo[1, 1];
            i++;
            
        }
       





    }
    finciclo = ' ';
    i = 0;
    bool voltea=false;
    while (finciclo != 's')
    {
        Thread.Sleep(1000);
        tablero();
           if (Console.ReadKey().Key == ConsoleKey.RightArrow) 
        {
            voltea = true;
        }
        else 
        {
            voltea= false;
        }
        if (voltea == false)
        {
            if (tablerov[19, 3] == l[0, 0] && tablerov[19, 4] == l[0, 1] && tablerov[19, 5] == l[0, 2] && tablerov[19, 6] == l[0, 3])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FIIIIIIIIIIIIIIIIIIIIIIIIIIIIIN");
                finciclo = 's';
            }
            else
            {
                if (i != 0)
                {
                    tablerov[i - 1, 2] = vacio;
                    tablerov[i - 1, 3] = vacio;
                    tablerov[i - 1, 4] = vacio;
                    tablerov[i - 1, 5] = vacio;
                }
                tablerov[i, 2] = l[0, 0];
                tablerov[i, 3] = l[0, 1];
                tablerov[i, 4] = l[0, 2];
                tablerov[i, 5] = l[0, 3];

                i++;

            }
        }
        else
        {
            if (tablerov[19, 3] == l[0, 0] )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FIIIIIIIIIIIIIIIIIIIIIIIIIIIIIN");
                finciclo = 's';
            }
            else
            {
                if (i != 0)
                {
                    tablerov[i - 1, 2] = vacio;
                   
                }
                tablerov[i, 2] = l[0, 0];
                tablerov[i++, 2] = l[0, 1];
                tablerov[i+2, 2] = l[0, 2];
                tablerov[i+3, 2] = l[0, 3];

                i++;

            }
        }
     





    }





}


void tablero()
{
    Console.Clear();
    char finciclo = ' ';
    int lineahecha=0;
    string pieza = "";
   
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("-------------");
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write("T");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("E");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("T");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("R");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("I");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("S");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("--------------");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    //filas=i
  for (int i = 0; i<=19; i++)
    {
        //linea
      
            if (i == 0)
            {
                Console.Write("     Lineas ");
            }
            if (i == 1)
            {
                Console.Write(lineahecha + "           ");
            }
            if (i != 0 && i != 1)
            {
                Console.Write("            ");
            }
            Console.Write(tablerov[i, 0] + tablerov[i, 1] + tablerov[i, 2] + tablerov[i, 3] + tablerov[i, 4] + tablerov[i, 5] +
                 tablerov[i, 6] + tablerov[i, 7] + tablerov[i, 8] + tablerov[i, 9]);
        Console.WriteLine();
        
  
    }





}
