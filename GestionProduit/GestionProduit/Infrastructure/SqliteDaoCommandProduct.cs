﻿using GestionProduit.Entity;
using GestionProduit.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduit.Infrastructure
{
    class SqliteDaoCommandProduct : IDaoCommandProduct
    {
        public SqliteDaoCommandProduct()
        {
        }

        public Task AddProductAsync(Produit produit)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(Produit produit)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Produit produit)
        {
            throw new NotImplementedException();
            //using (var connection = new SqliteConnection("Data Source=hello.db"))
            //{
            //    var command = connection.CreateCommand();
            //    command.CommandText =
            //        "UPDATE message SET text = $text1 WHERE id = 1;" +
            //        "UPDATE message SET text = $text2 WHERE id = 2";
            //    command.Parameters.AddWithValue("$text1", "Hello");
            //    command.Parameters.AddWithValue("$text2", "World");

            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }
    }
}
