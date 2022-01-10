using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    // Sử dụng chung một database access
    public class ModelEntity
    {
        public static Model.ConvenienceStoreEntities db = new Model.ConvenienceStoreEntities();
    }
}