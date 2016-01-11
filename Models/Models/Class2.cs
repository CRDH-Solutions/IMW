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
        string submissionHeadHash;
        string text;
        string language;
        string userHostAddress;
    }
}
