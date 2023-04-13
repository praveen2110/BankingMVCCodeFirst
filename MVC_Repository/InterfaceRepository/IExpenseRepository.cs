using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository
{
    public interface IExpenseRepository
    {

        Expense Get(string Expense_date);
        int Insert(Expense expense);

    }
}
