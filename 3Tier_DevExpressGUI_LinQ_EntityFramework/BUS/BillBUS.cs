﻿using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class BillBUS
    {
        BillDAL bill_dal = new BillDAL();
        public IEnumerable<BILL> GetAll()
        {
            return bill_dal.GetAll();
        }
        public void Create(string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            bill_dal.setBill(id_sim, date_ex, date_cut, postage, fare,status);
            bill_dal.Create();
        }

        public void Delete(string id)
        {
            bill_dal.setBill(id);
            bill_dal.Delete();
        }

        public void Update(string id, string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            bill_dal.setBill(id, id_sim, date_ex, date_cut, postage, fare, status);
            bill_dal.Update();
        }
    }
}
