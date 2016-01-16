using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMW.Models
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
        private string submissionHash;
        private DateTime datePublished;
        private string text;
        private int views;
        private string userHostAddress;

        //mutators
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

        public void setViews(int x)
        {
            views = x;
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

        public int getViews()
        {
            return views;
        }

        public string getUserHostAddress()
        {
            return userHostAddress;
        } 


        //methods
        public bool incrementViews()
        {
            if (views >= 0){
                views++;
                return true;
            }
            else{
                return false;
            }
        }
    }
}
