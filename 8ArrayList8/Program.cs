﻿using System.Collections;

Console.WriteLine("ArrayList Remover elementos");

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Ze", 3, 9, 0 };

lista.Remove(null);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

Console.ReadKey();