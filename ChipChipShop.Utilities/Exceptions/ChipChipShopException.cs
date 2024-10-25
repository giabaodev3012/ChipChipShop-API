using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipChipShop.Utilities.Exceptions
{
    public class ChipChipShopException : Exception
    {
        public ChipChipShopException()
        {
        }

        public ChipChipShopException(string message)
            : base(message)
        {
        }

        public ChipChipShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
