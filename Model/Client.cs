using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client: Person
    {
        public override int GetNumberOfCaracters(string text)
        {
            return base.GetNumberOfCaracters(text);
        }
    }
}
