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
        Data structue to create and populate EF tables
  \\ End of Description
  * 
  \\ Attributes(fields)
     string submissionHash
     DateTime datePublished
     int views
     string userHostAddress
  \\ENd of Attributes(fields)
  * 
  \\Attribute Descriptions
    submissionHash is a hash of the submission. This will allow for o(1) look
        up times. Will serve as the primary key of the relation.
  --------------------------------------------------------------
    datePublished tracks when the submission was published to the IMW database
  --------------------------------------------------------------
    text contains the "story" submitted by the user.
  --------------------------------------------------------------
    views tracks teh number of views this submission has received.
  --------------------------------------------------------------
    userHostAddress contains the IP address of the user
  \\ end of Attribute Descriptions
  * 
  * 
  * \\ ENd of Summary
 */
    class Submissions
    {
        string submissionHash;
        DateTime datePublished;
        string text;
        int views;
        string userHostAddress;
    }
}
