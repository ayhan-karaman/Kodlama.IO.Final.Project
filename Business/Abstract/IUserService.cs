using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User user);

        User GetByEmail(string email);

        List<OperationClaim> GetClaims(User user);
    }
}
