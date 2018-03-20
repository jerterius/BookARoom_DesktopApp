using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookARoom.Utilities
{
    public class ExceptionHandler
    {
           public static string ConvertSQLExceptionToMessage(SqlException e1)
        {

            try
            {
                string eCode = e1.ErrorCode.ToString();

                switch (eCode)
                {
                    case "8152":
                        return "<html><font color='red'>Fel: Ogiltigt antal tecken!" + "</font></html>";

                    case "2627":
                        return "<html><font color='red'>Fel: Förekommer redan i registret!</font></html>";

                    case "547":
                        string checkConstraintName = e1.Message.ToString();

                        if (checkConstraintName.ToLower().IndexOf("PK_dbo.Customers") >= 0)
                        {
                            return "<html><font color='red'>Fel: Det finns redan en användare med den här mejlen!</font></html>";

                        }
                 
                        else if (checkConstraintName.ToLower().IndexOf("IX_DateRoom") >= 0)
                        {
                            return "<html><font color='red'>Fel: Du har redan bokat det här rummet det här datumet! </font></html>";

                        }
                        return "Unkown check constraint";

                     default:
                        return "<html><font color='red'>Fel: Okänt fel! Kod: " + eCode + "</font></html>";
                }

            }
            catch (Exception e2)
            {
                return ConvertExceptionToMessage(e2);
            }
        }

        public static string ConvertExceptionToMessage(Exception e2)
        {
            string eCode = e2.Message.ToString();

            if (eCode.IndexOf("Login failed for user") != -1)
            {
                return "<html><font color='red'>Användarupgifterna är ej giltiga! </font></html>";

            }
            else
            {
                var st = new StackTrace(e2, true);
                var query = st.GetFrames().Select(frame => new
                {
                    FileName = frame.GetFileName(),
                    LineNumber = frame.GetFileLineNumber(),
                    ColumnNumber = frame.GetFileColumnNumber(),
                    Method = frame.GetMethod(),
                    Class = frame.GetMethod().DeclaringType,
                });

                return query.ToString();
            }

        }

    }
}
