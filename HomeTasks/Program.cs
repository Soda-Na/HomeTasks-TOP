using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._2023
{   
    class Project
    {
        int underpinning;
        int walls;
        int roof;
        int windows;
        int doors;

        public int Underpinning
        {
            get { return underpinning; }
            set { underpinning = value; }
        }
        public int Walls
        {
            get { return walls; }
            set { walls = value; }
        }
        public int Roof
        {
            get { return roof; }
            set { roof = value; }
        }
        public int Windows
        {
            get { return windows; }
            set { windows = value; }
        }
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
    }

    class Builder
    {
        public void bild(Project project)
        {
            if (project.Underpinning < 1)
            {
                Console.WriteLine("Строю фундамент");
                project.Underpinning++;
            }
            else if (project.Walls < 4)
            {
                Console.WriteLine("Строю стену");
                project.Walls++;
            }
            else if (project.Roof < 1)
            {
                Console.WriteLine("Строю крышу");
                project.Roof++;
            }
            else if (project.Windows < 4)
            {
                Console.WriteLine("Ставлю окно");
                project.Windows++;
            }
            else if (project.Doors < 1)
            {
                Console.WriteLine("Ставлю дверь");
                project.Doors++;
            }
            else
            {
                Console.WriteLine("Дом построен");
            }
        }
    }

    class TeamLeader
    {
        public void Check(Project project)
        {
            if (project.Underpinning < 1)
            {
                Console.WriteLine("Ничего не построено");
            }
            else if (project.Walls < 4)
            {
                Console.WriteLine("Построен фундамент");
            }
            else if (project.Roof < 1)
            {
                Console.WriteLine("Построены стены и фундамент");
            }
            else if (project.Windows < 4)
            {
                Console.WriteLine("Построены крыша, стены и фундамент");
            }
            else if (project.Doors < 1)
            {
                Console.WriteLine("Построены окна, крыша, стены и фундамент");
            }
            else
            {
                Console.WriteLine("Дом построен");
            }
        }
    }       

    class DrawingOfProject
    {
        public void Draw(Project project)
        {
            Console.WriteLine("Фундаментов: " + project.Underpinning);
            Console.WriteLine("Стен: " + project.Walls);
            Console.WriteLine("Крыш: " + project.Roof);
            Console.WriteLine("Окон: " + project.Windows);
            Console.WriteLine("Дверей: " + project.Doors);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Project project = new Project();
            Builder builder = new Builder();
            TeamLeader teamLeader = new TeamLeader();
            DrawingOfProject drawingOfProject = new DrawingOfProject();

            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Строительство дома");
                Console.WriteLine("1 - построить дом");
                Console.WriteLine("2 - проверить дом");
                Console.WriteLine("3 - показать чертеж");
                Console.WriteLine("4 - выход");

                Console.Write("Выберите действие: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.Write("Вывод: ");
                switch (choice)
                {
                    case 1:
                        builder.bild(project);
                        break;
                    case 2:
                        teamLeader.Check(project);
                        break;
                    case 3:
                        drawingOfProject.Draw(project);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
