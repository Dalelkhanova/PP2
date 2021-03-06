﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager2
{
    enum FARMode
    {
        DIR,
        FILE
    }

    class Layer
    {
        public List<FileSystemInfo> Content
        {
            get;
            set;
        }
        private int selectedItem;
        public int SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value >= Content.Count)
                {
                    selectedItem = 0;
                }
                else if (value < 0)
                {
                    selectedItem = Content.Count - 1;
                }
                else
                {
                    selectedItem = value;
                }
            }
        }


        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < Content.Count; ++i)
            {
                if (i == SelectedItem)//назначенный элемент будет выделяться синим фоном 
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                if (Content[i].GetType() == typeof(DirectoryInfo))//если элемент является папкой, то он будет отображаться белым 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;//если элемент является файлом, то он будет отображаться темно-красным цветом 
                }
                Console.WriteLine((i + 1) + "." + " " + Content[i].Name);

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FARMode mode = FARMode.DIR;
            DirectoryInfo root = new DirectoryInfo(@"C:\Users\admin\Desktop\English");
            Stack<Layer> history = new Stack<Layer>();
            history.Push(
            new Layer
            {
                Content = root.GetFileSystemInfos().ToList(),
                SelectedItem = 0
            }
            );


            while (true)
            {
                if (mode == FARMode.DIR)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();//выбор нескольких клавиш 
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--;//от данного объекта поднимаемся вверх 
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;//от данного объекта спускаемся вниз 
                        break;
                    case ConsoleKey.Backspace:
                        if (mode == FARMode.DIR)
                        {
                            history.Pop();
                        }
                        else
                        {
                            mode = FARMode.DIR;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Enter:
                        int gg = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[gg];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
                            history.Push(
                            new Layer
                            {
                                Content = directoryInfo.GetFileSystemInfos().ToList(),
                                SelectedItem = 0
                            });
                        }
                        else
                        {
                            mode = FARMode.FILE;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            using (StreamReader sr = new StreamReader(fileSystemInfo.FullName))
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }
                        }
                        break;
                }
            }
        }
    }
}