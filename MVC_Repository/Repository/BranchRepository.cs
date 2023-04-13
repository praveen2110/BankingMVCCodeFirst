using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository
{
    public class BranchRepository
    {
        MVCDBContext context = new MVCDBContext();
        public List<Branch> GetAll()
        {
            return context.Branches.ToList();
        }

        public int Insert(Branch branch)
        {
            context.Branches.Add(branch);
            return context.SaveChanges();
        }

        public Branch Get(string Branch_Location)
        {
            return context.Branches.SingleOrDefault(d => d.Branch_Location == Branch_Location);
        }
    }
}
