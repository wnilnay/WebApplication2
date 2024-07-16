using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class DataBaseController : ApiController
    {
        // GET: api/DataBase
        public IEnumerable<TestData> Get()
        {
            using(For_TestEntities db = new For_TestEntities())
            {
                var z = (from a in db.TestData
                         select a).ToList();
                return z;
            }
        }
        // POST: api/DataBase
        public void Post([FromBody]int value)
        {
            using(For_TestEntities db = new For_TestEntities())
            {
                char[] chars = {'a','b','c','d','e','f','g','h','i','j','k','l','m',
                    'n','o','p','q','r','s','t','u','v','w','x','y','z'};
                string str = string.Empty;
                Random random = new Random();
                TestData data = new TestData();
                data.ID = value;
                int random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column1 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column2 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column3 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column4 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column5 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column6 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column7 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column8 = str;
                str = string.Empty;

                random_number = random.Next(1, 10 + 1);
                for (int i = 0; i < random_number; i++)
                {
                    int a = random.Next(0, 26);
                    str += chars[a];
                }
                data.column9 = str;

                db.TestData.Add(data);
                db.SaveChanges();
            }
        }
        public class UpdateDataModel
        {
            public int Id { get; set; }
            public string Column { get; set; }
            public string Value { get; set; }
        }

        // PUT: api/DataBase/5
        public void Put([FromBody]UpdateDataModel model)
        {
            using(For_TestEntities db = new For_TestEntities())
            {
                var z = (from a in db.TestData
                         where a.ID == model.Id
                         select a).FirstOrDefault();
                if( z != null)
                {
                    switch (model.Column)
                    {
                        case "column1":
                            z.column1 = model.Value; break;
                        case "column2":
                            z.column2 = model.Value; break;
                        case "column3":
                            z.column3 = model.Value; break;
                        case "column4":
                            z.column4 = model.Value; break;
                        case "column5":
                            z.column5 = model.Value; break;
                        case "column6":
                            z.column6 = model.Value; break;
                        case "column7":
                            z.column7 = model.Value; break;
                        case "column8":
                            z.column8 = model.Value; break;
                        case "column9":
                            z.column9 = model.Value; break;
                    }
                    db.SaveChanges();
                }
            }
        }

        // DELETE: api/DataBase/5
        public void Delete(int id)
        {
            using(For_TestEntities db = new For_TestEntities())
            {
                var z = (from a in db.TestData
                         where a.ID == id
                         select a).FirstOrDefault();
                if(z!= null)
                {
                    db.TestData.Remove(z);
                    db.SaveChanges();
                }
            }
        }
    }
}
