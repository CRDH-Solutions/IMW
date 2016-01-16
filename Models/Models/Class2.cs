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
        Data container for translations of submission text.
  \\ End of Description
  * 
  \\ Attributes(fields)
      string submissionHash
      string text
      string language
      string userHostAddress
  \\ENd of Attributes(fields)
  * 
  \\Attribute Descriptions
     submissionHash contains the hash of the submission being translated
  ----------------------------------------------------------------------
     text contains the translation submitted by the user
  ----------------------------------------------------------------------
     language contains the language of the translation
  ----------------------------------------------------------------------
     userHostAddress contains the IP address of the user
  \\ end of Attribute Descriptions
  * 
  * 
  * \\ ENd of Summary
 */
    class Translation
    {
        private string submissionHeadHash;
        private string text;
        private string language;
        private string userHostAddress;


        //mutators
        public void setSubmissionHeadHash(string x)
        {
            submissionHeadHash = x;
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
        public string getSubmissionHeadHash()
        {
            return submissionHeadHash;
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
