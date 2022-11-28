﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppComprasDoSupermercado.Model
{
    public class Produto
    {
    [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
