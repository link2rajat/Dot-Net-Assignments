using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PhoneBookRESTXMLService
{
   [ServiceContract]
   public interface IPhoneBookRESTXMLService
   {
      // add an entry to the phone book database
      [OperationContract]
      [WebGet(___________________________)]
       ___________________________________________________

      // retrieve phone book entries with a given last name
      [OperationContract]
      [WebGet(_____________________________________)]
      _______________________________________________________________________________
   } // end interface IPhoneBookRESTXMLService
}

