using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawel.Workshop.Entities
{
    public class Kontrahent
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string ownerName { get; set; }

        public string ownerSurname { get; set; }

        public string Address { get; set; }

        public string nipNumber { get; set; }

        public string peselNumber { get; set; }

        public string bankName { get; set; }

        public string phoneNumber { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            appedField(stringBuilder, name);
            appedField(stringBuilder, ownerName);
            appedField(stringBuilder, ownerSurname);
            appedField(stringBuilder, Address);

            return stringBuilder.ToString();
        }

        private void appedField(StringBuilder stringBuilder, string field)
        {
            string format = "{0} ";

            if (!string.IsNullOrWhiteSpace(field))
            {
                stringBuilder.AppendFormat(format, field);
            }
        }
    }
}
