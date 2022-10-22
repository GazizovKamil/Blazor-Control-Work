﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.Data;
using Blazor_Control_Work.Data;

namespace EditorUnit
{
    class Mongo
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UserBase");
            var collection = database.GetCollection<User>("User");
            collection.InsertOne(user);
        }

        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UserBase");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => true).ToList();

            return list;
        }

        public static User Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UserBase");
            var collection = database.GetCollection<User>("User");
            var one = collection.Find(x => x.Login == name).FirstOrDefault();

            return one;
        }

        public static void ReplaceByName(string name, User unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UserBase");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(x => x.Login == name, unit);
        }
    }
}