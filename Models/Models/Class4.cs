using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 /*\\Summary
 * 
 * 
 \\Description
  Data structure to create and populate EF tables
 \\ End of Description
 * 
 \\ Attributes(fields)
     string submissionHash
     DateTime datePublished
     string text
     string language
     string userHostAddress
 \\ENd of Attributes(fields)
 * 
 \\Attribute Descriptions
    submissionHash is the hash of the submission. This will allow for o(1) lookup times.
        Will serve as the primary key of the relation.
 -----------------------------------------------------
    datePublished trachs when the submission was published to teh IMW database.
 -----------------------------------------------------
    text contains the translation submitted by the user
 -----------------------------------------------------
    language contains the language of the translation
 -----------------------------------------------------
    userHostAddress contains the IPaddress of the user
 \\ end of Attribute Descriptions
 * 
 * 
 * \\ ENd of Summary
*/
    class Translations
    {
        private string submissionHash;
        private DateTime datePublished;
        private string text;
        private string language;
        private string userHostAddress;


        // mutators
        public void setSubmissionHash(string x)
        {
            submissionHash = x;
        }

        public void setDataPublished(DateTime x)
        {
            datePublished = x;
        }

        public void setText(string x)
        {
            text = x;
        }

        public void setLanguage(string x)
        {
            language = x;
        }

        public void setUserHostAddress(string x)
        {
            userHostAddress = x;
        }


        //accessors
        public string getSubmissionHash()
        {
            return submissionHash;
        }

        public DateTime getDatePublished()
        {
            return datePublished;
        }

        public string getText()
        {
            return text;
        }

        public string getLanguage()
        {
            return language;
        }

        public string getUserHostAddress()
        {
            return userHostAddress;
        } 
    }
}
