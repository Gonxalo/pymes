using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pymes.Common;
using pymes.DataAccess;
using pymes.DataAccess.CategoryDataSetTableAdapters;

namespace pymes.Rules
{
    public class CategoriaRules
    {
        public bool Update(CategoryDataSet.categoriaDataTable table) 
        {
            try
            {
                using (categoriaTableAdapter adapter = new categoriaTableAdapter())
                {
                    adapter.Update(table);
                }
                    return true;
            }
            catch(Exception ex)
            {
                LogManager.GuardaLog(ex.Message);
                return false;
            }
        }
    }
}
